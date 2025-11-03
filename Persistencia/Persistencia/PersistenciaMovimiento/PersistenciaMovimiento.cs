using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using Persistencia.BDs.PersistenciaMovimiento;
using Persistencia.PersistenciaCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    /// <summary>
    /// Clase que proporciona métodos para interactuar con la base de datos 
    /// de movimientos, realizando operaciones de creación, lectura, actualización y eliminación (CRUD).
    /// </summary>
    public class PersistenciaMovimiento
    {
        /// <summary>
        /// Crea un nuevo movimiento en la base de datos.
        /// </summary>
        /// <param name="movimiento">El movimiento a crear.</param>
        public static void CREATE(Movimiento movimiento)
        {
            MovimientoDato cd = TransformerMovimiento.Movimientoamovimientodato(movimiento);
            BD.TablaMovimiento.Add(cd);
        }

        /// <summary>
        /// Lee un movimiento específico de la base de datos usando la fecha y cuenta.
        /// </summary>
        /// <param name="Fecha">La fecha del movimiento.</param>
        /// <param name="Cuenta">La cuenta asociada al movimiento.</param>
        /// <returns>El movimiento correspondiente o null si no se encuentra.</returns>
        public static Movimiento READMovimiento(DateTime Fecha, string Cuenta)
        {
            var movimientoDato = BD.TablaMovimiento.FirstOrDefault(c => c.Id.Fecha.Year == Fecha.Year &&
                                                                         c.Id.Fecha.Month == Fecha.Month &&
                                                                         c.Id.Fecha.Day == Fecha.Day &&
                                                                         c.Id.Fecha.Hour == Fecha.Hour &&
                                                                         c.Id.Fecha.Minute == Fecha.Minute &&
                                                                         c.Id.Cuenta == Cuenta);

            return movimientoDato == null ? null : TransformerMovimiento.MovimientoDatoaMovimiento(movimientoDato);
        }

        /// <summary>
        /// Lee todos los movimientos de la base de datos.
        /// </summary>
        /// <returns>Una lista con todos los movimientos.</returns>
        public static List<Movimiento> READMovimientos()
        {
            List<Movimiento> lista = new List<Movimiento>();
            foreach (var m in BD.TablaMovimiento)
            {
                Movimiento movimiento = TransformerMovimiento.MovimientoDatoaMovimiento(m);
                lista.Add(movimiento);
            }
            return lista;
        }

        /// <summary>
        /// Actualiza un movimiento en la base de datos.
        /// </summary>
        /// <param name="movimiento">El movimiento a actualizar.</param>
        public static void UPDATE(Movimiento movimiento)
        {
            var movimientoExistente = BD.TablaMovimiento.FirstOrDefault(c => c.Id.Fecha == movimiento.Fecha && c.Id.Cuenta == movimiento.Cuenta.IBAN);
            if (movimientoExistente != null)
            {
                DELETE(movimiento.Fecha, movimiento.Cuenta.IBAN);
                CREATE(movimiento);
            }
        }

        /// <summary>
        /// Elimina un movimiento de la base de datos usando la fecha y cuenta.
        /// </summary>
        /// <param name="Fecha">La fecha del movimiento a eliminar.</param>
        /// <param name="cuenta">La cuenta asociada al movimiento a eliminar.</param>
        public static void DELETE(DateTime Fecha, string cuenta)
        {
            var movimientoDato = BD.TablaMovimiento.FirstOrDefault(c => c.Id.Fecha == Fecha && c.Id.Cuenta == cuenta);
            if (movimientoDato != null)
            {
                BD.TablaMovimiento.Remove(movimientoDato);
            }
        }

        /// <summary>
        /// Lee todos los movimientos de un cliente específico.
        /// </summary>
        /// <param name="DNI">El DNI del cliente.</param>
        /// <returns>Una lista de movimientos asociados al cliente.</returns>
        public static List<Movimiento> READMovimientosPorCliente(string DNI)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            foreach (var movimientodato in BD.TablaMovimiento)
            {
                if (movimientodato.Cliente == DNI)
                {
                    movimientos.Add(TransformerMovimiento.MovimientoDatoaMovimiento(movimientodato));
                }
            }
            return movimientos;
        }

        /// <summary>
        /// Lee todos los movimientos de una cuenta específica.
        /// </summary>
        /// <param name="IBAN">El IBAN de la cuenta.</param>
        /// <returns>Una lista de movimientos asociados a la cuenta.</returns>
        public static List<Movimiento> READMovimientosPorCuenta(string IBAN)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            foreach (var movimientodato in BD.TablaMovimiento)
            {
                if (movimientodato.Id.Cuenta == IBAN)
                {
                    movimientos.Add(TransformerMovimiento.MovimientoDatoaMovimiento(movimientodato));
                }
            }
            return movimientos;
        }
    }
}

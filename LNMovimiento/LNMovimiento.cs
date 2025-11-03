using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using MD;
using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;

namespace LNMovimiento
{
    /// <summary>
    /// Clase abstracta que implementa las operaciones relacionadas con los movimientos de cuentas bancarias.
    /// </summary>
    public abstract class LNMovimiento : ILNMovimiento
    {
        private Empleado empleado;

        /// <summary>
        /// Constructor que inicializa un empleado para la clase LNMovimiento.
        /// </summary>
        /// <param name="empleado">Empleado que realiza los movimientos</param>
        public LNMovimiento(Empleado empleado)
        {
            this.empleado = empleado;
        }

        /// <summary>
        /// Realiza un movimiento en una cuenta.
        /// </summary>
        /// <param name="movimiento">El movimiento a realizar</param>
        public void RealizarMovimiento(Movimiento movimiento)
        {
            PersistenciaMovimiento.CREATE(movimiento);
        }

        /// <summary>
        /// Lee un movimiento específico de una cuenta en una fecha determinada.
        /// </summary>
        /// <param name="cuenta">La cuenta asociada al movimiento</param>
        /// <param name="fecha">La fecha del movimiento</param>
        /// <returns>El movimiento encontrado</returns>
        public Movimiento LeerMovimiento(Cuenta cuenta, DateTime fecha)
        {
            return PersistenciaMovimiento.READMovimiento(fecha, cuenta.IBAN);
        }

        /// <summary>
        /// Obtiene todos los movimientos registrados en el sistema.
        /// </summary>
        /// <returns>Lista de todos los movimientos</returns>
        public List<Movimiento> ObtenerMovimientos()
        {
            return PersistenciaMovimiento.READMovimientos();
        }

        /// <summary>
        /// Obtiene los movimientos de una cuenta específica.
        /// </summary>
        /// <param name="cuenta">La cuenta de la cual obtener los movimientos</param>
        /// <returns>Lista de movimientos de la cuenta</returns>
        public List<Movimiento> MovimientosCuenta(Cuenta cuenta)
        {
            return PersistenciaMovimiento.READMovimientosPorCuenta(cuenta.IBAN);
        }

        /// <summary>
        /// Obtiene los movimientos de una cuenta en un rango de fechas específico.
        /// </summary>
        /// <param name="cuenta">La cuenta de la cual obtener los movimientos</param>
        /// <param name="inicio">Fecha de inicio del rango</param>
        /// <param name="fin">Fecha de fin del rango</param>
        /// <returns>Lista de movimientos en el rango de fechas</returns>
        public List<Movimiento> MovimientosPorRangoFechas(Cuenta cuenta, DateTime inicio, DateTime fin)
        {
            List<Movimiento> movimientos = MovimientosCuenta(cuenta);
            return movimientos.FindAll((m) => m.Fecha >= inicio && m.Fecha <= fin);
        }

        /// <summary>
        /// Obtiene el cliente asociado a un movimiento en una cuenta y fecha específica.
        /// </summary>
        /// <param name="cuenta">La cuenta asociada al movimiento</param>
        /// <param name="fecha">La fecha del movimiento</param>
        /// <returns>El cliente asociado al movimiento</returns>
        public Cliente ObtenerClientePorMovimiento(Cuenta cuenta, DateTime fecha)
        {
            Movimiento movimiento = PersistenciaMovimiento.READMovimiento(fecha, cuenta.IBAN);
            return movimiento.Cliente;
        }

        /// <summary>
        /// Obtiene todos los movimientos de una cuenta específica.
        /// </summary>
        /// <param name="cuenta">La cuenta de la cual obtener los movimientos</param>
        /// <returns>Lista de movimientos de la cuenta</returns>
        public List<Movimiento> ObtenerMovimientosCuenta(Cuenta cuenta)
        {
            return PersistenciaMovimiento.READMovimientosPorCuenta(cuenta.IBAN);
        }

        /// <summary>
        /// Obtiene todos los movimientos de un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos del día</returns>
        public List<Movimiento> ObtenerMovimientosDia(DateTime dia)
        {
            List<Movimiento> todosMovimientos = PersistenciaMovimiento.READMovimientos();
            return todosMovimientos.FindAll(m => m.Fecha.Date == dia.Date);
        }

        /// <summary>
        /// Obtiene los movimientos de pagos y recibos realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de pagos y recibos</returns>
        public List<Movimiento> ObtenerPagosRecibosDia(DateTime dia)
        {
            List<Movimiento> movimientosDia = ObtenerMovimientosDia(dia);
            return movimientosDia.FindAll(m => m is PagoRecibo);
        }

        /// <summary>
        /// Obtiene los movimientos de ingresos realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de ingresos</returns>
        public List<Movimiento> ObtenerIngresosDia(DateTime dia)
        {
            List<Movimiento> movimientosDia = ObtenerMovimientosDia(dia);
            return movimientosDia.FindAll(m => m is Ingreso);
        }

        /// <summary>
        /// Obtiene los movimientos de transferencias realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de transferencias</returns>
        public List<Movimiento> ObtenerTransferenciasDia(DateTime dia)
        {
            List<Movimiento> movimientosDia = ObtenerMovimientosDia(dia);
            return movimientosDia.FindAll(m => m is Transferencia);
        }

        /// <summary>
        /// Obtiene los movimientos de reintegros realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de reintegros</returns>
        public List<Movimiento> ObtenerReintegrosDia(DateTime dia)
        {
            List<Movimiento> movimientosDia = ObtenerMovimientosDia(dia);
            return movimientosDia.FindAll(m => m is Reintegro);
        }

        /// <summary>
        /// Obtiene un movimiento por fecha y número de cuenta.
        /// </summary>
        /// <param name="fecha">La fecha del movimiento</param>
        /// <param name="cuenta">El número de cuenta asociado al movimiento</param>
        /// <returns>El movimiento encontrado o null si no existe</returns>
        public Movimiento MovimientoPorFechaYCuenta(DateTime fecha, string cuenta)
        {
            List<Movimiento> movimientosDia = ObtenerMovimientosDia(fecha);
            foreach (Movimiento mov in movimientosDia)
            {
                if (mov.Cuenta.IBAN == cuenta)
                {
                    return mov;
                }
            }
            return null;
        }
    }
}

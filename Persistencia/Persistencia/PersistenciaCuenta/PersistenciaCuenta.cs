using MD.MDCliente;
using MD.MDCuenta;
using Persistencia.PersistenciaCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.PersistenciaCuenta
{
    /// <summary>
    /// Clase de persistencia para gestionar las operaciones CRUD de las cuentas.
    /// </summary>
    public class PersistenciaCuenta
    {
        /// <summary>
        /// Crea una nueva cuenta y la añade a la base de datos.
        /// </summary>
        /// <param name="cuenta">La cuenta a añadir.</param>
        public static void CREATE(Cuenta cuenta)
        {
            CuentaDato cd = TransformerCuenta.CuentaACuentaDato(cuenta);
            BD.TablaCuenta.Add(cd);
        }

        /// <summary>
        /// Elimina una cuenta de la base de datos por su IBAN.
        /// </summary>
        /// <param name="iban">El IBAN de la cuenta a eliminar.</param>
        public static void DELETE(String iban)
        {
            if (BD.TablaCuenta.Contains(iban))
            {
                BD.TablaCuenta.Remove(iban);
            }
        }

        /// <summary>
        /// Obtiene una lista de los propietarios de una cuenta.
        /// </summary>
        /// <param name="c">La cuenta de la que obtener los propietarios.</param>
        /// <returns>Lista de los clientes propietarios de la cuenta.</returns>
        public static List<string> ObtenerPropietario(Cuenta c)
        {
            List<string> lista = new List<string>();
            foreach (var dato in BD.TablaPropietario)
            {
                if (dato.Id.Cuenta == c.IBAN)
                {
                    lista.Add(dato.Id.Cliente);
                }
            }
            return lista;
        }

        /// <summary>
        /// Lee una cuenta de la base de datos por su IBAN.
        /// </summary>
        /// <param name="iban">El IBAN de la cuenta a leer.</param>
        /// <returns>La cuenta correspondiente al IBAN, o null si no se encuentra.</returns>
        public static Cuenta READCuenta(string iban)
        {
            CuentaDato cuentaDato = BD.TablaCuenta.FirstOrDefault(c => c.Id == iban);
            return cuentaDato == null ? null : TransformerCuenta.CuentaDatoACuenta(cuentaDato);
        }

        /// <summary>
        /// Lee todas las cuentas de la base de datos.
        /// </summary>
        /// <returns>Lista de todas las cuentas en la base de datos.</returns>
        public static List<Cuenta> READCuentas()
        {
            return BD.TablaCuenta.Select(cuentaDato => TransformerCuenta.CuentaDatoACuenta(cuentaDato)).ToList();
        }

        /// <summary>
        /// Actualiza una cuenta en la base de datos.
        /// </summary>
        /// <param name="cuenta">La cuenta a actualizar.</param>
        public static void UPDATE(Cuenta cuenta)
        {
            var cuentaExistente = BD.TablaCuenta.FirstOrDefault(c => c.Id == cuenta.IBAN);
            if (cuentaExistente != null)
            {
                DELETEporIBAN(cuenta.IBAN);
                CREATE(cuenta);
            }
        }

        /// <summary>
        /// Elimina una cuenta de la base de datos por su IBAN.
        /// </summary>
        /// <param name="iban">El IBAN de la cuenta a eliminar.</param>
        public static void DELETEporIBAN(string iban)
        {
            var cuentaDato = BD.TablaCuenta.FirstOrDefault(c => c.Id == iban);
            if (cuentaDato != null)
            {
                BD.TablaCuenta.Remove(cuentaDato);
            }
        }
    }
}

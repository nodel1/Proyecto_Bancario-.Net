using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using Persistencia;
using Persistencia.BDs.PersistenciaMovimiento;
using Persistencia.Persistencia.PersistenciaMovimiento;
using Persistencia.PersistenciaCuenta;

namespace Persistencia
{
    /// <summary>
    /// Clase responsable de gestionar la persistencia de los clientes, incluyendo operaciones de CRUD (crear, leer, actualizar, eliminar) y la relación con las cuentas asociadas.
    /// </summary>
    public class PersistenciaCliente
    {
        /// <summary>
        /// Crea un nuevo cliente en la base de datos si no existe.
        /// </summary>
        /// <param name="cliente">El cliente a crear.</param>
        public static void CREATE(Cliente cliente)
        {
            ClienteDato cd = TranformerCliente.ClienteAClienteDato(cliente);
            if (BD.TablaCliente.Contains(cd) == false)
            {
                BD.TablaCliente.Add(cd);
            }
        }

        /// <summary>
        /// Obtiene un cliente por su DNI.
        /// </summary>
        /// <param name="dni">El DNI del cliente a buscar.</param>
        /// <returns>El cliente correspondiente, o null si no se encuentra.</returns>
        public static Cliente READCliente(string dni)
        {
            if (BD.TablaCliente.Contains(dni))
            {
                return TranformerCliente.ClienteDatoACliente(BD.TablaCliente[dni]);
            }
            return null;
        }

        /// <summary>
        /// Obtiene la lista de todos los clientes registrados.
        /// </summary>
        /// <returns>Una lista de todos los clientes.</returns>
        public static List<Cliente> READClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach (var clienteDato in BD.TablaCliente)
            {
                clientes.Add(TranformerCliente.ClienteDatoACliente(clienteDato));
            }
            return clientes;
        }

        /// <summary>
        /// Asocia una cuenta bancaria a un cliente.
        /// </summary>
        /// <param name="cliente">El cliente al que se le asociará la cuenta.</param>
        /// <param name="cuenta">La cuenta que se asociará al cliente.</param>
        public static void aniadirCuentaAlCliente(Cliente cliente, Cuenta cuenta)
        {
            string cuentita = cuenta.IBAN;
            string clientito = cliente.DNI;
            PropietarioDato propie = new PropietarioDato(cuentita, clientito);

            BD.TablaPropietario.Add(propie);
        }

        /// <summary>
        /// Actualiza la información de un cliente en la base de datos.
        /// </summary>
        /// <param name="cliente">El cliente con los nuevos datos.</param>
        public static void UPDATE(Cliente cliente)
        {
            if (BD.TablaCliente.Contains(cliente.DNI))
            {
                DELETE(cliente.DNI);
                CREATE(cliente);
            }
        }

        /// <summary>
        /// Elimina un cliente de la base de datos y las cuentas asociadas.
        /// </summary>
        /// <param name="dni">El DNI del cliente a eliminar.</param>
        public static void DELETE(string dni)
        {
            Cliente c = READCliente(dni);
            List<Cuenta> cuentas = CuentasPorCliente(c);
            Console.WriteLine("Holahola");
            foreach (Cuenta cuenta in cuentas)
            {
                Console.WriteLine("Esta en el forach de CUENTAS");  // Entra dos veces porque hay dos cuentas
                PropietarioClave clave = new PropietarioClave(cuenta.IBAN, dni);
                PropietarioDato propietarioDato = new PropietarioDato(cuenta.IBAN, dni);
                foreach (PropietarioDato pro in BD.TablaPropietario)
                {
                    PropietarioClave clave1 = new PropietarioClave(pro.Id.Cuenta, pro.Id.Cliente);
                    if (clave1.Equals(c))
                    {
                        BD.TablaPropietario.Remove(propietarioDato);
                    }
                }

                if (BD.TablaPropietario.Contains(clave))
                {
                    Console.WriteLine("Ha entrado al bucle de propietario");
                    BD.TablaPropietario.Remove(clave);
                }

                if (PersistenciaCuenta.PersistenciaCuenta.ObtenerPropietario(cuenta).Count == 0 || PersistenciaCuenta.PersistenciaCuenta.ObtenerPropietario(cuenta) == null)
                {
                    Console.WriteLine("Ha entrado al bucle de cuenta");
                    PersistenciaCuenta.PersistenciaCuenta.DELETE(cuenta.IBAN);
                }
            }

            if (BD.TablaCliente.Contains(dni))
            {
                BD.TablaCliente.Remove(dni);
            }
        }

        /// <summary>
        /// Obtiene la lista de cuentas asociadas a un cliente.
        /// </summary>
        /// <param name="c">El cliente cuya lista de cuentas se desea obtener.</param>
        /// <returns>Una lista de las cuentas asociadas al cliente.</returns>
        public static List<Cuenta> CuentasPorCliente(Cliente c)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            foreach (var cuentausuario in BD.TablaPropietario)
            {
                if (cuentausuario.Id.Cliente == c.DNI)
                {
                    Cuenta cuentita = PersistenciaCuenta.PersistenciaCuenta.READCuenta(cuentausuario.Id.Cuenta);
                    cuentas.Add(cuentita);
                }
            }
            return cuentas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MD;
using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using Persistencia;
using Persistencia.BDs.PersistenciaEmpleado;
using Persistencia.PersistenciaCuenta;

namespace LNCliente
{
    public abstract class LNCliente : ILNCliente
    {
        private Empleado empleado;

        /// <summary>
        /// Constructor que inicializa la clase <see cref="LNCliente"/> con un empleado.
        /// </summary>
        /// <param name="empleado">Empleado que realiza las operaciones.</param>
        public LNCliente(Empleado empleado)
        {
            this.empleado = empleado;
        }

        /// <summary>
        /// Registra un nuevo empleado en la base de datos.
        /// </summary>
        /// <param name="empleado">Empleado a registrar.</param>
        public void darAltaEmpleado(Empleado empleado)
        {
            PersistenciaEmpleado.CREATE(empleado);
        }

        /// <summary>
        /// Verifica si un empleado con un DNI específico existe en la base de datos.
        /// </summary>
        /// <param name="dni">DNI del empleado a verificar.</param>
        /// <returns>True si el empleado existe, de lo contrario, false.</returns>
        public bool ExisteEmpleado(string dni)
        {
            Empleado empl = PersistenciaEmpleado.READEmpleado(dni);
            return empl != null;
        }

        /// <summary>
        /// Lee un cliente basado en su objeto cliente.
        /// </summary>
        /// <param name="cliente">Cliente a leer.</param>
        /// <returns>Cliente leído o null si no existe.</returns>
        public Cliente LeerCliente(Cliente cliente)
        {
            return PersistenciaCliente.READCliente(cliente.DNI);
        }

        /// <summary>
        /// Lee un cliente por su DNI.
        /// </summary>
        /// <param name="dni">DNI del cliente a leer.</param>
        /// <returns>Cliente correspondiente al DNI o null si no existe.</returns>
        public Cliente LeerClientePorDNI(string dni)
        {
            Cliente c = PersistenciaCliente.READCliente(dni);
            return c;
        }

        /// <summary>
        /// Verifica si un cliente existe en la base de datos.
        /// </summary>
        /// <param name="cliente">Cliente a verificar.</param>
        /// <returns>True si el cliente existe, de lo contrario, false.</returns>
        public bool ExisteCliente(Cliente cliente)
        {
            Cliente c = LeerCliente(cliente);
            return c != null;
        }

        /// <summary>
        /// Obtiene el nombre completo (nombre y apellido) de un cliente.
        /// </summary>
        /// <param name="cliente">Cliente del que obtener el nombre completo.</param>
        /// <returns>Nombre y apellido del cliente.</returns>
        public string NombreYApellido(Cliente cliente)
        {
            string nombreapellido = cliente.Nombre + " " + cliente.Apellido;
            return nombreapellido;
        }

        /// <summary>
        /// Verifica si un cliente existe por su DNI.
        /// </summary>
        /// <param name="dni">DNI del cliente a verificar.</param>
        /// <returns>True si el cliente existe, de lo contrario, false.</returns>
        public bool ExisteClientePorDNI(string dni)
        {
            Cliente c = PersistenciaCliente.READCliente(dni);
            return c != null;
        }

        /// <summary>
        /// Obtiene todos los clientes del banco.
        /// </summary>
        /// <returns>Lista de clientes del banco.</returns>
        public List<Cliente> ClientesBanco()
        {
            return PersistenciaCliente.READClientes();
        }

        /// <summary>
        /// Añade una cuenta a un cliente.
        /// </summary>
        /// <param name="cliente">Cliente al que añadir la cuenta.</param>
        /// <param name="cuenta">Cuenta a añadir al cliente.</param>
        public void AñadirCuentaAlCliente(Cliente cliente, Cuenta cuenta)
        {
            PersistenciaCliente.aniadirCuentaAlCliente(cliente, cuenta);
        }

        /// <summary>
        /// Obtiene las cuentas asociadas a un cliente.
        /// </summary>
        /// <param name="cliente">Cliente del que obtener las cuentas.</param>
        /// <returns>Lista de cuentas asociadas al cliente.</returns>
        public List<Cuenta> CuentasCliente(Cliente cliente)
        {
            return PersistenciaCliente.CuentasPorCliente(cliente);
        }

        /// <summary>
        /// Obtiene los movimientos realizados por un cliente.
        /// </summary>
        /// <param name="cliente">Cliente del que obtener los movimientos.</param>
        /// <returns>Lista de movimientos realizados por el cliente.</returns>
        public List<Movimiento> MovimientosCliente(Cliente cliente)
        {
            return PersistenciaMovimiento.READMovimientosPorCliente(cliente.DNI);
        }
    }
}

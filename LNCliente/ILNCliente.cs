using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCliente
{
    /// <summary>
    /// Interfaz que define las operaciones de acceso a la información del cliente en el sistema.
    /// </summary>
    public interface ILNCliente
    {
        /// <summary>
        /// Lee los datos de un cliente.
        /// </summary>
        /// <param name="cliente">El cliente cuyo dato será leído.</param>
        /// <returns>El cliente con la información actualizada.</returns>
        Cliente LeerCliente(Cliente cliente);

        /// <summary>
        /// Verifica si un cliente existe en el sistema.
        /// </summary>
        /// <param name="cliente">El cliente a verificar.</param>
        /// <returns>True si el cliente existe, false si no.</returns>
        bool ExisteCliente(Cliente cliente);

        /// <summary>
        /// Verifica si un cliente existe en el sistema por su DNI.
        /// </summary>
        /// <param name="dni">El DNI del cliente a verificar.</param>
        /// <returns>True si el cliente existe, false si no.</returns>
        bool ExisteClientePorDNI(string dni);

        /// <summary>
        /// Obtiene la lista de clientes registrados en el banco.
        /// </summary>
        /// <returns>Una lista de clientes.</returns>
        List<Cliente> ClientesBanco();

        /// <summary>
        /// Obtiene la lista de cuentas asociadas a un cliente.
        /// </summary>
        /// <param name="cliente">El cliente cuyas cuentas se desean obtener.</param>
        /// <returns>Una lista de cuentas asociadas al cliente.</returns>
        List<Cuenta> CuentasCliente(Cliente cliente);

        /// <summary>
        /// Obtiene la lista de movimientos asociados a un cliente.
        /// </summary>
        /// <param name="cliente">El cliente cuyas transacciones se desean obtener.</param>
        /// <returns>Una lista de movimientos asociados al cliente.</returns>
        List<Movimiento> MovimientosCliente(Cliente cliente);
    }
}

using MD.MDCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCliente
{
    /// <summary>
    /// Interfaz que extiende <see cref="ILNCliente"/> para operaciones administrativas de gestión de clientes.
    /// </summary>
    public interface ILNClienteAdmin : ILNCliente
    {
        /// <summary>
        /// Da de alta a un cliente en el sistema.
        /// </summary>
        /// <param name="cliente">El cliente a dar de alta.</param>
        void DarDeAltaCliente(Cliente cliente);

        /// <summary>
        /// Da de baja a un cliente en el sistema.
        /// </summary>
        /// <param name="cliente">El cliente a dar de baja.</param>
        void DarDeBajaCliente(Cliente cliente);
    }
}

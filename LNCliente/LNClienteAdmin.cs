using MD.MDActores;
using MD.MDCliente;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCliente
{
    public class LNClienteAdmin : LNCliente, ILNClienteAdmin
    {
        public LNClienteAdmin(Empleado empleado) : base(empleado)
        {

        }

        /// <summary>
        /// Da de alta a un nuevo cliente en la base de datos.
        /// </summary>
        /// <param name="cliente">Cliente a dar de alta.</param>
        public void DarDeAltaCliente(Cliente cliente)
        {
            PersistenciaCliente.CREATE(cliente);
        }

        /// <summary>
        /// Da de baja a un cliente en la base de datos mediante su DNI.
        /// </summary>
        /// <param name="cliente">Cliente a dar de baja.</param>
        public void DarDeBajaCliente(Cliente cliente)
        {
            PersistenciaCliente.DELETE(cliente.DNI);
        }
    }
}

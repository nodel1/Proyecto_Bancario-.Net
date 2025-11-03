using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCliente
{
    public class LNClienteVentanilla : LNCliente, ILNClienteVentanilla
    {
        /// <summary>
        /// Constructor que inicializa el empleado y la base de datos de clientes.
        /// </summary>
        /// <param name="empleado">Empleado que ejecuta las operaciones.</param>
        public LNClienteVentanilla(Empleado empleado) : base(empleado)
        {
        }
    }
}

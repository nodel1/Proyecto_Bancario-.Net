using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNMovimiento
{
    /// <summary>
    /// Clase que extiende la lógica de negocio de los movimientos para administración.
    /// </summary>
    public class LNMovimientoAdmin : LNMovimiento, ILNMovimientoAdmin
    {
        /// <summary>
        /// Constructor de la clase LNMovimientoAdmin.
        /// </summary>
        /// <param name="empleado">Empleado que realiza las operaciones de administración.</param>
        public LNMovimientoAdmin(Empleado empleado) : base(empleado) { }
    }
}

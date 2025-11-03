using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNMovimiento
{
    /// <summary>
    /// Clase que extiende la lógica de negocio de los movimientos para ventanilla.
    /// </summary>
    public class LNMovimientoVentanilla : LNMovimiento, ILNMovimientoVentanilla
    {
        /// <summary>
        /// Constructor de la clase LNMovimientoVentanilla.
        /// </summary>
        /// <param name="empleado">Empleado que realiza las operaciones en ventanilla.</param>
        public LNMovimientoVentanilla(Empleado empleado) : base(empleado) { }
    }
}

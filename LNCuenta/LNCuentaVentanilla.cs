using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCuenta
{
    /// <summary>
    /// Clase que maneja las operaciones relacionadas con las cuentas a través de la ventanilla.
    /// </summary>
    public class LNCuentaVentanilla : LNCuenta, ILNCuentaVentanilla
    {
        /// <summary>
        /// Constructor de LNCuentaVentanilla.
        /// </summary>
        /// <param name="empleado">Empleado asociado a la clase</param>
        public LNCuentaVentanilla(Empleado empleado) : base(empleado) { }
    }
}

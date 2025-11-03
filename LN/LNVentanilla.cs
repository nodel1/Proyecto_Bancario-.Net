using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class LNVentanilla : LN
    {
        /// <summary>
        /// Constructor de la clase LNVentanilla.
        /// Inicializa la lógica de negocio específica para empleados de ventanilla,
        /// asociando al empleado correspondiente.
        /// </summary>
        /// <param name="empl">Empleado asociado como encargado de ventanilla.</param>
        public LNVentanilla(Empleado empl) :
         base(empl, new LNCliente.LNClienteVentanilla(empl), new LNCuenta.LNCuentaVentanilla(empl), new LNMovimiento.LNMovimientoVentanilla(empl))
        {
        }
    }
}

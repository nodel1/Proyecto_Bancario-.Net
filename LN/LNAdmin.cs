using LNCliente;
using LNCuenta;
using LNMovimiento;
using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class LNAdmin : LN
    {
        /// <summary>
        /// Constructor de la clase LNAdmin.
        /// Inicializa la lógica de negocio específica para administradores,
        /// asociando al empleado correspondiente.
        /// </summary>
        /// <param name="empl">Empleado asociado como administrador.</param>
        public LNAdmin(Empleado empl) :
            base(empl, new LNClienteAdmin(empl), new LNCuentaAdmin(empl), new LNMovimientoAdmin(empl))
        {
        }
    }
}

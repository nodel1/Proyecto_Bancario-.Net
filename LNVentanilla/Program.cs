using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN;
using LNEmpleado;
using MD;
using MD.MDActores;

namespace LNVentanilla
{
    public class LNVentanilla : LNEmpleado.LNEmpleado
    {
        private Ventanilla ventanilla;

        public LNVentanilla(Ventanilla ventanilla)
        {
            this.ventanilla = ventanilla;
        }

        public Ventanilla Ven
        {
            get { return ventanilla; }
        }


    }
}

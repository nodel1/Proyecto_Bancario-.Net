using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN;

namespace Presentacion
{
    public partial class PRVentanilla : PREmpleado
    {
        public PRVentanilla (LNVentanilla lNVentanilla) : base(lNVentanilla)
        {
            InitializeComponent ();
            altaClienteToolStripMenuItem.Visible = false;
            bajaClienteToolStripMenuItem.Visible=false;
            crearCuentaToolStripMenuItem.Visible = false;
        }


    }
}

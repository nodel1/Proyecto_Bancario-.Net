using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FEstasSeguro : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FEstasSeguro"/>.
        /// Configura los botones con los resultados de diálogo correspondientes.
        /// </summary>
        public FEstasSeguro()
        {
            InitializeComponent();
            // Configura los botones con los resultados de diálogo
            btsi.DialogResult = DialogResult.OK;
            btno.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FEstasSeguro_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Maneja el evento de clic en la etiqueta.
        /// </summary>
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class FFechaYHora : Form
    {
        /// <summary>
        /// Almacena la fecha y hora seleccionada por el usuario.
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FFechaYHora"/>.
        /// Configura los botones de diálogo para los resultados correspondientes.
        /// </summary>
        public FFechaYHora()
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Obtiene la fecha y hora seleccionada por el usuario.
        /// </summary>
        public DateTime Fecha
        {
            get { return dateTimePicker1.Value; }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón Aceptar, guarda la fecha y hora seleccionada
        /// y cierra el formulario.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.fecha = dateTimePicker1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón Cancelar y cierra el formulario sin guardar.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FFechaYHora_Load(object sender, EventArgs e)
        {
        }
    }
}

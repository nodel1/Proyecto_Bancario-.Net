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
    public partial class FFechaRango : Form
    {
        /// <summary>
        /// Almacena la fecha de inicio seleccionada por el usuario.
        /// </summary>
        private DateTime fechainicio;

        /// <summary>
        /// Almacena la fecha de fin seleccionada por el usuario.
        /// </summary>
        private DateTime fechafin;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FFechaRango"/>.
        /// Configura los botones de diálogo para los resultados correspondientes.
        /// </summary>
        public FFechaRango()
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Obtiene la fecha de inicio seleccionada por el usuario.
        /// </summary>
        public DateTime FechaInicio
        {
            get { return dateTimePicker1.Value; }
        }

        /// <summary>
        /// Obtiene la fecha de fin seleccionada por el usuario.
        /// </summary>
        public DateTime FechaFin
        {
            get { return dateTimePicker2.Value; }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón Aceptar, guarda las fechas seleccionadas
        /// y cierra el formulario.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.fechainicio = dateTimePicker1.Value;
            this.fechafin = dateTimePicker2.Value;
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
        private void FFechaRango_Load(object sender, EventArgs e)
        {
        }
    }
}

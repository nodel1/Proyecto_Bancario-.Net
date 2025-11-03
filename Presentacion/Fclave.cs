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
    public partial class Fclave : Form
    {
        TipoFormularioClave tipo;
        string clave;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Fclave"/>.
        /// </summary>
        public Fclave()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Fclave"/> con un tipo específico de formulario.
        /// </summary>
        /// <param name="tipo">El tipo de formulario que se está creando.</param>
        public Fclave(TipoFormularioClave tipo) : this()
        {
            this.tipo = tipo;

            switch (tipo)
            {
                case (TipoFormularioClave.Cliente):
                    this.Text = "Introducir DNI";
                    txtClave.Text = "DNI";
                    break;
                case (TipoFormularioClave.Cuenta):
                    this.Text = "Introducir IBAN";
                    txtClave.Text = "IBAN";
                    break;
                case (TipoFormularioClave.Movimiento):
                    this.Text = "Introducir Movimiento";
                    txtClave.Text = "";
                    break;
            }
            this.clave = introducido.Text;

            btnAceptar.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Obtiene la clave introducida en el formulario.
        /// </summary>
        public string Clave
        {
            get
            {
                return introducido.Text;
            }
        }

        /// <summary>
        /// Maneja el evento de clic del label.
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Maneja el evento de cambio de texto en el campo de texto.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void Fclave_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de aceptar.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clave = introducido.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de cancelar.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

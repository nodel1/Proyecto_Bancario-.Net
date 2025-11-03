using MD.MDCliente;
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
    public partial class FClienteDatos : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FClienteDatos"/>.
        /// </summary>
        public FClienteDatos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FClienteDatos"/> con los datos de un cliente específico.
        /// </summary>
        /// <param name="DNI">El DNI del cliente.</param>
        /// <param name="Nom">El nombre del cliente.</param>
        /// <param name="ln">El objeto que proporciona acceso a la lógica de negocio.</param>
        public FClienteDatos(string DNI, string Nom, LN.LN ln)
        {
            InitializeComponent();
            Cliente c = ln.LNCliente.LeerClientePorDNI(DNI);
            TBApellido.Text = c.Apellido;
            TBnombre.Text = c.Nombre;
            TBEmail.Text = c.Email;
            TBDNI.Text = c.DNI;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de cancelar, cerrando el formulario.
        /// </summary>
        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FClienteDatos_Load(object sender, EventArgs e)
        {
        }
    }
}

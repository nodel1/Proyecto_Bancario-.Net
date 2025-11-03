using LN;
using LNCliente;
using MD.MDActores;
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
    public partial class FAltaCliente : Form
    {
        LN.LN ln;

        /// <summary>
        /// Constructor por defecto para inicializar el formulario.
        /// </summary>
        public FAltaCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que inicializa el formulario con el DNI y objeto LN proporcionados.
        /// </summary>
        /// <param name="dni">El DNI del cliente que se va a dar de alta</param>
        /// <param name="Ln">El objeto LN que contiene la lógica de negocio</param>
        public FAltaCliente(string dni, LN.LN Ln)
        {
            InitializeComponent();
            TBDNI.Text = dni;
            this.ln = Ln;
        }

        /// <summary>
        /// Maneja el clic del botón Aceptar para dar de alta un cliente.
        /// </summary>
        private void BTAceptar_Click(object sender, EventArgs e)
        {
            string nombre = TBnombre.Text;
            string apellido = TBApellido.Text;
            string email = TBEmail.Text;

            if (nombre != "" && apellido != "" && email != "")
            {
                Cliente cliente = new Cliente(nombre, apellido, TBDNI.Text, email);

                LNClienteAdmin lnad = (LNClienteAdmin)ln.LNCliente; //casteo que sea un admin
                lnad.DarDeAltaCliente(cliente);
                MessageBox.Show("Se ha añadido correctamente", "Cliente añadido");
                this.Close();
            }
            else
            {
                MessageBox.Show("Alguno de los campos esta vacío");
                BTAceptar_Click(sender, e);
            }
        }

        /// <summary>
        /// Maneja el clic del botón Cancelar para cerrar el formulario sin hacer cambios.
        /// </summary>
        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga el formulario.
        /// </summary>
        private void FAltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

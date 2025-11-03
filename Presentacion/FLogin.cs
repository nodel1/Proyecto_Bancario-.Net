using LN;
using LNCliente;
using MD.MDActores;
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
    public partial class FLogin : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario FLogin.
        /// </summary>
        public FLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de carga del formulario FLogin.
        /// </summary>
        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de clic en el botón de login. Realiza la validación de los campos y
        /// verifica la existencia del empleado en la base de datos. Abre la ventana correspondiente
        /// según el tipo de empleado seleccionado.
        /// </summary>
         private void button2_Click(object sender, EventArgs e)
        {
            // Verifica si todos los campos están completos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dniempl = textBox1.Text;

            // Si se ha seleccionado 'Ventanilla', crea un nuevo objeto Ventanilla
            if (radioVentanilla.Checked)
            {
                Ventanilla emp = new Ventanilla(textBox2.Text, textBox3.Text, dniempl);
                LNVentanilla ln = new LNVentanilla(emp);

                // Verifica si el empleado existe en la base de datos
                if (ln.LNCliente.ExisteEmpleado(dniempl))
                {
                    // Abre la ventana correspondiente para Ventanilla
                    PRVentanilla form = new PRVentanilla(ln);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("No existe el empleado");
                    return;
                }
            }
            // Si se ha seleccionado 'Administrador', crea un nuevo objeto Administrador
            else if (radioAdmin.Checked)
            {
                Administrador admin = new Administrador(textBox2.Text, textBox3.Text, dniempl);
                LNAdmin ln = new LNAdmin(admin);

                // Verifica si el empleado existe en la base de datos
                if (ln.LNCliente.ExisteEmpleado(dniempl))
                {
                    // Abre la ventana correspondiente para Administrador
                    PRAdministrador form = new PRAdministrador(ln);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("No existe el empleado");
                    return;
                }
            }
            else
            {
                // Si no se seleccionó un tipo de empleado, muestra un mensaje de error
                MessageBox.Show("Por favor, selecciona un tipo de empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Oculta el formulario de login
            this.Hide();
        }
    }
}

using MD.MDCliente;
using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentacion
{
    public partial class FCrearCuenta : Form
    {
        private LN.LN ln;
        private static List<Cliente> listaclientes = new List<Cliente>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FCrearCuenta"/>.
        /// </summary>
        public FCrearCuenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FCrearCuenta"/> con los parámetros proporcionados.
        /// </summary>
        /// <param name="iban">El IBAN de la cuenta.</param>
        /// <param name="Ln">El objeto que proporciona acceso a la lógica de negocio.</param>
        public FCrearCuenta(string iban, LN.LN Ln)
        {
            InitializeComponent();
            this.ln = Ln;
            CBEstado.DataSource = Enum.GetValues(typeof(EstadoCuenta));
            TBFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            TBIBAN.Text = iban;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de aceptar, creando la cuenta y asociando los titulares.
        /// </summary>
        private void BTAceptar_Click(object sender, EventArgs e)
        {
            string tipostring;
            var checkedRadio = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(rb => rb.Checked);

            if (checkedRadio == null || string.IsNullOrWhiteSpace(TBSaldo.Text) || CBEstado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TBFecha.Text) || !decimal.TryParse(TBSaldo.Text, out decimal result))
            {
                MessageBox.Show("Debe rellenar los campos correctamente");
                return;
            }
            tipostring = checkedRadio.Text;
            TipoCuenta tipo = (TipoCuenta)Enum.Parse(typeof(TipoCuenta), tipostring, true);
            EstadoCuenta estado = (EstadoCuenta)Enum.Parse(typeof(EstadoCuenta), CBEstado.SelectedItem.ToString(), true);
            DateTime fecha = DateTime.Parse(TBFecha.Text);
            decimal saldo = decimal.Parse(TBSaldo.Text);
            Cuenta cuenta = new Cuenta(TBIBAN.Text, tipo, saldo, fecha, estado);
            ln.LNCuenta.CrearCuenta(cuenta);

            MessageBox.Show("Cuenta añadida con exito");
            this.Close();

            // Se añaden los titulares a la cuenta
            foreach (Cliente c in listaclientes)
            {
                ln.LNCliente.AñadirCuentaAlCliente(c, cuenta);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de cancelar, cerrando el formulario.
        /// </summary>
        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de añadir titular, mostrando un formulario de clave para agregar un cliente.
        /// </summary>
        private void BTTitular_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave; // DNI introducido
                if (ln.LNCliente.ExisteClientePorDNI(dni))
                {
                    formClave.Dispose();
                    Cliente cliente = ln.LNCliente.LeerClientePorDNI(dni);
                    if (listbox.Items.Count < 4)
                    {
                        listbox.Items.Add(cliente.DNI + ", " + cliente.Nombre + " " + cliente.Apellido);
                        listaclientes.Add(cliente);
                    }
                    else
                    {
                        MessageBox.Show("Solo se puede añadir un máximo de 4 titulares por cuenta");
                    }
                }
                else
                {
                    DialogResult existe = MessageBox.Show("No existe un cliente con ese DNI. ¿Quieres introducir otro?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (existe == DialogResult.Yes)
                    {
                        BTTitular.PerformClick();
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FCrearCuenta_Load(object sender, EventArgs e)
        {
        }
    }
}

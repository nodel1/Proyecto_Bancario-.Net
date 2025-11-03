using LN;
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

namespace Presentacion
{
    public partial class FCuentaDatos : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FCuentaDatos"/>.
        /// </summary>
        public FCuentaDatos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FCuentaDatos"/> con los parámetros proporcionados.
        /// Muestra los datos de la cuenta y los titulares asociados.
        /// </summary>
        /// <param name="cuentas">La cuenta cuya información se debe mostrar.</param>
        /// <param name="ln">El objeto que proporciona acceso a la lógica de negocio.</param>
        public FCuentaDatos(Cuenta cuentas, LN.LN ln)
        {
            InitializeComponent();
            TBIBAN.Text = cuentas.IBAN;
            TBTipo.Text = cuentas.Tipo.ToString();
            TBSaldo.Text = cuentas.Saldo.ToString();
            TBFecha.Text = cuentas.FechaApertura.ToString();
            TBEstado.Text = cuentas.Estado.ToString();

            List<Cliente> clientes = new List<Cliente>();
            foreach (string s in ln.LNCuenta.ObtenerTitulares(cuentas))
            {
                if (!clientes.Contains(ln.LNCliente.LeerClientePorDNI(s)))
                {
                    clientes.Add(ln.LNCliente.LeerClientePorDNI(s));
                }
            }

            listbox.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                if (cliente != null)
                {
                    listbox.Items.Add(cliente.DNI + ", " + cliente.Nombre + " " + cliente.Apellido);
                }
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FCuentaDatos_Load(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class FRecorridoCuenta : Form
    {
        private int numeroclientes;
        private static int contador = 0;
        private List<Cuenta> cuentas;
        private LN.LN ln;

        /// <summary>
        /// Inicializa una nueva instancia del formulario FRecorridoCuenta.
        /// </summary>
        public FRecorridoCuenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario FRecorridoCuenta con una lista de cuentas y una instancia de LN.
        /// </summary>
        /// <param name="Cuentas">Lista de cuentas a mostrar.</param>
        /// <param name="LN">Instancia de la capa de lógica de negocio.</param>
        public FRecorridoCuenta(List<Cuenta> Cuentas, LN.LN LN)
        {
            InitializeComponent();
            this.ln = LN;
            this.cuentas = Cuentas;
            labelposicion.Text = contador + 1 + " de " + cuentas.Count.ToString();
            if (contador >= 0 && cuentas.Count > 0)
            {
                TBIBAN.Text = cuentas[0].IBAN;
                TBTipo.Text = cuentas[0].Tipo.ToString();
                TBSaldo.Text = cuentas[0].Saldo.ToString();
                TBFecha.Text = cuentas[0].FechaApertura.ToString();
                TBEstado.Text = cuentas[0].Estado.ToString();
                List<Cliente> clientes = new List<Cliente>();
                foreach (string s in ln.LNCuenta.ObtenerTitulares(cuentas[0]))
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
            EstadoBotones();
        }

        /// <summary>
        /// Actualiza el estado de los botones de navegación según la posición actual.
        /// </summary>
        private void EstadoBotones()
        {
            BTAnterior.Enabled = contador > 0;
            BTPrimero.Enabled = contador > 0;
            BTSiguiente.Enabled = contador < cuentas.Count - 1;
            BTUltimo.Enabled = contador < cuentas.Count - 1;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Siguiente" para mostrar la siguiente cuenta.
        /// </summary>
        private void BTSiguiente_Click(object sender, EventArgs e)
        {
            contador++;
            labelposicion.Text = contador + 1 + " de " + cuentas.Count.ToString();
            TBIBAN.Text = cuentas[contador].IBAN;
            TBTipo.Text = cuentas[contador].Tipo.ToString();
            TBSaldo.Text = cuentas[contador].Saldo.ToString();
            TBFecha.Text = cuentas[contador].FechaApertura.ToString();
            TBEstado.Text = cuentas[contador].Estado.ToString();
            List<Cliente> clientes = new List<Cliente>();
            foreach (string s in ln.LNCuenta.ObtenerTitulares(cuentas[contador]))
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
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Anterior" para mostrar la cuenta anterior.
        /// </summary>
        private void BTAnterior_Click(object sender, EventArgs e)
        {
            contador--;
            labelposicion.Text = contador + 1 + " de " + cuentas.Count.ToString();
            TBIBAN.Text = cuentas[contador].IBAN;
            TBTipo.Text = cuentas[contador].Tipo.ToString();
            TBSaldo.Text = cuentas[contador].Saldo.ToString();
            TBFecha.Text = cuentas[contador].FechaApertura.ToString();
            TBEstado.Text = cuentas[contador].Estado.ToString();
            List<Cliente> clientes = new List<Cliente>();
            foreach (string s in ln.LNCuenta.ObtenerTitulares(cuentas[contador]))
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
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Último" para mostrar la última cuenta.
        /// </summary>
        private void BTUltimo_Click(object sender, EventArgs e)
        {
            contador = cuentas.Count - 1;
            labelposicion.Text = contador + 1 + " de " + cuentas.Count.ToString();
            TBIBAN.Text = cuentas[contador].IBAN;
            TBTipo.Text = cuentas[contador].Tipo.ToString();
            TBSaldo.Text = cuentas[contador].Saldo.ToString();
            TBFecha.Text = cuentas[contador].FechaApertura.ToString();
            TBEstado.Text = cuentas[contador].Estado.ToString();
            List<Cliente> clientes = new List<Cliente>();
            foreach (string s in ln.LNCuenta.ObtenerTitulares(cuentas[contador]))
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
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Primero" para mostrar la primera cuenta.
        /// </summary>
        private void BTPrimero_Click(object sender, EventArgs e)
        {
            contador = 0;
            labelposicion.Text = contador + 1 + " de " + cuentas.Count.ToString();
            TBIBAN.Text = cuentas[contador].IBAN;
            TBTipo.Text = cuentas[contador].Tipo.ToString();
            TBSaldo.Text = cuentas[contador].Saldo.ToString();
            TBFecha.Text = cuentas[contador].FechaApertura.ToString();
            TBEstado.Text = cuentas[contador].Estado.ToString();
            List<Cliente> clientes = new List<Cliente>();
            foreach (string s in ln.LNCuenta.ObtenerTitulares(cuentas[contador]))
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
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de carga del formulario FRecorridoCuenta.
        /// </summary>
        private void FRecorridoCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}

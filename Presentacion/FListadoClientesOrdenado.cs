using MD.MDCliente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FListadoClientesOrdenado : Form
    {
        /// <summary>
        /// Lista de clientes junto con su saldo asociado.
        /// </summary>
        public List<(Cliente cliente, decimal saldo)> listaclientes;

        /// <summary>
        /// Instancia de la clase lógica de negocio.
        /// </summary>
        LN.LN ln;

        /// <summary>
        /// Inicializa una nueva instancia del formulario sin parámetros.
        /// </summary>
        public FListadoClientesOrdenado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario con una lista de clientes y una instancia de lógica de negocio.
        /// </summary>
        /// <param name="listaClientes">Lista de clientes y sus saldos asociados.</param>
        /// <param name="LN">Instancia de la lógica de negocio para obtener información de los clientes.</param>
        public FListadoClientesOrdenado(List<(Cliente cliente, decimal saldo)> listaClientes, LN.LN LN)
        {
            InitializeComponent();
            this.ln = LN;
            this.listaclientes = listaClientes;

            // Añade los datos de los clientes a los ListBox
            foreach (var dato in listaClientes)
            {
                lbdni.Items.Add(dato.cliente.DNI);
                lbnombre.Items.Add(ln.LNCliente.NombreYApellido(dato.cliente));
                lbsaldo.Items.Add(dato.saldo);
            }
        }

        /// <summary>
        /// Ordena la lista de clientes por DNI y actualiza los ListBox.
        /// </summary>
        private void btdni_Click(object sender, EventArgs e)
        {
            List<string> dniordenados = new List<string>();

            // Añadir los DNIs a la lista
            foreach (var item in lbdni.Items)
            {
                dniordenados.Add(item.ToString());
            }

            // Ordena los DNIs
            dniordenados.Sort();

            // Limpia los ListBox actuales
            lbdni.Items.Clear();
            lbnombre.Items.Clear();
            lbsaldo.Items.Clear();

            // Añadir los clientes ordenados por DNI
            foreach (string dni in dniordenados)
            {
                lbdni.Items.Add(dni);
                foreach (var item in listaclientes)
                {
                    if (item.cliente.DNI == dni)
                    {
                        lbnombre.Items.Add(ln.LNCliente.NombreYApellido(item.cliente));
                        lbsaldo.Items.Add(item.saldo);
                    }
                }
            }
        }

        /// <summary>
        /// Ordena la lista de clientes por nombre y actualiza los ListBox.
        /// </summary>
        private void btnombre_Click(object sender, EventArgs e)
        {
            List<string> nombresordenados = new List<string>();

            // Añadir los nombres a la lista
            foreach (var item in lbnombre.Items)
            {
                nombresordenados.Add(item.ToString());
            }

            // Ordena los nombres
            nombresordenados.Sort();

            // Limpia los ListBox actuales
            lbdni.Items.Clear();
            lbnombre.Items.Clear();
            lbsaldo.Items.Clear();

            // Añadir los clientes ordenados por nombre
            foreach (string nombre in nombresordenados)
            {
                lbnombre.Items.Add(nombre);

                foreach (var item in listaclientes)
                {
                    if (ln.LNCliente.NombreYApellido(item.cliente) == nombre)
                    {
                        lbdni.Items.Add(item.cliente.DNI);
                        lbsaldo.Items.Add(item.saldo);
                    }
                }
            }
        }

        /// <summary>
        /// Ordena la lista de clientes por saldo y actualiza los ListBox.
        /// </summary>
        private void btsaldo_Click(object sender, EventArgs e)
        {
            List<decimal> saldosordenados = new List<decimal>();

            // Añadir los saldos a la lista
            foreach (var item in lbsaldo.Items)
            {
                decimal saldito = decimal.Parse(item.ToString());
                saldosordenados.Add(saldito);
            }

            // Ordena los saldos
            saldosordenados.Sort();

            // Limpia los ListBox actuales
            lbdni.Items.Clear();
            lbnombre.Items.Clear();
            lbsaldo.Items.Clear();

            // Añadir los clientes ordenados por saldo
            foreach (decimal saldo in saldosordenados)
            {
                lbsaldo.Items.Add(saldo);
                foreach (var item in listaclientes)
                {
                    if (item.saldo == saldo)
                    {
                        lbnombre.Items.Add(ln.LNCliente.NombreYApellido(item.cliente));
                        lbdni.Items.Add(item.cliente.DNI);
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FListadoClientesOrdenado_Load(object sender, EventArgs e)
        {

        }
    }
}

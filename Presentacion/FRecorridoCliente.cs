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
    public partial class FRecorridoCliente : Form
    {
        /// <summary>
        /// Número de clientes que se están recorriendo.
        /// </summary>
        private int numeroclientes;

        /// <summary>
        /// Contador estático que mantiene la posición actual del cliente.
        /// </summary>
        private static int contador = 0;

        /// <summary>
        /// Lista de tuplas que contienen el cliente y su saldo.
        /// </summary>
        private List<(Cliente cliente, decimal saldo)> clientesConSaldo;

        /// <summary>
        /// Inicializa una nueva instancia del formulario FRecorridoCliente.
        /// </summary>
        public FRecorridoCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario FRecorridoCliente con una lista de clientes y sus saldos.
        /// </summary>
        /// <param name="clientesConSaldo">Lista de tuplas que contienen un cliente y su saldo.</param>
        public FRecorridoCliente(List<(Cliente cliente, decimal saldo)> clientesConSaldo)
        {
            InitializeComponent();
            // Cuando se abre, empieza con el primer cliente
            this.clientesConSaldo = clientesConSaldo;
            labelposicion.Text = contador + 1 + " de " + clientesConSaldo.Count.ToString();
            if (contador >= 0 && clientesConSaldo.Count > 0)
            {
                TBDNI.Text = clientesConSaldo[0].cliente.DNI;
                TBnombre.Text = clientesConSaldo[0].cliente.Nombre;
                TBApellido.Text = clientesConSaldo[0].cliente.Apellido;
                TBEmail.Text = clientesConSaldo[0].cliente.Email;
                TBSaldo.Text = clientesConSaldo[0].saldo.ToString();
            }
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Siguiente" para mostrar el siguiente cliente.
        /// </summary>
        private void BTSiguiente_Click(object sender, EventArgs e)
        {
            contador++;
            labelposicion.Text = contador + 1 + " de " + clientesConSaldo.Count.ToString();
            TBDNI.Text = clientesConSaldo[contador].cliente.DNI;
            TBnombre.Text = clientesConSaldo[contador].cliente.Nombre;
            TBApellido.Text = clientesConSaldo[contador].cliente.Apellido;
            TBEmail.Text = clientesConSaldo[contador].cliente.Email;
            TBSaldo.Text = clientesConSaldo[contador].saldo.ToString();
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Anterior" para mostrar el cliente anterior.
        /// </summary>
        private void BTAnterior_Click(object sender, EventArgs e)
        {
            contador--;
            labelposicion.Text = contador + 1 + " de " + clientesConSaldo.Count.ToString();
            TBDNI.Text = clientesConSaldo[contador].cliente.DNI;
            TBnombre.Text = clientesConSaldo[contador].cliente.Nombre;
            TBApellido.Text = clientesConSaldo[contador].cliente.Apellido;
            TBEmail.Text = clientesConSaldo[contador].cliente.Email;
            TBSaldo.Text = clientesConSaldo[contador].saldo.ToString();
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Último" para mostrar el último cliente.
        /// </summary>
        private void BTUltimo_Click(object sender, EventArgs e)
        {
            contador = clientesConSaldo.Count - 1;
            labelposicion.Text = contador + 1 + " de " + clientesConSaldo.Count.ToString();
            TBDNI.Text = clientesConSaldo[contador].cliente.DNI;
            TBnombre.Text = clientesConSaldo[contador].cliente.Nombre;
            TBApellido.Text = clientesConSaldo[contador].cliente.Apellido;
            TBEmail.Text = clientesConSaldo[contador].cliente.Email;
            TBSaldo.Text = clientesConSaldo[contador].saldo.ToString();
            EstadoBotones();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Primero" para mostrar el primer cliente.
        /// </summary>
        private void BTPrimero_Click(object sender, EventArgs e)
        {
            contador = 0;
            labelposicion.Text = contador + 1 + " de " + clientesConSaldo.Count.ToString();
            TBDNI.Text = clientesConSaldo[contador].cliente.DNI;
            TBnombre.Text = clientesConSaldo[contador].cliente.Nombre;
            TBApellido.Text = clientesConSaldo[contador].cliente.Apellido;
            TBEmail.Text = clientesConSaldo[contador].cliente.Email;
            TBSaldo.Text = clientesConSaldo[contador].saldo.ToString();
            EstadoBotones();
        }

        /// <summary>
        /// Actualiza el estado de los botones según la posición actual del cliente.
        /// </summary>
        private void EstadoBotones()
        {
            BTAnterior.Enabled = contador > 0;
            BTPrimero.Enabled = contador > 0;
            BTSiguiente.Enabled = contador < clientesConSaldo.Count - 1;
            BTUltimo.Enabled = contador < clientesConSaldo.Count - 1;
        }

        /// <summary>
        /// Maneja el evento de carga del formulario FRecorridoCliente.
        /// </summary>
        private void FRecorridoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

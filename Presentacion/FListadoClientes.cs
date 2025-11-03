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
    public partial class FListadoClientes : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FListadoClientes"/>.
        /// </summary>
        public FListadoClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FListadoClientes"/> 
        /// y carga los datos de los clientes y sus saldos en una tabla.
        /// </summary>
        /// <param name="listaClientes">Lista de tuplas que contiene un cliente y su saldo asociado.</param>
        public FListadoClientes(List<(Cliente cliente, decimal saldo)> listaClientes)
        {
            InitializeComponent();
            tabla.ColumnCount = 5; // Número de columnas
            tabla.Columns[0].Name = "DNI";
            tabla.Columns[1].Name = "Nombre";
            tabla.Columns[2].Name = "Apellido";
            tabla.Columns[3].Name = "Email";
            tabla.Columns[4].Name = "Saldo";

            // Hacer que las columnas sean de tamaño ajustable
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Añadir filas a la tabla con los datos de los clientes
            foreach (var dato in listaClientes)
            {
                tabla.Rows.Add(dato.cliente.DNI, dato.cliente.Nombre, dato.cliente.Apellido, dato.cliente.Email, dato.saldo);
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FListadoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

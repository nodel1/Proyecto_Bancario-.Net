using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD.MDCliente;
using MD.MDCuenta;

namespace Presentacion
{
    public partial class FCuentasCliente : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FCuentasCliente"/>.
        /// </summary>
        public FCuentasCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FCuentasCliente"/> con los datos proporcionados.
        /// Muestra las cuentas asociadas a un cliente en una tabla.
        /// </summary>
        /// <param name="cuentas">La lista de cuentas asociadas al cliente.</param>
        /// <param name="cliente">El cliente cuya información se mostrará junto a las cuentas.</param>
        public FCuentasCliente(List<Cuenta> cuentas, Cliente cliente)
        {
            InitializeComponent();
            labelNombre.Text = "Cuentas de " + cliente.Nombre + " " + cliente.Apellido;

            // Configuración de la tabla
            tabla.ColumnCount = 5; // Número de columnas
            tabla.Columns[0].Name = "IBAN";
            tabla.Columns[1].Name = "Tipo";
            tabla.Columns[2].Name = "Saldo";
            tabla.Columns[3].Name = "Fecha Apertura";
            tabla.Columns[4].Name = "Estado";
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Llenar la tabla con las cuentas
            foreach (Cuenta c in cuentas)
            {
                if (c != null)
                {
                    tabla.Rows.Add(c.IBAN.ToString(), c.Tipo.ToString(), c.Saldo.ToString(), c.FechaApertura, c.Estado.ToString());
                }
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FCuentasCliente_Load(object sender, EventArgs e)
        {
        }
    }
}

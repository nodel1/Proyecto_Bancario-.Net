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
    public partial class FListadoCuentas : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario sin parámetros.
        /// </summary>
        public FListadoCuentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario con una lista de cuentas.
        /// </summary>
        /// <param name="cuentas">Lista de cuentas a mostrar.</param>
        public FListadoCuentas(List<Cuenta> cuentas)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario con el nombre del titular y una lista de cuentas.
        /// </summary>
        /// <param name="titular">Nombre del titular de las cuentas.</param>
        /// <param name="cuentas">Lista de cuentas asociadas al titular.</param>
        public FListadoCuentas(string titular, List<Cuenta> cuentas)
        {
            InitializeComponent();

            // Configura las columnas de la tabla
            tabla.ColumnCount = 5; // Número de columnas
            tabla.Columns[0].Name = "IBAN";
            tabla.Columns[1].Name = "Tipo";
            tabla.Columns[2].Name = "Saldo";
            tabla.Columns[3].Name = "FechaApartura";
            tabla.Columns[4].Name = "Estado";

            // Ajusta el tamaño de las columnas automáticamente
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Añadir las filas con la información de las cuentas
            foreach (var dato in cuentas)
            {
                tabla.Rows.Add(dato.IBAN, dato.Tipo.ToString(), dato.Saldo, dato.FechaApertura, dato.Estado);
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FListadoCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}

using MD.MDMovimientos;
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
    public partial class FListadoMovimientos : Form
    {
        private string titulo;
        private List<Movimiento> movimientos;

        /// <summary>
        /// Inicializa una nueva instancia del formulario sin parámetros.
        /// </summary>
        public FListadoMovimientos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario con un título y una lista de movimientos.
        /// </summary>
        /// <param name="titulo">Título del formulario.</param>
        /// <param name="movimientos">Lista de movimientos a mostrar.</param>
        public FListadoMovimientos(string titulo, List<Movimiento> movimientos)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.movimientos = movimientos;

            // Configura las columnas de cada tabla
            tablarecibos.ColumnCount = 8; // Número de columnas en la tabla de recibos
            tablatransferencias.ColumnCount = 8; // Número de columnas en la tabla de transferencias
            tablaingresos.ColumnCount = 6; // Número de columnas en la tabla de ingresos
            tablareintegro.ColumnCount = 6; // Número de columnas en la tabla de reintegros

            // Configuración de las columnas de la tabla de recibos
            tablarecibos.Columns[0].Name = "Fecha";
            tablarecibos.Columns[1].Name = "Estado";
            tablarecibos.Columns[2].Name = "Importe";
            tablarecibos.Columns[3].Name = "Cuenta";
            tablarecibos.Columns[4].Name = "Empleado";
            tablarecibos.Columns[5].Name = "Cliente";
            tablarecibos.Columns[6].Name = "IBAN Destino";
            tablarecibos.Columns[7].Name = "Referencia";

            // Configuración de las columnas de la tabla de transferencias
            tablatransferencias.Columns[0].Name = "Fecha";
            tablatransferencias.Columns[1].Name = "Estado";
            tablatransferencias.Columns[2].Name = "Importe";
            tablatransferencias.Columns[3].Name = "Cuenta";
            tablatransferencias.Columns[4].Name = "Empleado";
            tablatransferencias.Columns[5].Name = "Cliente";
            tablatransferencias.Columns[6].Name = "IBAN Destino";
            tablatransferencias.Columns[7].Name = "Concepto";

            // Configuración de las columnas de la tabla de ingresos
            tablaingresos.Columns[0].Name = "Fecha";
            tablaingresos.Columns[1].Name = "Estado";
            tablaingresos.Columns[2].Name = "Importe";
            tablaingresos.Columns[3].Name = "Cuenta";
            tablaingresos.Columns[4].Name = "Empleado";
            tablaingresos.Columns[5].Name = "Cliente";

            // Configuración de las columnas de la tabla de reintegros
            tablareintegro.Columns[0].Name = "Fecha";
            tablareintegro.Columns[1].Name = "Estado";
            tablareintegro.Columns[2].Name = "Importe";
            tablareintegro.Columns[3].Name = "Cuenta";
            tablareintegro.Columns[4].Name = "Empleado";
            tablareintegro.Columns[5].Name = "Cliente";

            // Ajusta el tamaño de las columnas para que se adapten al contenido
            tablarecibos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablatransferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablareintegro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaingresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Agrega las filas correspondientes a cada tipo de movimiento
            foreach (var dato in movimientos)
            {
                if (dato is Transferencia transferencia)
                {
                    // Añade una fila a la tabla de transferencias
                    tablatransferencias.Rows.Add(dato.Fecha.ToString(), dato.Estado.ToString(), dato.Importe, dato.Cuenta.IBAN, dato.EmpleadoResponsable, dato.Cliente.DNI, transferencia.IBAN_Destino, transferencia.Concepto);
                }

                if (dato is PagoRecibo pagoRecibo)
                {
                    // Añade una fila a la tabla de recibos
                    tablarecibos.Rows.Add(dato.Fecha.ToString(), dato.Estado.ToString(), dato.Importe, dato.Cuenta.IBAN, dato.EmpleadoResponsable, dato.Cliente.DNI, pagoRecibo.IBAN_Destino, pagoRecibo.Referencia_Recibo);
                }

                if (dato is Reintegro)
                {
                    // Añade una fila a la tabla de reintegros
                    tablareintegro.Rows.Add(dato.Fecha.ToString(), dato.Estado.ToString(), dato.Importe, dato.Cuenta.IBAN, dato.EmpleadoResponsable, dato.Cliente.DNI);
                }

                if (dato is Ingreso)
                {
                    // Añade una fila a la tabla de ingresos
                    tablaingresos.Rows.Add(dato.Fecha.ToString(), dato.Estado.ToString(), dato.Importe, dato.Cuenta.IBAN, dato.EmpleadoResponsable, dato.Cliente.DNI);
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en las celdas de la tabla de ingresos.
        /// </summary>
        private void tablaingresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FListadoMovimientos_Load(object sender, EventArgs e)
        {

        }
    }
}

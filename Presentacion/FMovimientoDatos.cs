using MD.MDCuenta;
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
    public partial class FMovimientoDatos : Form
    {
        /// <summary>
        /// Representa el movimiento que se mostrará en el formulario.
        /// </summary>
        private Movimiento movimiento;

        /// <summary>
        /// Inicializa una nueva instancia del formulario FMovimientoDatos.
        /// </summary>
        public FMovimientoDatos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia del formulario FMovimientoDatos con los datos de un movimiento.
        /// </summary>
        /// <param name="movimientos">El movimiento cuyos detalles se mostrarán en el formulario.</param>
        public FMovimientoDatos(Movimiento movimientos)
        {
            InitializeComponent();

            this.movimiento = movimientos;

            // Asigna los valores del movimiento a los controles del formulario
            TBFECHA.Text = movimientos.Fecha.ToString();
            TBESTADO.Text = movimientos.Estado.ToString();
            TBIMPORTE.Text = movimientos.Importe.ToString();
            TBCUENTA.Text = movimientos.Cuenta.IBAN;
            TBEMPLEADO.Text = movimientos.EmpleadoResponsable;
            TBCliente.Text = movimientos.Cliente.DNI;

            // Si el movimiento es una transferencia
            if (movimientos is Transferencia transferencia)
            {
                TBTipo.Text = "Transferencia";
                TBConcepto.Text = transferencia.Concepto;
                TBIban_destino.Text = transferencia.IBAN_Destino;
            }
            // Si el movimiento es un pago de recibo
            if (movimientos is PagoRecibo recibo)
            {
                TBTipo.Text = "Pago Recibo";
                TBConcepto.Text = recibo.Referencia_Recibo;
                TBIban_destino.Text = recibo.IBAN_Destino;
            }
            // Si el movimiento es un reintegro
            if (movimientos is Reintegro reintegro)
            {
                TBTipo.Text = "Reintegro";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;
            }
            // Si el movimiento es un ingreso
            if (movimientos is Ingreso ingreso)
            {
                TBTipo.Text = "Ingreso";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;
            }
        }

        /// <summary>
        /// Maneja el evento de carga del formulario FMovimientoDatos.
        /// </summary>
        private void FMovimientoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}

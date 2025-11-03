using MD.MDCliente;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentacion
{
    /// <summary>
    /// Formulario para mostrar el recorrido de los movimientos bancarios.
    /// </summary>
    public partial class FRecorridoMovimiento : Form
    {
        private List<Movimiento> movimientos;
        private int numeromovimientos;
        private static int contador = 0;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FRecorridoMovimiento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que inicializa el formulario con la lista de movimientos.
        /// </summary>
        /// <param name="Movimientos">Lista de movimientos a mostrar.</param>
        public FRecorridoMovimiento(List<Movimiento> Movimientos)
        {
            InitializeComponent();
            this.movimientos = Movimientos;
            labelposicion.Text = contador + 1 + " de " + movimientos.Count.ToString();
            if (contador >= 0 && movimientos.Count > 0)
            {
                TBFECHA.Text = movimientos[0].Fecha.ToString();
                TBESTADO.Text = movimientos[0].Estado.ToString();
                TBIMPORTE.Text = movimientos[0].Importe.ToString();
                TBCUENTA.Text = movimientos[0].Cuenta.IBAN;

                TBEMPLEADO.Text = movimientos[0].EmpleadoResponsable;
                TBCliente.Text = movimientos[0].Cliente.DNI;
                if (movimientos[0] is Transferencia transferencia)
                {
                    TBTipo.Text = "Transferencia";
                    TBConcepto.Text = transferencia.Concepto;
                    TBIban_destino.Text = transferencia.IBAN_Destino;
                }
                if (movimientos[0] is PagoRecibo recibo)
                {
                    TBTipo.Text = "Pago Recibo";
                    TBConcepto.Text = recibo.Referencia_Recibo;
                    TBIban_destino.Text = recibo.IBAN_Destino;
                }
                if (movimientos[0] is Reintegro reintegro)
                {
                    TBTipo.Text = "Reintegro";
                    TBConcepto.Visible = false;
                    TBIban_destino.Visible = false;
                    lbconcepto.Visible = false;
                    lbibandestino.Visible = false;

                }
                if (movimientos[0] is Ingreso ingreso)
                {
                    TBTipo.Text = "Ingreso";
                    TBConcepto.Visible = false;
                    TBIban_destino.Visible = false;
                    lbconcepto.Visible = false;
                    lbibandestino.Visible = false;

                }
            }
            EstadoBotones();
        }

        /// <summary>
        /// Muestra el siguiente movimiento en la lista.
        /// </summary>
        private void BTSiguiente_Click_1(object sender, EventArgs e)
        {
            contador++;
            labelposicion.Text = contador + 1 + " de " + movimientos.Count.ToString();

            TBFECHA.Text = movimientos[contador].Fecha.ToString();
            TBESTADO.Text = movimientos[contador].Estado.ToString();
            TBIMPORTE.Text = movimientos[contador].Importe.ToString();
            TBCUENTA.Text = movimientos[contador].Cuenta.IBAN;
            TBEMPLEADO.Text = movimientos[contador].EmpleadoResponsable;
            TBCliente.Text = movimientos[contador].Cliente.DNI;
            if (movimientos[contador] is Transferencia transferencia)
            {
                TBTipo.Text = "Transferencia";
                TBConcepto.Text = transferencia.Concepto;
                TBIban_destino.Text = transferencia.IBAN_Destino;
            }
            if (movimientos[contador] is PagoRecibo recibo)
            {
                TBTipo.Text = "Pago Recibo";
                TBConcepto.Text = recibo.Referencia_Recibo;
                TBIban_destino.Text = recibo.IBAN_Destino;
            }
            if (movimientos[contador] is Reintegro reintegro)
            {
                TBTipo.Text = "Reintegro";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }
            if (movimientos[contador] is Ingreso ingreso)
            {
                TBTipo.Text = "Ingreso";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }
            EstadoBotones();
        }

        /// <summary>
        /// Muestra el movimiento anterior en la lista.
        /// </summary>
        private void BTAnterior_Click(object sender, EventArgs e)
        {
            contador--;
            labelposicion.Text = contador + 1 + " de " + movimientos.Count.ToString();

            TBFECHA.Text = movimientos[contador].Fecha.ToString();
            TBESTADO.Text = movimientos[contador].Estado.ToString();
            TBIMPORTE.Text = movimientos[contador].Importe.ToString();
            TBCUENTA.Text = movimientos[contador].Cuenta.IBAN;
            TBEMPLEADO.Text = movimientos[contador].EmpleadoResponsable;
            TBCliente.Text = movimientos[contador].Cliente.DNI;
            if (movimientos[contador] is Transferencia transferencia)
            {
                TBTipo.Text = "Transferencia";
                TBConcepto.Text = transferencia.Concepto;
                TBIban_destino.Text = transferencia.IBAN_Destino;
            }
            if (movimientos[contador] is PagoRecibo recibo)
            {
                TBTipo.Text = "Pago Recibo";
                TBConcepto.Text = recibo.Referencia_Recibo;
                TBIban_destino.Text = recibo.IBAN_Destino;
            }
            if (movimientos[contador] is Reintegro reintegro)
            {
                TBTipo.Text = "Reintegro";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }
            if (movimientos[contador] is Ingreso ingreso)
            {
                TBTipo.Text = "Ingreso";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }
            EstadoBotones();
        }

        /// <summary>
        /// Muestra el último movimiento en la lista.
        /// </summary>
        private void BTUltimo_Click(object sender, EventArgs e)
        {
            contador = movimientos.Count - 1;
            labelposicion.Text = contador + 1 + " de " + movimientos.Count.ToString();

            TBFECHA.Text = movimientos[contador].Fecha.ToString();
            TBESTADO.Text = movimientos[contador].Estado.ToString();
            TBIMPORTE.Text = movimientos[contador].Importe.ToString();
            TBCUENTA.Text = movimientos[contador].Cuenta.IBAN;
            TBEMPLEADO.Text = movimientos[contador].EmpleadoResponsable;
            TBCliente.Text = movimientos[contador].Cliente.DNI;
            if (movimientos[contador] is Transferencia transferencia)
            {
                TBTipo.Text = "Transferencia";
                TBConcepto.Text = transferencia.Concepto;
                TBIban_destino.Text = transferencia.IBAN_Destino;
            }
            if (movimientos[contador] is PagoRecibo recibo)
            {
                TBTipo.Text = "Pago Recibo";
                TBConcepto.Text = recibo.Referencia_Recibo;
                TBIban_destino.Text = recibo.IBAN_Destino;
            }
            if (movimientos[contador] is Reintegro reintegro)
            {
                TBTipo.Text = "Reintegro";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }
            if (movimientos[contador] is Ingreso ingreso)
            {
                TBTipo.Text = "Ingreso";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }

            EstadoBotones();
        }

        /// <summary>
        /// Muestra el primer movimiento en la lista.
        /// </summary>
        private void BTPrimero_Click_1(object sender, EventArgs e)
        {
            contador = 0;
            labelposicion.Text = contador + 1 + " de " + movimientos.Count.ToString();

            TBFECHA.Text = movimientos[contador].Fecha.ToString();
            TBESTADO.Text = movimientos[contador].Estado.ToString();
            TBIMPORTE.Text = movimientos[contador].Importe.ToString();
            TBCUENTA.Text = movimientos[contador].Cuenta.IBAN;
            TBEMPLEADO.Text = movimientos[contador].EmpleadoResponsable;
            TBCliente.Text = movimientos[contador].Cliente.DNI;
            if (movimientos[contador] is Transferencia transferencia)
            {
                TBTipo.Text = "Transferencia";
                TBConcepto.Text = transferencia.Concepto;
                TBIban_destino.Text = transferencia.IBAN_Destino;
            }
            if (movimientos[contador] is PagoRecibo recibo)
            {
                TBTipo.Text = "Pago Recibo";
                TBConcepto.Text = recibo.Referencia_Recibo;
                TBIban_destino.Text = recibo.IBAN_Destino;
            }
            if (movimientos[contador] is Reintegro reintegro)
            {
                TBTipo.Text = "Reintegro";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }
            if (movimientos[contador] is Ingreso ingreso)
            {
                TBTipo.Text = "Ingreso";
                TBConcepto.Visible = false;
                TBIban_destino.Visible = false;
                lbconcepto.Visible = false;
                lbibandestino.Visible = false;

            }

            EstadoBotones();
        }

        /// <summary>
        /// Habilita o deshabilita los botones de navegación en función de la posición actual.
        /// </summary>
        private void EstadoBotones()
        {
            BTAnterior.Enabled = contador > 0;
            BTPrimero.Enabled = contador > 0;
            BTSiguiente.Enabled = contador < movimientos.Count - 1;
            BTUltimo.Enabled = contador < movimientos.Count - 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRecorridoMovimiento_Load(object sender, EventArgs e)
        {

        }
    }
}

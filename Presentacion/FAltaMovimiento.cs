using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN;
using LNCliente;
using LNCuenta;
using MD;
using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FAltaMovimiento : Form
    {
        private LN.LN ln;
        private List<String> dnis;

        /// <summary>
        /// Constructor por defecto para inicializar el formulario.
        /// </summary>
        public FAltaMovimiento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que inicializa el formulario con los parámetros proporcionados.
        /// </summary>
        /// <param name="LN">El objeto LN que contiene la lógica de negocio</param>
        /// <param name="DNIs">Lista de DNIs de los clientes</param>
        public FAltaMovimiento(LN.LN LN, List<String> DNIs)
        {
            InitializeComponent();
            this.ln = LN;
            this.dnis = DNIs;
            LlenarComboBox(DNIs);
        }

        /// <summary>
        /// Maneja el cambio de selección en el combo de DNI y carga las cuentas asociadas al DNI seleccionado.
        /// </summary>
        private void ComboDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDNI.SelectedIndex != -1)
            {
                string dnielegido = ComboDNI.SelectedItem.ToString();
                List<Cuenta> cuentas = ln.LNCliente.CuentasCliente(ln.LNCliente.LeerClientePorDNI(dnielegido));
                List<String> ibanes = new List<String>();
                foreach (Cuenta cuenta in cuentas)
                {
                    ibanes.Add(cuenta.IBAN);
                }
                LLenarBomboCuentas(ibanes);
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga el formulario.
        /// </summary>
        private void AltaMovimiento_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Llena el combo de IBAN con las cuentas proporcionadas.
        /// </summary>
        /// <param name="cuentas">Lista de cuentas que contienen los IBANs</param>
        private void LLenarBomboCuentas(List<string> cuentas)
        {
            ComboIBAN.Items.Clear();
            foreach (string c in cuentas)
            {
                ComboIBAN.Items.Add(c);
            }
        }

        /// <summary>
        /// Llena el combo de DNI con los DNIs proporcionados.
        /// </summary>
        /// <param name="dnis">Lista de DNIs de los clientes</param>
        private void LlenarComboBox(List<string> dnis)
        {
            foreach (string dni in dnis)
            {
                ComboDNI.Items.Add(dni);
            }
        }

        /// <summary>
        /// Maneja el cambio de selección en el combo de tipo de movimiento.
        /// </summary>
        private void ComboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTipo.SelectedIndex != -1)
            {
                groupBox1.Visible = true;
                BTAceptar.Visible = true;
                BTcancelar.Visible = true;
                LBaviso.Visible = true;
            }
        }

        /// <summary>
        /// Maneja el clic del botón Aceptar para realizar el movimiento seleccionado.
        /// </summary>
        private void BTAceptar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TBimporte.Text, out decimal importe))
            {
                if (importe > 1000 && this.ln is LN.LNVentanilla)
                {
                    MessageBox.Show("No está autorizado a realizar este movimiento");
                    ComboTipo_SelectedIndexChanged(sender, e);
                }
                else
                {
                    if (ComboDNI.SelectedIndex == -1 || ComboIBAN.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un cliente y un IBAN");
                        return;
                    }

                    Cuenta cuenta = ln.LNCuenta.LeerCuentaPorIBAN(ComboIBAN.SelectedItem.ToString());
                    Cliente cliente = ln.LNCliente.LeerClientePorDNI(ComboDNI.SelectedItem.ToString());
                    string tipoelegido = ComboTipo.SelectedIndex.ToString();
                    switch (ComboTipo.SelectedItem.ToString())
                    {
                        case "Ingreso":
                            Ingreso ingreso = new Ingreso(DateTime.Now, EstadoMovimiento.Ejecutado, importe, cuenta, ln.Empleado.Id_Emp, cliente);
                            ln.LNMovimiento.RealizarMovimiento(ingreso);
                            MessageBox.Show("Se ha realizado el movimiento correctamente");
                            this.Close();
                            break;
                        case "Transferencia":
                            if (TBconcepto.Text.Length > 0 && TBIBANdestino.Text.Length > 0)
                            {
                                Transferencia transferencia = new Transferencia(DateTime.Now, EstadoMovimiento.Ejecutado, importe, cuenta, ln.Empleado.Id_Emp, TBconcepto.Text, TBIBANdestino.Text, cliente);
                                ln.LNMovimiento.RealizarMovimiento(transferencia);
                                MessageBox.Show("Se ha realizado el movimiento correctamente");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Debe añadirse un concepto y un IBAN de destino");
                            }
                            break;
                        case "PagoRecibo":
                            if (TBconcepto.Text.Length > 0 && TBIBANdestino.Text.Length > 0)
                            {
                                PagoRecibo pagoRecibo = new PagoRecibo(DateTime.Now, EstadoMovimiento.Ejecutado, importe, cuenta, ln.Empleado.Id_Emp, TBconcepto.Text, TBIBANdestino.Text, cliente);
                                ln.LNMovimiento.RealizarMovimiento(pagoRecibo);
                                MessageBox.Show("Se ha realizado el movimiento correctamente");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Debe añadirse un concepto y un IBAN de destino");
                            }
                            break;
                        case "Reintegro":
                            Reintegro reintegro = new Reintegro(DateTime.Now, EstadoMovimiento.Ejecutado, importe, cuenta, ln.Empleado.Id_Emp, cliente);
                            ln.LNMovimiento.RealizarMovimiento(reintegro);
                            MessageBox.Show("Se ha realizado el movimiento correctamente");
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Algo ha ido mal");
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("EL importe no es valido");
            }
        }

        /// <summary>
        /// Maneja el clic del botón Cancelar para cerrar el formulario sin hacer cambios.
        /// </summary>
        private void BTcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga el formulario.
        /// </summary>
        private void FAltaMovimiento_Load(object sender, EventArgs e)
        {

        }
    }
}

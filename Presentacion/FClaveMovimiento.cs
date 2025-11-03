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
    public partial class FClaveMovimiento : Form
    {
        private Cuenta cuenta;
        private Movimiento movimiento;

        /// <summary>
        /// Obtiene el IBAN de la cuenta.
        /// </summary>
        public string IBAN { get; private set; }

        /// <summary>
        /// Obtiene la fecha y hora del movimiento.
        /// </summary>
        public DateTime FechaHora { get; private set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FClaveMovimiento"/>.
        /// </summary>
        public FClaveMovimiento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FClaveMovimiento"/> con una cuenta y un movimiento específicos.
        /// </summary>
        /// <param name="cuenta">La cuenta asociada al movimiento.</param>
        /// <param name="movimiento">El movimiento asociado a la cuenta.</param>
        public FClaveMovimiento(Cuenta cuenta, Movimiento movimiento)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.movimiento = movimiento;
        }

        /// <summary>
        /// Maneja el evento de carga del formulario.
        /// </summary>
        private void FClaveMovimiento_Load(object sender, EventArgs e)
        {
        }
    }
}

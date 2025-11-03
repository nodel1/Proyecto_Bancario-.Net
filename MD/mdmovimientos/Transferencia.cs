using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDMovimientos
{
    /// <summary>
    /// Representa una transferencia entre cuentas en el sistema.
    /// </summary>
    public class Transferencia : Movimiento
    {
        private string concepto;
        private string IBAN_destino;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Transferencia con los parámetros especificados.
        /// </summary>
        /// <param name="fecha">La fecha en la que se realizó la transferencia.</param>
        /// <param name="estado">El estado del movimiento de transferencia.</param>
        /// <param name="importe">El importe de la transferencia.</param>
        /// <param name="cuenta">La cuenta asociada al movimiento de transferencia.</param>
        /// <param name="empleadoResponsable">El nombre del empleado responsable de la transferencia.</param>
        /// <param name="concepto">El concepto o descripción de la transferencia.</param>
        /// <param name="ibanDestino">El IBAN de la cuenta destino de la transferencia.</param>
        /// <param name="cliente">El cliente asociado al movimiento de transferencia.</param>
        public Transferencia(DateTime fecha, EstadoMovimiento estado, decimal importe, Cuenta cuenta, string empleadoResponsable, string concepto, string ibanDestino, Cliente cliente)
            : base(fecha, estado, importe, cuenta, empleadoResponsable, cliente)
        {
            this.concepto = concepto;
            this.IBAN_Destino = ibanDestino;
        }

        /// <summary>
        /// Obtiene o establece el concepto de la transferencia.
        /// </summary>
        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        /// <summary>
        /// Obtiene o establece el IBAN de la cuenta destino de la transferencia.
        /// </summary>
        public string IBAN_Destino
        {
            get { return IBAN_destino; }
            set { IBAN_destino = value; }
        }
    }
}

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
    /// Representa un movimiento de pago de un recibo en una cuenta.
    /// </summary>
    public class PagoRecibo : Movimiento
    {
        // Los atributos de concepto y el IBAN
        private string IBAN_destino;
        private string referencia_recibo;

        /// <summary>
        /// Inicializa una nueva instancia de la clase PagoRecibo con los parámetros especificados.
        /// </summary>
        /// <param name="fecha">La fecha en la que se realizó el movimiento.</param>
        /// <param name="estado">El estado del movimiento.</param>
        /// <param name="importe">El importe del movimiento.</param>
        /// <param name="cuenta">La cuenta asociada al movimiento.</param>
        /// <param name="empleadoResponsable">El nombre del empleado responsable del movimiento.</param>
        /// <param name="ibanDestino">El IBAN de destino para el pago.</param>
        /// <param name="referencia">La referencia del recibo.</param>
        /// <param name="cliente">El cliente asociado al movimiento.</param>
        public PagoRecibo(DateTime fecha, EstadoMovimiento estado, decimal importe, Cuenta cuenta, string empleadoResponsable, string ibanDestino, string referencia, Cliente cliente)
            : base(fecha, estado, importe, cuenta, empleadoResponsable, cliente)
        {
            this.IBAN_destino = ibanDestino;
            this.referencia_recibo = referencia;
        }

        /// <summary>
        /// Obtiene o establece el IBAN de destino para el pago del recibo.
        /// </summary>
        public string IBAN_Destino
        {
            get { return IBAN_destino; }
            set { IBAN_destino = value; }
        }

        /// <summary>
        /// Obtiene o establece la referencia del recibo.
        /// </summary>
        public string Referencia_Recibo
        {
            get { return referencia_recibo; }
            set { referencia_recibo = value; }
        }
    }
}

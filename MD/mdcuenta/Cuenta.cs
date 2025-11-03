using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDCuenta
{
    /// <summary>
    /// Representa una cuenta bancaria con propiedades como IBAN, tipo de cuenta, saldo, fecha de apertura y estado de la cuenta.
    /// </summary>
    public class Cuenta
    {
        private string iban;
        private TipoCuenta tipo;
        private decimal saldo;
        private DateTime fechaApertura;
        private EstadoCuenta estado;

        /// <summary>
        /// Constructor para crear una cuenta bancaria con IBAN, tipo, saldo, fecha de apertura y estado.
        /// </summary>
        /// <param name="iban">El IBAN de la cuenta</param>
        /// <param name="tipo">El tipo de cuenta (por ejemplo, corriente o de ahorro)</param>
        /// <param name="saldo">El saldo inicial de la cuenta</param>
        /// <param name="fechaApertura">La fecha de apertura de la cuenta</param>
        /// <param name="estado">El estado actual de la cuenta (por ejemplo, activa o bloqueada)</param>
        public Cuenta(string iban, TipoCuenta tipo, decimal saldo, DateTime fechaApertura, EstadoCuenta estado)
        {
            IBAN = iban;
            Tipo = tipo;
            Saldo = saldo;
            FechaApertura = fechaApertura;
            Estado = estado;
        }

        /// <summary>
        /// Obtiene o establece el IBAN de la cuenta.
        /// </summary>
        public string IBAN
        {
            get { return iban; }
            set { iban = value; }
        }

        /// <summary>
        /// Obtiene o establece el tipo de cuenta.
        /// </summary>
        public TipoCuenta Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtiene o establece el saldo de la cuenta.
        /// </summary>
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        /// <summary>
        /// Obtiene o establece la fecha de apertura de la cuenta.
        /// </summary>
        public DateTime FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value; }
        }

        /// <summary>
        /// Obtiene o establece el estado de la cuenta.
        /// </summary>
        public EstadoCuenta Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

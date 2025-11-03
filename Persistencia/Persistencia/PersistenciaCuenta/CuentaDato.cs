using Persistencia.BDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.PersistenciaCuenta
{
    /// <summary>
    /// Representa los datos de una cuenta en el sistema de persistencia.
    /// </summary>
    public class CuentaDato : Entity<String>
    {
        /// <summary>
        /// Tipo de cuenta (por ejemplo, corriente, ahorro, etc.).
        /// </summary>
        private string tipo;

        /// <summary>
        /// El saldo actual de la cuenta.
        /// </summary>
        private decimal saldo;

        /// <summary>
        /// La fecha de apertura de la cuenta.
        /// </summary>
        private DateTime fechaApertura;

        /// <summary>
        /// El estado de la cuenta (por ejemplo, activa, suspendida).
        /// </summary>
        private string estado;

        /// <summary>
        /// Crea una instancia de la clase CuentaDato.
        /// </summary>
        /// <param name="iban">El IBAN de la cuenta.</param>
        /// <param name="tipo">El tipo de cuenta.</param>
        /// <param name="saldo">El saldo de la cuenta.</param>
        /// <param name="fechaapertura">La fecha de apertura de la cuenta.</param>
        /// <param name="estado">El estado de la cuenta.</param>
        public CuentaDato(string iban, string tipo, decimal saldo, DateTime fechaapertura, string estado) : base(iban)
        {
            this.Tipo = tipo;
            this.Saldo = saldo;
            this.FechaApertura = fechaapertura;
            this.Estado = estado;
        }

        /// <summary>
        /// Obtiene o establece el tipo de cuenta.
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Obtiene o establece el saldo de la cuenta.
        /// </summary>
        public decimal Saldo { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de apertura de la cuenta.
        /// </summary>
        public DateTime FechaApertura { get; set; }

        /// <summary>
        /// Obtiene o establece el estado de la cuenta.
        /// </summary>
        public string Estado { get; set; }
    }
}

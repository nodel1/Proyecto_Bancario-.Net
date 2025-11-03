using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.PersistenciaCuenta
{
    /// <summary>
    /// Clase encargada de transformar objetos entre las representaciones de las cuentas
    /// en la base de datos y los objetos de la aplicación.
    /// </summary>
    internal class TransformerCuenta
    {
        /// <summary>
        /// Convierte un objeto de tipo <see cref="Cuenta"/> a un objeto <see cref="CuentaDato"/>
        /// para su almacenamiento en la base de datos.
        /// </summary>
        /// <param name="cuenta">El objeto <see cref="Cuenta"/> que se va a convertir.</param>
        /// <returns>Un objeto <see cref="CuentaDato"/> que representa la cuenta en la base de datos.</returns>
        public static CuentaDato CuentaACuentaDato(Cuenta cuenta)
        {
            return new CuentaDato(cuenta.IBAN, cuenta.Tipo.ToString(), cuenta.Saldo, cuenta.FechaApertura, cuenta.Estado.ToString());
        }

        /// <summary>
        /// Convierte un objeto <see cref="CuentaDato"/> de la base de datos a un objeto
        /// <see cref="Cuenta"/> de la aplicación.
        /// </summary>
        /// <param name="cuentaDato">El objeto <see cref="CuentaDato"/> que se va a convertir.</param>
        /// <returns>Un objeto <see cref="Cuenta"/> que representa la cuenta en la aplicación.</returns>
        public static Cuenta CuentaDatoACuenta(CuentaDato cuentaDato)
        {
            DateTime fechaApertura = cuentaDato.FechaApertura;
            EstadoCuenta estado = EstadoCuenta.Cerrada;
            TipoCuenta tipoCuenta = TipoCuenta.Ahorro;

            // Convertir el estado de la cuenta
            switch (cuentaDato.Estado)
            {
                case "Abierta":
                    estado = EstadoCuenta.Abierta;
                    break;
                case "Cerrada":
                    estado = EstadoCuenta.Cerrada;
                    break;
            }

            // Convertir el tipo de cuenta
            switch (cuentaDato.Tipo)
            {
                case "Joven":
                    tipoCuenta = TipoCuenta.Joven;
                    break;
                case "Ahorro":
                    tipoCuenta = TipoCuenta.Ahorro;
                    break;
                case "bonificada":
                    tipoCuenta = TipoCuenta.Bonificada;
                    break;
                case "Oro":
                    tipoCuenta = TipoCuenta.Oro;
                    break;
            }

            return new Cuenta(cuentaDato.Id, tipoCuenta, cuentaDato.Saldo, fechaApertura, estado);
        }
    }
}

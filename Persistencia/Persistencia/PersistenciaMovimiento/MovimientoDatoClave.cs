using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BDs.PersistenciaMovimiento
{
    /// <summary>
    /// Representa la clave única para identificar un movimiento en la base de datos,
    /// formada por la fecha y la cuenta asociada al movimiento.
    /// </summary>
    internal class MovimientoDatoClave
    {
        private DateTime fecha;
        private string cuenta;

        /// <summary>
        /// Inicializa una nueva instancia de la clase MovimientoDatoClave con la fecha y cuenta.
        /// </summary>
        /// <param name="Fecha">La fecha del movimiento.</param>
        /// <param name="Cuenta">La cuenta asociada al movimiento.</param>
        public MovimientoDatoClave(DateTime Fecha, string Cuenta)
        {
            this.fecha = Fecha;
            this.cuenta = Cuenta;
        }

        /// <summary>
        /// Obtiene la fecha del movimiento.
        /// </summary>
        public DateTime Fecha { get { return fecha; } }

        /// <summary>
        /// Obtiene la cuenta asociada al movimiento.
        /// </summary>
        public string Cuenta { get { return cuenta; } }
    }
}

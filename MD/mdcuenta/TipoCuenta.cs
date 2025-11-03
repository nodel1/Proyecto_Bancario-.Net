using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDCuenta
{
    /// <summary>
    /// Representa los tipos posibles de cuentas bancarias.
    /// </summary>
    public enum TipoCuenta
    {
        /// <summary>
        /// Cuenta para jóvenes, generalmente con condiciones especiales.
        /// </summary>
        Joven,

        /// <summary>
        /// Cuenta de ahorro, destinada a ahorrar dinero con una rentabilidad.
        /// </summary>
        Ahorro,

        /// <summary>
        /// Cuenta bonificada con condiciones preferenciales o ventajas adicionales.
        /// </summary>
        Bonificada,

        /// <summary>
        /// Cuenta de tipo oro, generalmente para clientes premium con mayores beneficios.
        /// </summary>
        Oro
    }
}

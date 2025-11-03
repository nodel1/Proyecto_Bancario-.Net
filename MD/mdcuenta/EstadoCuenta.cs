using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDCuenta
{
    /// <summary>
    /// Representa el estado de una cuenta bancaria.
    /// </summary>
    public enum EstadoCuenta
    {
        /// <summary>
        /// El estado de la cuenta es abierto, es decir, la cuenta está activa.
        /// </summary>
        Abierta,

        /// <summary>
        /// El estado de la cuenta es cerrado, es decir, la cuenta está inactiva o cerrada.
        /// </summary>
        Cerrada
    }
}

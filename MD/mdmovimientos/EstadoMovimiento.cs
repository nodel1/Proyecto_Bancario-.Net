using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDMovimientos
{
    /// <summary>
    /// Representa los posibles estados de un movimiento bancario.
    /// </summary>
    public enum EstadoMovimiento
    {
        /// <summary>
        /// El movimiento se ha ejecutado correctamente.
        /// </summary>
        Ejecutado,

        /// <summary>
        /// El movimiento está pendiente de ejecución.
        /// </summary>
        Pendiente,

        /// <summary>
        /// El movimiento ha sido cancelado.
        /// </summary>
        Cancelado,

        /// <summary>
        /// El movimiento ha fallado durante su ejecución.
        /// </summary>
        Fallido
    }
}

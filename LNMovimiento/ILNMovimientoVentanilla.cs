using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNMovimiento
{
    /// <summary>
    /// Interfaz que extiende la interfaz ILNMovimiento para operaciones relacionadas con movimientos en ventanilla.
    /// </summary>
    internal interface ILNMovimientoVentanilla : ILNMovimiento
    {
        // No se especifican métodos adicionales aquí, ya que esta interfaz hereda todos los métodos de ILNMovimiento.
    }
}

using MD.MDCuenta;
using Persistencia.BDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistencia.PersistenciaMovimiento
{
    /// <summary>
    /// Representa un dato de propietario asociado a una cuenta y un cliente.
    /// Hereda de <see cref="Entity{T}"/> usando <see cref="PropietarioClave"/> como clave compuesta.
    /// </summary>
    internal class PropietarioDato : Entity<PropietarioClave>
    {
        /// <summary>
        /// Constructor que inicializa un nuevo objeto <see cref="PropietarioDato"/> con una cuenta y un cliente.
        /// </summary>
        /// <param name="cuenta">La cuenta asociada al propietario.</param>
        /// <param name="cliente">El cliente asociado al propietario.</param>
        public PropietarioDato(string cuenta, string cliente) : base(new PropietarioClave(cuenta, cliente))
        { }

        /// <summary>
        /// Devuelve una representación en cadena del objeto <see cref="PropietarioDato"/>.
        /// </summary>
        /// <returns>Una cadena que representa el objeto <see cref="PropietarioDato"/>.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

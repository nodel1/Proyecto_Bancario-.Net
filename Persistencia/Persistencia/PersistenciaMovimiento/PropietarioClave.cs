using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Persistencia.PersistenciaMovimiento
{
    /// <summary>
    /// Representa una clave compuesta por la cuenta y el cliente.
    /// Implementa las interfaces <see cref="IEquatable{T}"/> y <see cref="IEqualityComparer{T}"/> 
    /// para permitir comparaciones y la obtención de códigos hash.
    /// </summary>
    public class PropietarioClave : IEquatable<PropietarioClave>, IEqualityComparer<PropietarioClave>
    {
        protected string cuenta;
        protected string cliente;

        /// <summary>
        /// Constructor que inicializa la cuenta y el cliente.
        /// </summary>
        /// <param name="Cuenta">La cuenta asociada al propietario.</param>
        /// <param name="Cliente">El cliente asociado al propietario.</param>
        public PropietarioClave(string Cuenta, string Cliente)
        {
            this.cuenta = Cuenta;
            this.cliente = Cliente;
        }

        /// <summary>
        /// Obtiene la cuenta asociada al propietario.
        /// </summary>
        public string Cuenta
        {
            get { return this.cuenta; }
        }

        /// <summary>
        /// Obtiene o establece el cliente asociado al propietario.
        /// </summary>
        public string Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        /// <summary>
        /// Compara el objeto actual con otro de la misma clase para verificar si son iguales.
        /// </summary>
        /// <param name="other">El otro objeto a comparar.</param>
        /// <returns>True si ambos objetos son iguales, de lo contrario, false.</returns>
        public bool Equals(PropietarioClave other)
        {
            return (this.cliente == other.Cliente) && (this.cuenta == other.Cuenta);
        }

        /// <summary>
        /// Compara dos objetos <see cref="PropietarioClave"/> para verificar si son iguales.
        /// </summary>
        /// <param name="x">El primer objeto a comparar.</param>
        /// <param name="y">El segundo objeto a comparar.</param>
        /// <returns>True si ambos objetos son iguales, de lo contrario, false.</returns>
        public bool Equals(PropietarioClave x, PropietarioClave y)
        {
            return x.Equals(y);
        }

        /// <summary>
        /// Obtiene el código hash de un objeto <see cref="PropietarioClave"/>.
        /// </summary>
        /// <param name="obj">El objeto para el cual obtener el código hash.</param>
        /// <returns>El código hash del objeto.</returns>
        public int GetHashCode(PropietarioClave obj)
        {
            return base.GetHashCode();
        }
    }
}

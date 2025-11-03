using Persistencia.BDs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    /// <summary>
    /// Representa una tabla genérica que almacena elementos de tipo <see cref="U"/> indexados por una clave de tipo <see cref="T"/>.
    /// La clave es proporcionada por la propiedad <see cref="Entity{T}.Id"/> de los elementos.
    /// </summary>
    /// <typeparam name="T">El tipo de clave de los elementos.</typeparam>
    /// <typeparam name="U">El tipo de los elementos que deben ser entidades con clave de tipo <see cref="T"/>.</typeparam>
    internal class Tabla<T, U> : KeyedCollection<T, U> where U : Entity<T>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Tabla"/>.
        /// </summary>
        public Tabla() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Tabla"/> con un comparador de claves personalizado.
        /// </summary>
        /// <param name="ieq">El comparador de igualdad para las claves de tipo <see cref="T"/>.</param>
        public Tabla(IEqualityComparer<T> ieq) : base(ieq) { }

        /// <summary>
        /// Obtiene la clave para el elemento dado.
        /// </summary>
        /// <param name="item">El elemento cuya clave se obtiene.</param>
        /// <returns>La clave del elemento proporcionado.</returns>
        protected override T GetKeyForItem(U item)
        {
            return item.Id;
        }

        /// <summary>
        /// Obtiene o establece el elemento en la tabla usando el elemento proporcionado.
        /// </summary>
        /// <param name="item">El elemento cuyo índice se usa para acceder a la tabla.</param>
        /// <returns>El elemento correspondiente a la clave del item.</returns>
        protected U this[U item]
        {
            get
            {
                return this[item.Id];
            }
        }
    }
}

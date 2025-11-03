using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BDs
{
    /// <summary>
    /// Clase base para representar una entidad genérica con un identificador de tipo <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Tipo del identificador de la entidad.</typeparam>
    public abstract class Entity<T>
    {
        private T id;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Entity{T}"/> con el identificador especificado.
        /// </summary>
        /// <param name="id">El identificador de la entidad.</param>
        public Entity(T id)
        {
            this.id = id;
        }

        /// <summary>
        /// Obtiene el identificador de la entidad.
        /// </summary>
        public T Id
        {
            get { return this.id; }
        }
    }
}

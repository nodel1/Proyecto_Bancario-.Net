using Persistencia.BDs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    /// <summary>
    /// Representa un cliente con sus datos básicos, incluyendo nombre, apellido y correo electrónico.
    /// Hereda de la clase base <see cref="Entity{T}"/> para la identificación del cliente mediante un DNI.
    /// </summary>
    public class ClienteDato : Entity<string>
    {
        private string nombre;
        private string apellido;
        private string email;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ClienteDato"/> con los datos proporcionados.
        /// </summary>
        /// <param name="dni">El DNI del cliente.</param>
        /// <param name="nombre">El nombre del cliente.</param>
        /// <param name="apellido">El apellido del cliente.</param>
        /// <param name="email">El correo electrónico del cliente.</param>
        public ClienteDato(string dni, string nombre, string apellido, string email) : base(dni)
        {
            this.apellido = apellido;
            this.email = email;
            this.nombre = nombre;
        }

        /// <summary>
        /// Obtiene o establece el nombre del cliente.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece el apellido del cliente.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { Apellido = value; }
        }

        /// <summary>
        /// Obtiene o establece el correo electrónico del cliente.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { Email = value; }
        }
    }
}

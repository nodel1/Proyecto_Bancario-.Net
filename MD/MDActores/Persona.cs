using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDActores
{
    /// <summary>
    /// Representa a una persona con nombre y apellido.
    /// </summary>
    public class Persona
    {
        private string nombre;
        private string apellido;

        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece el apellido de la persona.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        /// <summary>
        /// Constructor para crear una persona con nombre y apellido.
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Devuelve una representación en cadena de la persona, incluyendo su nombre y apellido.
        /// </summary>
        /// <returns>Una cadena con el nombre y apellido de la persona</returns>
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}

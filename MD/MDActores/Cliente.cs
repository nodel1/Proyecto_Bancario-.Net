using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDCliente
{
    /// <summary>
    /// Representa a un cliente, que es una persona con un DNI y un correo electrónico.
    /// </summary>
    public class Cliente : Persona
    {
        private string dni;
        private string email;

        /// <summary>
        /// Constructor para crear un cliente con nombre, apellido, DNI y email.
        /// </summary>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="apellido">Apellido del cliente</param>
        /// <param name="dni">DNI del cliente</param>
        /// <param name="email">Correo electrónico del cliente</param>
        public Cliente(string nombre, string apellido, string dni, string email) : base(nombre, apellido)
        {
            this.dni = dni;
            this.email = email;
        }

        /// <summary>
        /// Obtiene o establece el DNI del cliente.
        /// </summary>
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        /// <summary>
        /// Obtiene o establece el correo electrónico del cliente.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Devuelve una representación en cadena del cliente, incluyendo su nombre, apellido, DNI y correo electrónico.
        /// </summary>
        /// <returns>Una cadena con el nombre, apellido, DNI y email del cliente</returns>
        public override string ToString()
        {
            return $"{Nombre} {Apellido}, DNI: {DNI}, Email: {Email}";
        }
    }
}

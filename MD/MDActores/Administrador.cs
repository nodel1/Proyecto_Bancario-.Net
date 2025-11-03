using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDActores
{
    /// <summary>
    /// Representa un administrador, que es un tipo de empleado con un ID específico de administrador.
    /// </summary>
    public class Administrador : Empleado
    {
        private string id_Admin;

        /// <summary>
        /// Constructor para crear un administrador con nombre, apellido e ID de administrador.
        /// </summary>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="id_admin">ID único del administrador</param>
        public Administrador(string nombre, string apellido, string id_admin) : base(nombre, apellido, id_admin)
        {
            this.id_Admin = id_admin;
        }

        /// <summary>
        /// Obtiene el ID del administrador.
        /// </summary>
        public string Id_Admin
        {
            get { return id_Admin; }
        }

        /// <summary>
        /// Devuelve una representación en cadena del administrador, incluyendo su nombre, apellido y ID de administrador.
        /// </summary>
        /// <returns>Una cadena con el nombre, apellido e ID de administrador</returns>
        public override string ToString()
        {
            return $"{Nombre} {Apellido}, ID de Administrador: {Id_Admin}";
        }
    }
}

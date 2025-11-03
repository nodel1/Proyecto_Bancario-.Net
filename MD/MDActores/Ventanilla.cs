using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDActores
{
    /// <summary>
    /// Representa a un empleado de ventanilla, que hereda de la clase Empleado.
    /// </summary>
    public class Ventanilla : Empleado
    {
        private string id_Ventanilla;

        /// <summary>
        /// Constructor para crear una ventanilla con un nombre, apellido y ID de ventanilla.
        /// </summary>
        /// <param name="nombre">Nombre del empleado de ventanilla</param>
        /// <param name="apellido">Apellido del empleado de ventanilla</param>
        /// <param name="id_ventanilla">ID del empleado de ventanilla</param>
        public Ventanilla(string nombre, string apellido, string id_ventanilla) : base(nombre, apellido, id_ventanilla)
        {
            this.id_Ventanilla = id_ventanilla;
        }

        /// <summary>
        /// Obtiene el ID de la ventanilla.
        /// </summary>
        public string Id_Ventanilla
        {
            get { return id_Ventanilla; }
        }

        /// <summary>
        /// Devuelve una representación en cadena del empleado de ventanilla, incluyendo su nombre, apellido e ID de ventanilla.
        /// </summary>
        /// <returns>Una cadena con el nombre, apellido e ID de ventanilla del empleado</returns>
        public override string ToString()
        {
            return $"{Nombre} {Apellido}, ID de Ventanilla: {Id_Ventanilla}";
        }
    }
}

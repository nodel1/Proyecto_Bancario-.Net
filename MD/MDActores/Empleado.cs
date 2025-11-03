using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDActores
{
    /// <summary>
    /// Representa a un empleado, que es una persona con un ID único de empleado.
    /// </summary>
    public class Empleado : Persona
    {
        private string id_Emp;

        /// <summary>
        /// Constructor para crear un empleado con nombre, apellido y ID de empleado.
        /// </summary>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del empleado</param>
        /// <param name="id_emp">ID único del empleado</param>
        public Empleado(String nombre, String apellido, string id_emp) : base(nombre, apellido)
        {
            this.id_Emp = id_emp;
        }

        /// <summary>
        /// Obtiene el ID único del empleado.
        /// </summary>
        public string Id_Emp
        {
            get { return id_Emp; }
        }

        /// <summary>
        /// Devuelve una representación en cadena del empleado, incluyendo su nombre, apellido e ID.
        /// </summary>
        /// <returns>Una cadena con el nombre, apellido y el ID del empleado</returns>
        public override string ToString()
        {
            return $"{Nombre} {Apellido}, ID de Empleado: {Id_Emp}";
        }
    }
}

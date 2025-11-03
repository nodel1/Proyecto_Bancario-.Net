using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BDs.PersistenciaEmpleado
{
    /// <summary>
    /// Representa los datos de un empleado almacenados en la base de datos.
    /// </summary>
    public class EmpleadoDato : Entity<string>
    {
        private string nombre;
        private string apellido;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EmpleadoDato"/> con el nombre,
        /// apellido y el ID del empleado.
        /// </summary>
        /// <param name="Nombre">El nombre del empleado.</param>
        /// <param name="Apellido">El apellido del empleado.</param>
        /// <param name="Id_emp">El ID del empleado (clave primaria).</param>
        public EmpleadoDato(String Nombre, String Apellido, string Id_emp) : base(Id_emp)
        {
            nombre = Nombre;
            apellido = Apellido;
        }

        /// <summary>
        /// Obtiene o establece el nombre del empleado.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece el apellido del empleado.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
    }
}

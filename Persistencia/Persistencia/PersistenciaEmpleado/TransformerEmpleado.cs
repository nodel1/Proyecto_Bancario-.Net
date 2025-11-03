using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BDs.PersistenciaEmpleado
{
    /// <summary>
    /// Clase que realiza la transformación entre objetos Empleado y EmpleadoDato.
    /// </summary>
    internal class TransformerEmpleado
    {
        /// <summary>
        /// Convierte un objeto Empleado en un objeto EmpleadoDato.
        /// </summary>
        /// <param name="empleado">El objeto Empleado a convertir.</param>
        /// <returns>El objeto EmpleadoDato correspondiente.</returns>
        public static EmpleadoDato EmpleadoaEmpleadoDato(Empleado empleado)
        {
            return new EmpleadoDato(empleado.Nombre, empleado.Apellido, empleado.Id_Emp);
        }

        /// <summary>
        /// Convierte un objeto EmpleadoDato en un objeto Empleado.
        /// </summary>
        /// <param name="empleadoDato">El objeto EmpleadoDato a convertir.</param>
        /// <returns>El objeto Empleado correspondiente.</returns>
        public static Empleado EmpleadoDatoaEmpleado(EmpleadoDato empleadoDato)
        {
            return new Empleado(empleadoDato.Nombre, empleadoDato.Apellido, empleadoDato.Id);
        }
    }
}

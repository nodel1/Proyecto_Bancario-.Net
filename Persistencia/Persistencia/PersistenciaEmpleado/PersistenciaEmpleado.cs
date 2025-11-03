using MD.MDActores;
using MD.MDCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BDs.PersistenciaEmpleado
{
    /// <summary>
    /// Clase que gestiona las operaciones CRUD para los empleados en la base de datos.
    /// </summary>
    public class PersistenciaEmpleado
    {
        /// <summary>
        /// Crea un nuevo empleado y lo agrega a la base de datos.
        /// </summary>
        /// <param name="empleado">El empleado a agregar.</param>
        public static void CREATE(Empleado empleado)
        {
            EmpleadoDato cd = TransformerEmpleado.EmpleadoaEmpleadoDato(empleado);
            BD.TablaEmpleado.Add(cd);
        }

        /// <summary>
        /// Obtiene un empleado a partir de su ID.
        /// </summary>
        /// <param name="id">El ID del empleado.</param>
        /// <returns>El empleado correspondiente al ID o null si no existe.</returns>
        public static Empleado READEmpleado(string id)
        {
            if (BD.TablaEmpleado.Contains(id))
            {
                return TransformerEmpleado.EmpleadoDatoaEmpleado(BD.TablaEmpleado[id]);
            }
            return null;
        }

        /// <summary>
        /// Obtiene todos los empleados de la base de datos.
        /// </summary>
        /// <returns>Una lista de todos los empleados.</returns>
        public static List<Empleado> READEmpleado()
        {
            List<Empleado> empleado = new List<Empleado>();
            foreach (var empleadoDato in BD.TablaEmpleado)
            {
                empleado.Add(TransformerEmpleado.EmpleadoDatoaEmpleado(empleadoDato));
            }
            return empleado;
        }

        /// <summary>
        /// Actualiza la información de un empleado existente en la base de datos.
        /// </summary>
        /// <param name="empleado">El empleado con los datos actualizados.</param>
        public static void UPDATE(Empleado empleado)
        {
            if (BD.TablaEmpleado.Contains(empleado.Id_Emp))
            {
                DELETE(empleado.Id_Emp);
                CREATE(empleado);
            }
        }

        /// <summary>
        /// Elimina un empleado de la base de datos utilizando su ID.
        /// </summary>
        /// <param name="id">El ID del empleado a eliminar.</param>
        public static void DELETE(string id)
        {
            if (BD.TablaEmpleado.Contains(id))
            {
                BD.TablaEmpleado.Remove(id);
            }
        }
    }
}

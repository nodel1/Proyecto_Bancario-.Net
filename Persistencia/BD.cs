using Persistencia.BDs.PersistenciaEmpleado;
using Persistencia.BDs.PersistenciaMovimiento;
using Persistencia.Persistencia.PersistenciaMovimiento;
using Persistencia.PersistenciaCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    /// <summary>
    /// Clase que proporciona acceso a las tablas que contienen datos de clientes, cuentas, empleados, movimientos y propietarios.
    /// </summary>
    internal class BD
    {
        private static Tabla<string, ClienteDato> tablaCliente;
        private static Tabla<string, CuentaDato> tablaCuenta;
        private static Tabla<string, EmpleadoDato> tablaEmpleado;
        private static Tabla<MovimientoDatoClave, MovimientoDato> tablaMovimiento;
        private static Tabla<PropietarioClave, PropietarioDato> tablaPropietario;

        /// <summary>
        /// Constructor privado para evitar la creación de instancias de la clase.
        /// </summary>
        private BD() { }

        /// <summary>
        /// Obtiene la tabla de clientes. Si no existe, la crea.
        /// </summary>
        public static Tabla<string, ClienteDato> TablaCliente
        {
            get
            {
                if (tablaCliente == null)
                {
                    tablaCliente = new Tabla<string, ClienteDato>();
                }
                return tablaCliente;
            }
        }

        /// <summary>
        /// Obtiene la tabla de cuentas. Si no existe, la crea.
        /// </summary>
        public static Tabla<string, CuentaDato> TablaCuenta
        {
            get
            {
                if (tablaCuenta == null)
                {
                    tablaCuenta = new Tabla<string, CuentaDato>();
                }
                return tablaCuenta;
            }
        }

        /// <summary>
        /// Obtiene la tabla de empleados. Si no existe, la crea.
        /// </summary>
        public static Tabla<string, EmpleadoDato> TablaEmpleado
        {
            get
            {
                if (tablaEmpleado == null)
                {
                    tablaEmpleado = new Tabla<string, EmpleadoDato>();
                }
                return tablaEmpleado;
            }
        }

        /// <summary>
        /// Obtiene la tabla de movimientos. Si no existe, la crea.
        /// </summary>
        public static Tabla<MovimientoDatoClave, MovimientoDato> TablaMovimiento
        {
            get
            {
                if (tablaMovimiento == null)
                {
                    tablaMovimiento = new Tabla<MovimientoDatoClave, MovimientoDato>();
                }
                return tablaMovimiento;
            }
        }

        /// <summary>
        /// Obtiene la tabla de propietarios. Si no existe, la crea con un valor predeterminado.
        /// </summary>
        public static Tabla<PropietarioClave, PropietarioDato> TablaPropietario
        {
            get
            {
                if (tablaPropietario == null)
                {
                    PropietarioClave cmeq = new PropietarioClave("", "");
                    tablaPropietario = new Tabla<PropietarioClave, PropietarioDato>(cmeq);
                }
                return tablaPropietario;
            }
        }
    }
}

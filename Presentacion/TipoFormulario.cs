using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    /// <summary>
    /// Representa los tipos de formularios clave disponibles.
    /// </summary>
    public enum TipoFormularioClave
    {
        /// <summary>
        /// Representa el formulario para cliente.
        /// </summary>
        Cliente,

        /// <summary>
        /// Representa el formulario para cuenta.
        /// </summary>
        Cuenta,

        /// <summary>
        /// Representa el formulario para movimiento.
        /// </summary>
        Movimiento
    }

    /// <summary>
    /// Representa los tipos de formularios relacionados con clientes.
    /// </summary>
    public enum TipoFormularioCliente
    {
        /// <summary>
        /// Representa el formulario para alta de cliente.
        /// </summary>
        Alta,

        /// <summary>
        /// Representa el formulario para búsqueda de cliente.
        /// </summary>
        Busqueda,

        /// <summary>
        /// Representa el formulario para baja de cliente.
        /// </summary>
        Baja
    }

    /// <summary>
    /// Representa los tipos de formularios relacionados con cuentas.
    /// </summary>
    public enum TipoFormularioCuenta
    {
        /// <summary>
        /// Representa el formulario para alta de cuenta.
        /// </summary>
        Alta,

        /// <summary>
        /// Representa el formulario para búsqueda de cuenta.
        /// </summary>
        Busqueda,

        /// <summary>
        /// Representa el formulario para baja de cuenta.
        /// </summary>
        Baja,

        /// <summary>
        /// Representa el formulario para recorrido de cuenta.
        /// </summary>
        Recorrido,

        /// <summary>
        /// Representa el formulario para listado de cuentas.
        /// </summary>
        Listado
    }

    /// <summary>
    /// Representa los tipos de formularios relacionados con movimientos.
    /// </summary>
    public enum TipoFormularioMovimiento
    {
        /// <summary>
        /// Representa el formulario para alta de movimiento.
        /// </summary>
        Alta,

        /// <summary>
        /// Representa el formulario para búsqueda de movimiento.
        /// </summary>
        Busqueda,
    }
}

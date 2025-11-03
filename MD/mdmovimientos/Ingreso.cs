using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDMovimientos
{
    /// <summary>
    /// Representa un movimiento de tipo ingreso en una cuenta.
    /// </summary>
    public class Ingreso : Movimiento
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Ingreso con los parámetros especificados.
        /// </summary>
        /// <param name="fecha">La fecha en la que se realizó el ingreso.</param>
        /// <param name="estado">El estado del movimiento.</param>
        /// <param name="importe">El importe del ingreso.</param>
        /// <param name="cuenta">La cuenta asociada al ingreso.</param>
        /// <param name="empleadoresponsable">El nombre del empleador responsable del ingreso.</param>
        /// <param name="cliente">El cliente asociado al ingreso.</param>
        public Ingreso(DateTime fecha, EstadoMovimiento estado, decimal importe, Cuenta cuenta, string empleadoresponsable, Cliente cliente)
            : base(fecha, estado, importe, cuenta, empleadoresponsable, cliente)
        {
        }
    }
}

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
    /// Representa un movimiento de reintegro en una cuenta.
    /// </summary>
    public class Reintegro : Movimiento
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Reintegro con los parámetros especificados.
        /// </summary>
        /// <param name="fecha">La fecha en la que se realizó el reintegro.</param>
        /// <param name="estado">El estado del movimiento de reintegro.</param>
        /// <param name="importe">El importe del reintegro.</param>
        /// <param name="cuenta">La cuenta asociada al movimiento de reintegro.</param>
        /// <param name="empleadoResponsable">El nombre del empleado responsable del reintegro.</param>
        /// <param name="cliente">El cliente asociado al movimiento de reintegro.</param>
        public Reintegro(DateTime fecha, EstadoMovimiento estado, decimal importe, Cuenta cuenta, string empleadoResponsable, Cliente cliente)
            : base(fecha, estado, importe, cuenta, empleadoResponsable, cliente)
        {

        }
    }
}

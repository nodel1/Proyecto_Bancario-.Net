using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNMovimiento
{
    /// <summary>
    /// Interfaz que define las operaciones relacionadas con los movimientos de las cuentas.
    /// </summary>
    public interface ILNMovimiento
    {
        /// <summary>
        /// Realiza un movimiento en una cuenta.
        /// </summary>
        /// <param name="movimiento">El movimiento a realizar</param>
        void RealizarMovimiento(Movimiento movimiento);

        /// <summary>
        /// Lee un movimiento específico de una cuenta en una fecha determinada.
        /// </summary>
        /// <param name="cuenta">La cuenta asociada al movimiento</param>
        /// <param name="fecha">La fecha del movimiento</param>
        /// <returns>El movimiento encontrado</returns>
        Movimiento LeerMovimiento(Cuenta cuenta, DateTime fecha);

        /// <summary>
        /// Obtiene todos los movimientos de una cuenta.
        /// </summary>
        /// <param name="cuenta">La cuenta de la cual obtener los movimientos</param>
        /// <returns>Lista de movimientos de la cuenta</returns>
        List<Movimiento> MovimientosCuenta(Cuenta cuenta);

        /// <summary>
        /// Obtiene los movimientos de una cuenta en un rango de fechas.
        /// </summary>
        /// <param name="cuenta">La cuenta de la cual obtener los movimientos</param>
        /// <param name="inicio">Fecha de inicio del rango</param>
        /// <param name="fin">Fecha de fin del rango</param>
        /// <returns>Lista de movimientos en el rango de fechas</returns>
        List<Movimiento> MovimientosPorRangoFechas(Cuenta cuenta, DateTime inicio, DateTime fin);

        /// <summary>
        /// Obtiene el cliente asociado a un movimiento.
        /// </summary>
        /// <param name="cuenta">La cuenta asociada al movimiento</param>
        /// <param name="fecha">La fecha del movimiento</param>
        /// <returns>El cliente asociado</returns>
        Cliente ObtenerClientePorMovimiento(Cuenta cuenta, DateTime fecha);

        /// <summary>
        /// Obtiene los movimientos de una cuenta específica.
        /// </summary>
        /// <param name="cuenta">La cuenta de la cual obtener los movimientos</param>
        /// <returns>Lista de movimientos de la cuenta</returns>
        List<Movimiento> ObtenerMovimientosCuenta(Cuenta cuenta);

        /// <summary>
        /// Obtiene los movimientos de un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos del día</returns>
        List<Movimiento> ObtenerMovimientosDia(DateTime dia);

        /// <summary>
        /// Obtiene los movimientos de pagos y recibos realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de pagos y recibos</returns>
        List<Movimiento> ObtenerPagosRecibosDia(DateTime dia);

        /// <summary>
        /// Obtiene los movimientos de ingresos realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de ingresos</returns>
        List<Movimiento> ObtenerIngresosDia(DateTime dia);

        /// <summary>
        /// Obtiene los movimientos de transferencias realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de transferencias</returns>
        List<Movimiento> ObtenerTransferenciasDia(DateTime dia);

        /// <summary>
        /// Obtiene los movimientos de reintegros realizados en un día específico.
        /// </summary>
        /// <param name="dia">El día de los movimientos</param>
        /// <returns>Lista de movimientos de reintegros</returns>
        List<Movimiento> ObtenerReintegrosDia(DateTime dia);
    }
}

using MD.MDActores;
using MD.MDCuenta;
using MD.MDMovimientos;
using Persistencia.PersistenciaCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD;
using MD.MDMovimientos;
using MD.MDCliente;

namespace Persistencia.BDs.PersistenciaMovimiento
{
    /// <summary>
    /// Proporciona métodos para transformar entre objetos <see cref="Movimiento"/> y <see cref="MovimientoDato"/>.
    /// </summary>
    internal class TransformerMovimiento
    {
        /// <summary>
        /// Transforma un objeto <see cref="Movimiento"/> en un objeto <see cref="MovimientoDato"/>.
        /// </summary>
        /// <param name="movimiento">El objeto <see cref="Movimiento"/> a transformar.</param>
        /// <returns>Un objeto <see cref="MovimientoDato"/> correspondiente al <see cref="Movimiento"/> dado.</returns>
        public static MovimientoDato Movimientoamovimientodato(Movimiento movimiento)
        {
            string tipo;

            if (movimiento is Transferencia transferencia)
            {
                tipo = "Transferencia";
                return new MovimientoDato(
                    movimiento.Fecha,
                    movimiento.Estado.ToString(),
                    movimiento.Importe,
                    transferencia.Concepto,
                    transferencia.IBAN_Destino,
                    null,
                    movimiento.Cuenta.IBAN,
                    movimiento.EmpleadoResponsable,
                    movimiento.Cliente.DNI,
                    tipo
                );
            }

            if (movimiento is PagoRecibo pagorecibo)
            {
                tipo = "PagoRecibo";
                return new MovimientoDato(
                    movimiento.Fecha,
                    movimiento.Estado.ToString(),
                    movimiento.Importe,
                    null,
                    pagorecibo.IBAN_Destino,
                    pagorecibo.Referencia_Recibo,
                    movimiento.Cuenta.IBAN,
                    movimiento.EmpleadoResponsable,
                    movimiento.Cliente.DNI,
                    tipo
                );
            }

            if (movimiento is Ingreso ingreso)
            {
                tipo = "Ingreso";
                return new MovimientoDato(
                    movimiento.Fecha,
                    movimiento.Estado.ToString(),
                    movimiento.Importe,
                    null,
                    null,
                    null,
                    movimiento.Cuenta.IBAN,
                    movimiento.EmpleadoResponsable,
                    movimiento.Cliente.DNI,
                    tipo
                );
            }

            if (movimiento is Reintegro reintegro)
            {
                tipo = "Reintegro";
                return new MovimientoDato(
                    movimiento.Fecha,
                    movimiento.Estado.ToString(),
                    movimiento.Importe,
                    null,
                    null,
                    null,
                    movimiento.Cuenta.IBAN,
                    movimiento.EmpleadoResponsable,
                    movimiento.Cliente.DNI,
                    tipo
                );
            }

            return null;
        }

        /// <summary>
        /// Transforma un objeto <see cref="MovimientoDato"/> en un objeto <see cref="Movimiento"/>.
        /// </summary>
        /// <param name="movimientoDato">El objeto <see cref="MovimientoDato"/> a transformar.</param>
        /// <returns>Un objeto <see cref="Movimiento"/> correspondiente al <see cref="MovimientoDato"/> dado.</returns>
        public static Movimiento MovimientoDatoaMovimiento(MovimientoDato movimientoDato)
        {
            DateTime fecha = movimientoDato.Id.Fecha;
            decimal importe = movimientoDato.Importe;
            Cuenta cuenta = PersistenciaCuenta.PersistenciaCuenta.READCuenta(movimientoDato.Id.Cuenta);
            Empleado emp1 = PersistenciaEmpleado.PersistenciaEmpleado.READEmpleado(movimientoDato.EmpleadoResponsable);
            string emp = emp1.Id_Emp;
            Cliente cliente = PersistenciaCliente.READCliente(movimientoDato.Cliente);
            string concepto = movimientoDato.Concepto;
            string referenciaRecibo = movimientoDato.Referencia_Recibo;
            string ibanDestino = movimientoDato.IBAN_Destino;

            EstadoMovimiento estadoMovimiento;
            switch (movimientoDato.Estado)
            {
                case "Ejecutado":
                    estadoMovimiento = EstadoMovimiento.Ejecutado;
                    break;
                case "Pendiente":
                    estadoMovimiento = EstadoMovimiento.Pendiente;
                    break;
                case "Cancelado":
                    estadoMovimiento = EstadoMovimiento.Cancelado;
                    break;
                case "Fallido":
                    estadoMovimiento = EstadoMovimiento.Fallido;
                    break;
                default:
                    estadoMovimiento = EstadoMovimiento.Fallido;
                    break;
            }

            switch (movimientoDato.TipoMovimiento)
            {
                case "Transferencia":
                    return new Transferencia(fecha, estadoMovimiento, importe, cuenta, emp, concepto, ibanDestino, cliente);

                case "PagoRecibo":
                    return new PagoRecibo(fecha, estadoMovimiento, importe, cuenta, emp, ibanDestino, referenciaRecibo, cliente);

                case "Reintegro":
                    return new Reintegro(fecha, estadoMovimiento, importe, cuenta, emp, cliente);

                case "Ingreso":
                    return new Ingreso(fecha, estadoMovimiento, importe, cuenta, emp, cliente);

                default:
                    return new Ingreso(fecha, estadoMovimiento, importe, cuenta, emp, cliente);
            }
        }
    }
}

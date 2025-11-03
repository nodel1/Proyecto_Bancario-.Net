using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCuenta
{
    public interface ILNCuenta
    {
        /// <summary>
        /// Lee una cuenta desde la base de datos.
        /// </summary>
        /// <param name="cuenta">Cuenta a leer.</param>
        /// <returns>La cuenta leída, o null si no existe.</returns>
        Cuenta LeerCuenta(Cuenta cuenta);

        /// <summary>
        /// Verifica si una cuenta existe en la base de datos.
        /// </summary>
        /// <param name="cuenta">Cuenta a verificar.</param>
        /// <returns>True si la cuenta existe, false si no.</returns>
        bool ExisteCuenta(Cuenta cuenta);

        /// <summary>
        /// Obtiene todas las cuentas del banco.
        /// </summary>
        /// <returns>Lista de cuentas en el banco.</returns>
        List<Cuenta> CuentasBanco();

        /// <summary>
        /// Obtiene todas las cuentas de un tipo específico.
        /// </summary>
        /// <param name="tipo">Tipo de cuenta a filtrar.</param>
        /// <returns>Lista de cuentas de ese tipo.</returns>
        List<Cuenta> CuentasPorTipo(TipoCuenta tipo);

        /// <summary>
        /// Obtiene todas las cuentas que están al descubierto.
        /// </summary>
        /// <returns>Lista de cuentas al descubierto.</returns>
        List<Cuenta> CuentasAlDescubierto();
    }
}

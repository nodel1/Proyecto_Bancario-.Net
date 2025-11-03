using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using MD;
using MD.MDActores;
using MD.MDCuenta;
using Persistencia.PersistenciaCuenta;
using MD.MDCliente;
using System.Drawing;

namespace LNCuenta
{
    /// <summary>
    /// Clase base para las operaciones relacionadas con las cuentas, incluyendo lectura, creación y eliminación de cuentas.
    /// </summary>
    public abstract class LNCuenta : ILNCuenta
    {
        private Empleado empleado;

        /// <summary>
        /// Constructor de LNCuenta.
        /// </summary>
        /// <param name="empleado">Empleado asociado a la clase</param>
        public LNCuenta(Empleado empleado)
        {
            this.empleado = empleado;
        }

        /// <summary>
        /// Crea una nueva cuenta en la persistencia.
        /// </summary>
        /// <param name="cuenta">Cuenta a crear</param>
        public void CrearCuenta(Cuenta cuenta)
        {
            PersistenciaCuenta.CREATE(cuenta);
        }

        /// <summary>
        /// Lee una cuenta desde la persistencia usando su IBAN.
        /// </summary>
        /// <param name="cuenta">Cuenta a leer</param>
        /// <returns>Cuenta encontrada</returns>
        public Cuenta LeerCuenta(Cuenta cuenta)
        {
            return PersistenciaCuenta.READCuenta(cuenta.IBAN);
        }

        /// <summary>
        /// Lee una cuenta desde la persistencia usando el IBAN.
        /// </summary>
        /// <param name="iban">IBAN de la cuenta</param>
        /// <returns>Cuenta encontrada</returns>
        public Cuenta LeerCuentaPorIBAN(string iban)
        {
            return PersistenciaCuenta.READCuenta(iban);
        }

        /// <summary>
        /// Elimina una cuenta de la persistencia.
        /// </summary>
        /// <param name="c">Cuenta a eliminar</param>
        public void EliminarCuenta(Cuenta c)
        {
            PersistenciaCuenta.DELETE(c.IBAN);
        }

        /// <summary>
        /// Verifica si una cuenta existe en la persistencia.
        /// </summary>
        /// <param name="cuenta">Cuenta a verificar</param>
        /// <returns>Verdadero si la cuenta existe, falso en caso contrario</returns>
        public bool ExisteCuenta(Cuenta cuenta)
        {
            return LeerCuenta(cuenta) != null;
        }

        /// <summary>
        /// Verifica si una cuenta existe en la persistencia usando el IBAN.
        /// </summary>
        /// <param name="iban">IBAN de la cuenta a verificar</param>
        /// <returns>Verdadero si la cuenta existe, falso en caso contrario</returns>
        public bool ExisteCuentaPorIBAN(string iban)
        {
            Cuenta c = PersistenciaCuenta.READCuenta(iban);
            return c != null;
        }

        /// <summary>
        /// Obtiene la lista de titulares de una cuenta.
        /// </summary>
        /// <param name="cuenta">Cuenta de la que obtener los titulares</param>
        /// <returns>Lista de DNIs de los titulares</returns>
        public List<string> ObtenerTitulares(Cuenta cuenta)
        {
            return PersistenciaCuenta.ObtenerPropietario(cuenta);
        }

        /// <summary>
        /// Obtiene todas las cuentas del banco.
        /// </summary>
        /// <returns>Lista de todas las cuentas</returns>
        public List<Cuenta> CuentasBanco()
        {
            return PersistenciaCuenta.READCuentas();
        }

        /// <summary>
        /// Obtiene las cuentas de un tipo específico.
        /// </summary>
        /// <param name="tipo">Tipo de cuenta</param>
        /// <returns>Lista de cuentas con el tipo especificado</returns>
        public List<Cuenta> CuentasPorTipo(TipoCuenta tipo)
        {
            List<Cuenta> cuentas = CuentasBanco();
            return cuentas.FindAll((c) => c.Tipo == tipo);
        }

        /// <summary>
        /// Obtiene las cuentas cuyo saldo es negativo (cuentas al descubierto).
        /// </summary>
        /// <returns>Lista de cuentas al descubierto</returns>
        public List<Cuenta> CuentasAlDescubierto()
        {
            List<Cuenta> cuentas = CuentasBanco();
            return cuentas.FindAll((c) => c.Saldo < 0);
        }
    }
}

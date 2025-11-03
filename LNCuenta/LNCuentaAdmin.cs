using MD.MDActores;
using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.PersistenciaCuenta;

namespace LNCuenta
{
    /// <summary>
    /// Clase que maneja las operaciones administrativas sobre las cuentas, como abrir y cerrar cuentas.
    /// </summary>
    public class LNCuentaAdmin : LNCuenta, ILNCuentaAdmin
    {
        /// <summary>
        /// Constructor de LNCuentaAdmin.
        /// </summary>
        /// <param name="empleado">Empleado asociado a la clase</param>
        public LNCuentaAdmin(Empleado empleado) : base(empleado) { }

        /// <summary>
        /// Abre una nueva cuenta en la persistencia.
        /// </summary>
        /// <param name="cuenta">Cuenta a abrir</param>
        public void AbrirCuenta(Cuenta cuenta)
        {
            PersistenciaCuenta.CREATE(cuenta);
        }

        /// <summary>
        /// Cierra una cuenta en la persistencia.
        /// </summary>
        /// <param name="cuenta">Cuenta a cerrar</param>
        public void CerrarCuenta(Cuenta cuenta)
        {
            PersistenciaCuenta.DELETE(cuenta.IBAN);
        }
    }
}

using MD.MDActores;
using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCuenta
{
    public interface ILNCuentaAdmin : ILNCuenta
    {
        /// <summary>
        /// Abre una nueva cuenta en el sistema.
        /// </summary>
        /// <param name="cuenta">La cuenta que se va a abrir.</param>
        void AbrirCuenta(Cuenta cuenta);

        /// <summary>
        /// Cierra una cuenta existente en el sistema.
        /// </summary>
        /// <param name="cuenta">La cuenta que se va a cerrar.</param>
        void CerrarCuenta(Cuenta cuenta);
    }
}

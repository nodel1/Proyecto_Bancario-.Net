using MD.MDActores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNCliente;
using LNCuenta;
using LNMovimiento;

namespace LN
{
    public abstract class LN
    {
        private Empleado empleado;
        private LNCliente.LNCliente lncliente;
        private LNCuenta.LNCuenta lncuenta;
        private LNMovimiento.LNMovimiento lnmovimiento;

        /// <summary>
        /// Constructor de la clase LN.
        /// Inicializa los objetos de lógica de negocio y asocia un empleado.
        /// </summary>
        /// <param name="empl">Empleado asociado a esta instancia de lógica de negocio.</param>
        /// <param name="lnCliente">Instancia de la lógica de negocio de clientes.</param>
        /// <param name="lnCuenta">Instancia de la lógica de negocio de cuentas.</param>
        /// <param name="lnMovimiento">Instancia de la lógica de negocio de movimientos.</param>
        public LN(Empleado empl, LNCliente.LNCliente lnCliente, LNCuenta.LNCuenta lnCuenta, LNMovimiento.LNMovimiento lnMovimiento)
        {
            this.empleado = empl;
            this.lncliente = lnCliente;
            this.lncuenta = lnCuenta;
            this.lnmovimiento = lnMovimiento;
        }

        /// <summary>
        /// Obtiene el empleado asociado a esta lógica de negocio.
        /// </summary>
        public Empleado Empleado
        {
            get { return empleado; }
        }

        /// <summary>
        /// Obtiene la instancia de la lógica de negocio de clientes.
        /// </summary>
        public LNCliente.LNCliente LNCliente
        {
            get { return lncliente; }
        }

        /// <summary>
        /// Obtiene la instancia de la lógica de negocio de cuentas.
        /// </summary>
        public LNCuenta.LNCuenta LNCuenta
        {
            get { return lncuenta; }
        }

        /// <summary>
        /// Obtiene la instancia de la lógica de negocio de movimientos.
        /// </summary>
        public LNMovimiento.LNMovimiento LNMovimiento
        {
            get { return lnmovimiento; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN;
using LNEmpleado;
using MD;
using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;


namespace LNAdministrador
{
    public class LNAdministrador: LNEmpleado.LNEmpleado
    {
        private Administrador administrador;

        public LNAdministrador(Administrador administrador)
        {
            this.administrador = administrador;
        }

        public Administrador Administrador
        {
            get { return administrador; }
        }

        public void AltaCliente (Cliente c)
        {
            
        }

        public void BajaCliente (Cliente c)
        {

        }

        public void AperturaCuenta (Cuenta cuenta)
        {

        }

        public void CierreCuenta (Cuenta cuenta)
        {

        }



    }
}

namespace Persistencia
{
    static class BD 
    {
        // ACTORES
        private static Tabla<int, Administrador> tablaAdministradores;
        private static Tabla<int, Ventanilla> tablaVentanillas;
        private static Tabla<int, Empleado> tablaEmpleados;
        private static Tabla<string, Cliente> tablaClientes;

        //CUENTAS y MOVIMIENTOS
        private static Tabla<string, Cuenta> tablaCuentas;
        private static Tabla<int, Movimiento> tablaMovimientos; // Para almacenar movimientos genéricos
        private static Tabla<int, Ingreso> tablaIngresos;
        private static Tabla<int, PagoRecibo> tablaPagosRecibo;
        private static Tabla<int, Reintegro> tablaReintegros;
        private static Tabla<int, Transferencia> tablaTransferencias;

        //Mirar que hacer con Propietario y empleado
        // Propiedades para acceso a las tablas de actores
        public static Tabla<int, Administrador> TablaAdministradores
        {
            get
            {
                if (tablaAdministradores == null)
                {
                    tablaAdministradores = new Tabla<int, Administrador>();
                }
                return tablaAdministradores;
            }
        }

        public static Tabla<int, Ventanilla> TablaVentanillas
        {
            get
            {
                if (tablaVentanillas == null)
                {
                    tablaVentanillas = new Tabla<int, Ventanilla>();
                }
                return tablaVentanillas;
            }
        }

        public static Tabla<int, Empleado> TablaEmpleados
        {
            get
            {
                if (tablaEmpleados == null)
                {
                    tablaEmpleados = new Tabla<int, Empleado>();
                }
                return tablaEmpleados;
            }
        }

        public static Tabla<string, Cliente> TablaClientes
        {
            get
            {
                if (tablaClientes == null)
                {
                    tablaClientes = new Tabla<string, Cliente>();
                }
                return tablaClientes;
            }
        }

        // Propiedades para acceso a las tablas de cuentas y movimientos
        public static Tabla<string, Cuenta> TablaCuentas
        {
            get
            {
                if (tablaCuentas == null)
                {
                    tablaCuentas = new Tabla<string, Cuenta>();
                }
                return tablaCuentas;
            }
        }

        public static Tabla<int, Movimiento> TablaMovimientos
        {
            get
            {
                if (tablaMovimientos == null)
                {
                    tablaMovimientos = new Tabla<int, Movimiento>();
                }
                return tablaMovimientos;
            }
        }

        public static Tabla<int, Ingreso> TablaIngresos
        {
            get
            {
                if (tablaIngresos == null)
                {
                    tablaIngresos = new Tabla<int, Ingreso>();
                }
                return tablaIngresos;
            }
        }

        public static Tabla<int, PagoRecibo> TablaPagosRecibo
        {
            get
            {
                if (tablaPagosRecibo == null)
                {
                    tablaPagosRecibo = new Tabla<int, PagoRecibo>();
                }
                return tablaPagosRecibo;
            }
        }

        public static Tabla<int, Reintegro> TablaReintegros
        {
            get
            {
                if (tablaReintegros == null)
                {
                    tablaReintegros = new Tabla<int, Reintegro>();
                }
                return tablaReintegros;
            }
        }

        public static Tabla<int, Transferencia> TablaTransferencias
        {
            get
            {
                if (tablaTransferencias == null)
                {
                    tablaTransferencias = new Tabla<int, Transferencia>();
                }
                return tablaTransferencias;
            }
        }
    }
}

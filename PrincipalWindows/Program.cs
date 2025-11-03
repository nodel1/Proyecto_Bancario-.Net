using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNCliente;
using MD.MDCliente;
using MD.MDActores;
using LNCuenta;
using LNMovimiento;
using LN;
using Presentacion;
using Persistencia;
using MD.MDCuenta;
using Persistencia.PersistenciaCuenta;
using MD.MDMovimientos;

namespace PrincipalWindows
{
    /// <summary>
    /// Punto de entrada principal para la aplicación Windows.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Método principal que inicia la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Creación de administrador
            Administrador admin = new Administrador("Noel", "RIO", "1");
            LNAdmin lnadmin = new LNAdmin(admin);
            LNClienteAdmin ln = (LNClienteAdmin)lnadmin.LNCliente;  // Cast de LNClienteAdmin
            ln.darAltaEmpleado(admin);

            // Creación de ventanilla
            Ventanilla vent = new Ventanilla("paco", "Fernandez", "2");
            ln.darAltaEmpleado(vent);


            // Creación de instancias de clientes
            Cliente cliente = new Cliente("Andrea", "Cre", "12345", "andrea@yahoo.es");
            Cliente cliente2 = new Cliente("Noelcin", "Rio", "111", "noel@gmail.com");
            Cliente cliente3 = new Cliente("Francisco", "Fernandez", "78950359V", "fran@hotmail.com");
            Cliente cliente4 = new Cliente("Pedro", "Lopez", "9865", "pedrito@gmail.es");
            Cliente cliente5 = new Cliente("Laura", "Campos", "9999999999", "laura@gmail.com");

           

            // Creación de instancias de cuentas
            LNCuentaAdmin lnCuentaAdmin = new LNCuentaAdmin(admin);
            Cuenta cuenta = new Cuenta("ES123", TipoCuenta.Bonificada, 98, DateTime.Now, EstadoCuenta.Abierta);
            Cuenta cuenta2 = new Cuenta("ES1234", TipoCuenta.Bonificada, 9899, DateTime.Now, EstadoCuenta.Abierta);
            Cuenta cuenta3 = new Cuenta("ES456789", TipoCuenta.Ahorro, 2, DateTime.Now, EstadoCuenta.Abierta);
            Cuenta cuenta4 = new Cuenta("jhduihdiwuhwi", TipoCuenta.Ahorro, 9999999, DateTime.Now, EstadoCuenta.Abierta);

            // Alta de clientes y cuentas
            ln.DarDeAltaCliente(cliente);
            ln.DarDeAltaCliente(cliente2);
            ln.DarDeAltaCliente(cliente3);
            ln.DarDeAltaCliente(cliente4);
            ln.DarDeAltaCliente(cliente5);
            lnCuentaAdmin.AbrirCuenta(cuenta);
            lnCuentaAdmin.AbrirCuenta(cuenta2);
            lnCuentaAdmin.AbrirCuenta(cuenta3);
            lnCuentaAdmin.AbrirCuenta(cuenta4);

            // Asociación de cuentas a clientes
            ln.AñadirCuentaAlCliente(cliente, cuenta);
            ln.AñadirCuentaAlCliente(cliente, cuenta2);
            ln.AñadirCuentaAlCliente(cliente2, cuenta3);
            ln.AñadirCuentaAlCliente(cliente2, cuenta2);
            ln.AñadirCuentaAlCliente(cliente3, cuenta2);
            ln.AñadirCuentaAlCliente(cliente3, cuenta4);
            ln.AñadirCuentaAlCliente(cliente4, cuenta4);
            ln.AñadirCuentaAlCliente(cliente2, cuenta4);

            // Comprobación de existencia de clientes y cuentas
            if (lnadmin.LNCliente.ExisteCliente(cliente))
            {
                Console.WriteLine("Exito cliente");
            }

            if (lnadmin.LNCuenta.ExisteCuenta(cuenta))
            {
                Console.WriteLine("Exito cuenta");
            }

            // Leer y mostrar clientes desde la base de datos
            List<Cliente> clientes = PersistenciaCliente.READClientes();
            foreach (var gg in clientes)
            {
                Console.WriteLine($"DNI: {gg.DNI}, Nombre: {gg.Nombre}, Apellido: {gg.Apellido}, Dirección: {gg.Email}");
            }

            // Leer y mostrar cuentas creadas desde la base de datos
            List<Cuenta> cuentasCreadas = PersistenciaCuenta.READCuentas();
            Console.WriteLine("Cuentas creadas en la base de datos:");
            foreach (var cuentaCreada in cuentasCreadas)
            {
                Console.WriteLine($"IBAN: {cuentaCreada.IBAN}, Tipo: {cuentaCreada.Tipo}, Saldo: {cuentaCreada.Saldo}, Estado: {cuentaCreada.Estado}, Fecha de Apertura: {cuentaCreada.FechaApertura}");
            }

            // Leer y mostrar cuentas asociadas al cliente
            List<Cuenta> cuentasDelCliente = ln.CuentasCliente(cliente);
            Console.WriteLine("Cuentas asociadas al cliente:");
            foreach (var pp in cuentasDelCliente)
            {
                Console.WriteLine($"IBAN: {pp.IBAN}, Tipo: {pp.Tipo}, Saldo: {pp.Saldo}, Estado: {pp.Estado}, Fecha de Apertura: {pp.FechaApertura}");
            }

            // Crear un movimiento de prueba
            Movimiento movimientoPrueba = new Transferencia(
                DateTime.Now,  // Fecha
                EstadoMovimiento.Ejecutado,  // Estado
                500.50m,  // Importe
                cuenta,  // Cuenta origen
                admin.Id_Emp,  // Empleado responsable
                "Transferencia de prueba",  // Concepto
                "ES987654321",  // IBAN destino
                cliente  // Cliente asociado
            );

            // Crear otro movimiento
            DateTime fecha = new DateTime(2024, 12, 30, 10, 00, 0);
            Movimiento movimiento2 = new Ingreso(
                fecha,  // Fecha
                EstadoMovimiento.Cancelado,  // Estado
                100.50m,  // Importe
                cuenta,  // Cuenta origen
                admin.Id_Emp,  // Empleado responsable
                cliente  // Cliente asociado
            );

            // Mostrar valores del movimiento creado
            Console.WriteLine("Valores del movimiento creado:");
            Console.WriteLine($"Fecha: {movimientoPrueba.Fecha}");
            Console.WriteLine($"Estado: {movimientoPrueba.Estado}");
            Console.WriteLine($"Importe: {movimientoPrueba.Importe}");
            Console.WriteLine($"Cuenta Origen: {movimientoPrueba.Cuenta.IBAN}");
            Console.WriteLine($"Empleado Responsable: {movimientoPrueba.EmpleadoResponsable}");

            Console.WriteLine("-----------------------------");

            // Comprobación de nulos
            if (admin == null)
            {
                Console.WriteLine("El objeto admin es null");
            }
            else
            {
                Console.WriteLine("El objeto admin es válido");
            }

            if (movimientoPrueba.EmpleadoResponsable != null)
            {
                Console.WriteLine("no es nulo");
            }

            if (movimientoPrueba.EmpleadoResponsable == null)
            {
                Console.WriteLine("es nulo");
            }

            // Persistir los movimientos
            PersistenciaMovimiento.CREATE(movimientoPrueba);
            PersistenciaMovimiento.CREATE(movimiento2);

            // Leer y mostrar movimientos desde la base de datos
            List<Movimiento> movimientosLeidos = PersistenciaMovimiento.READMovimientos();
            Console.WriteLine("Movimientos leídos de la base de datos:");
            foreach (var movimientoLeido in movimientosLeidos)
            {
                Console.WriteLine($"Fecha: {movimientoLeido.Fecha}");
                Console.WriteLine($"Estado: {movimientoLeido.Estado}");
                Console.WriteLine($"Importe: {movimientoLeido.Importe}");
                Console.WriteLine($"Cuenta Origen: {movimientoLeido.Cuenta.IBAN}");
                Console.WriteLine($"Empleado Responsable: {movimientoLeido.EmpleadoResponsable}");
                Console.WriteLine("-----------------------------");
            }

            // Iniciar la aplicación Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FLogin());
        }
    }
}

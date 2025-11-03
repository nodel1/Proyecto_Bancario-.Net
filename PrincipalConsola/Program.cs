using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.MDCliente;
using MD.MDActores;
using LNCliente;
using LNCuenta;
using LNMovimiento;
using LN;
using Presentacion;
using static System.Net.Mime.MediaTypeNames;
using MD.MDCuenta;
using Persistencia.PersistenciaCuenta;
using System.Data.Common;

namespace PrincipalConsola
{
    /// <summary>
    /// Clase principal que contiene el punto de entrada para la aplicación de consola.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// Crea clientes, cuentas y realiza operaciones de alta y baja.
        /// </summary>
        static void Main(string[] args)
        {
            // Creación de clientes
            Cliente cliente = new Cliente("Andrea", "Cre", "123445", "andrea@yahoo.es");
            Cliente cliente2 = new Cliente("Noelcin", "Rio", "111", "noel@gmail.com");
            Cliente cliente3 = new Cliente("Francisco", "Fernandez", "78950359V", "fran@hotmail.com");

            // Creación de administrador y LNCliente
            Administrador admin = new Administrador("Noel", "RIO", "1");
            LNAdmin lnadmin = new LNAdmin(admin);
            LNClienteAdmin ln = (LNClienteAdmin)lnadmin.LNCliente;

            // Dar de alta clientes
            ln.DarDeAltaCliente(cliente);
            ln.DarDeAltaCliente(cliente2);
            ln.DarDeAltaCliente(cliente3);

            // Verificación de existencia de un cliente
            if (lnadmin.LNCliente.ExisteCliente(cliente))
            {
                Console.WriteLine("Se ha creado el cliente " + cliente.DNI);
            }

            // Creación de cuentas
            Cuenta cuenta = new Cuenta("ES123", TipoCuenta.Bonificada, 98, DateTime.Now, EstadoCuenta.Abierta);
            Cuenta cuenta2 = new Cuenta("ES1234", TipoCuenta.Bonificada, 9899, DateTime.Now, EstadoCuenta.Abierta);
            Cuenta cuenta3 = new Cuenta("ES456789", TipoCuenta.Ahorro, 2, DateTime.Now, EstadoCuenta.Abierta);

            // Crear cuentas en el sistema
            lnadmin.LNCuenta.CrearCuenta(cuenta);
            lnadmin.LNCuenta.CrearCuenta(cuenta2);
            lnadmin.LNCuenta.CrearCuenta(cuenta3);

            // Añadir cuentas al cliente
            ln.AñadirCuentaAlCliente(cliente, cuenta);
            ln.AñadirCuentaAlCliente(cliente, cuenta2); // Andrea tiene dos cuentas

            // Mostrar cuentas del cliente
            foreach (Cuenta c in ln.CuentasCliente(cliente))
            {
                Console.WriteLine(c.IBAN);
            }

            // Mostrar titulares de una cuenta
            Console.WriteLine("Titulares de la cuenta: ");
            foreach (string c in lnadmin.LNCuenta.ObtenerTitulares(cuenta))
            {
                Console.WriteLine(c);
            }

            // Dar de baja a un cliente
            ln.DarDeBajaCliente(cliente);

            // Mostrar titulares tras dar de baja al cliente
            Console.WriteLine("Titulares de la cuenta tras borrar el cliente: ");
            foreach (string c in lnadmin.LNCuenta.ObtenerTitulares(cuenta))
            {
                Console.WriteLine(c);
            }

            // Mostrar cuentas del banco
            Console.WriteLine("Cuentas del banco: ");
            foreach (Cuenta cu in lnadmin.LNCuenta.CuentasBanco())
            {
                Console.WriteLine("IBAN de la cuenta: " + cu.IBAN);
            }

            // Mostrar cuentas tras eliminar una cuenta
            // lnadmin.LNCuenta.EliminarCuenta(cuenta);
            Console.WriteLine("Cuentas del banco tras borrarla: ");
            foreach (Cuenta cu in lnadmin.LNCuenta.CuentasBanco())
            {
                Console.WriteLine("IBAN de la cuenta: " + cu.IBAN);
            }

            /*
            // Código comentado para lectura de cuentas desde la base de datos
            List<Cuenta> cuentasCreadas = PersistenciaCuenta.READCuentas();
            Console.WriteLine("Cuentas creadas en la base de datos:");
            foreach (var cuentaCreada in cuentasCreadas)
            {
                Console.WriteLine($"IBAN: {cuentaCreada.IBAN}, Tipo: {cuentaCreada.Tipo}, Saldo: {cuentaCreada.Saldo}, Estado: {cuentaCreada.Estado}, Fecha de Apertura: {cuentaCreada.FechaApertura}");
            }
            */
            Console.Read();
        }
    }
}

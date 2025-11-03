using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD;
using MD.MDCliente;
using MD.MDCuenta;
using MD.MDActores;
using MD.MDMovimientos;
using LN;
using LNCliente;
using LNCuenta;
using LNMovimiento;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Net;

namespace Presentacion
{
    public partial class PREmpleado : Form
    {
        private LN.LN ln;


          /// <summary>
        /// Inicializa una nueva instancia de la clase PREmpleado.
        /// </summary>
        public PREmpleado()
        {
            IsMdiContainer = true;
            InitializeComponent();

            //esto es para probar el principar windows que hay que inicializar el objeto ln, lo inicializa, en caso de querer probarlo

           // Administrador administrador1 = new Administrador("paco", "gonzalez", "123");
            //this.ln = new LNAdmin(administrador1);
            //ln.LNCliente.darAltaEmpleado(administrador1);
        }


        /// <summary>
        /// Inicializa una nueva instancia de la clase PREmpleado con el objeto LN proporcionado.
        /// </summary>
        /// <param name="ln">El objeto LN para la lógica de negocio.</param>

        public PREmpleado(LN.LN ln) : this()
        {
            this.ln = ln;
        }

        /// <summary>
        /// Muestra un formulario para buscar un cliente por DNI y mostrar su información si existe.
        /// </summary>
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            // para solicitar el DNI
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave; 
                formClave.Dispose();



                if (ln.LNCliente.ExisteCliente(new Cliente(null, null,dni, null)))
                {
                    Cliente cliente=ln.LNCliente.LeerClientePorDNI(dni);
                   

                    FClienteDatos formDatos = new FClienteDatos(dni, cliente.Nombre, ln);
                    formDatos.ShowDialog();
                }
                else
                {
                    DialogResult resultadoNuevo = MessageBox.Show(
                        "¿Quieres introducir otro?",
                        "No existe un cliente con ese DNI",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultadoNuevo == DialogResult.Yes)
                    {
                        clienteToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

        /// <summary>
        /// Muestra un formulario con las cuentas asociadas a un cliente identificado por su DNI.
        /// </summary>
        private void cuentasDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave; 
                formClave.Dispose();

                if (ln.LNCliente.ExisteClientePorDNI(dni))
                {
                    Cliente cliente = ln.LNCliente.LeerCliente(new Cliente(null, null, dni, null));
                    List<Cuenta> cuentas = ln.LNCliente.CuentasCliente(cliente);

                    if (cuentas != null && cuentas.Count > 0)
                    {
                        FCuentasCliente formCuentas = new FCuentasCliente(cuentas, cliente);
                        formCuentas.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no tiene cuentas asociadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult resultadoNuevo = MessageBox.Show(
                        "¿Quieres introducir otro?",
                        "No existe un cliente con ese DNI",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultadoNuevo == DialogResult.Yes)
                    {
                        cuentasDelClienteToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }
        /// <summary>
        /// Muestra un formulario con los movimientos asociados a un cliente identificado por su DNI.
        /// </summary>
        private void movimientosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave; 
                formClave.Dispose();


                if (ln.LNCliente.ExisteCliente(new Cliente(null, null, dni, null)))
                {
                    Cliente cliente = ln.LNCliente.LeerClientePorDNI(dni);
                     List<Movimiento> movimientos = ln.LNCliente.MovimientosCliente(cliente);

                    if (movimientos != null && movimientos.Count > 0)
                    {
                        FListadoMovimientos formMovimientos=new FListadoMovimientos("Movimientos de "+cliente.Nombre+ " "+cliente.Apellido, movimientos);
                        formMovimientos.Show();
                    }
                    else
                    {
                        MessageBox.Show("No hay movimientos registrados para este cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult resultadoNuevo = MessageBox.Show(
                        "¿Quieres introducir otro?",
                        "No existe un cliente con ese DNI",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultadoNuevo == DialogResult.Yes)
                    {
                        movimientosDelClienteToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }


        /// <summary>
        /// Muestra un listado de todos los clientes del banco junto con su saldo total.
        /// </summary>

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Cliente> clientes = ln.LNCliente.ClientesBanco();

            List<(Cliente cliente, decimal saldo)> listaClientes = new List<(Cliente cliente, decimal saldo)>();


            foreach (Cliente cliente in clientes)
            {
                decimal saldo = obtenerSaldo(cliente); 
                listaClientes.Add((cliente, saldo)); 
            }

            FListadoClientes formListado = new FListadoClientes(listaClientes);
            formListado.Show();

        }
        /// <summary>
        /// Muestra un recorrido de clientes del banco con su saldo total.
        /// </summary>

        private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Cliente> clientes = ln.LNCliente.ClientesBanco();
            List<(Cliente cliente, decimal saldo)> clientesConSaldo = new List<(Cliente, decimal)>();


            foreach (var cliente in clientes)
            {
                decimal saldo = obtenerSaldo(cliente);
                clientesConSaldo.Add((cliente, saldo));
            }

            FRecorridoCliente formRecorrido = new FRecorridoCliente(clientesConSaldo);
            formRecorrido.Show();
        }



        /// <summary>
        /// Obtiene el saldo total de todas las cuentas asociadas a un cliente.
        /// </summary>
        /// <param name="cliente">El cliente cuya cuenta se quiere obtener el saldo.</param>
        /// <returns>El saldo total de todas las cuentas asociadas al cliente.</returns>

        private decimal obtenerSaldo(Cliente cliente)
        {
            decimal saldoTotal = 0;

            List<Cuenta> cuentas = ln.LNCliente.CuentasCliente(cliente);


            foreach (var cuenta in cuentas)
            {
                saldoTotal += cuenta.Saldo;
            }

            return saldoTotal;
        }

        /// <summary>
        /// Busca una cuenta por IBAN y muestra sus detalles si existe.
        /// </summary>
        private void busquedaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cuenta);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string iban = formClave.Clave; 
                formClave.Dispose();

                Cuenta cuentaBusqueda = new Cuenta(iban, TipoCuenta.Joven, 1, DateTime.Now, EstadoCuenta.Abierta);
               
                if (ln.LNCuenta.ExisteCuenta(cuentaBusqueda))
                {
                    
                    FCuentaDatos formDatos = new FCuentaDatos(cuentaBusqueda, ln);
                    formDatos.ShowDialog();
                }
                else
                {
                    DialogResult resultadoNuevo = MessageBox.Show(
                        "¿Quieres introducir otro IBAN?",
                        "No existe una cuenta con ese IBAN",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultadoNuevo == DialogResult.Yes)
                    {
                        busquedaToolStripMenuItem2_Click(sender, e);
                    }
                }
            }
        }

        /// <summary>
        /// Muestra un listado de todas las cuentas del banco.
        /// </summary>
        private void listadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasBanco();


            FListadoCuentas formListado = new FListadoCuentas("Banco", cuentas);
            formListado.Show();
        }

        /// <summary>
        /// Muestra un listado de las cuentas asociadas a un cliente identificado por su DNI.
        /// </summary>
        private void listadoDeCuentasPorTitularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dniCliente = formClave.Clave;
                formClave.Dispose();

                Cliente cliente = ln.LNCliente.LeerCliente(new Cliente(null, null, dniCliente, null));

                if (cliente != null)
                {
                    List<Cuenta> cuentas = ln.LNCliente.CuentasCliente(cliente);

                    if (cuentas != null && cuentas.Count > 0)
                    {
                        FListadoCuentas formListado = new FListadoCuentas(cliente.Nombre, cuentas);
                        formListado.Show();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontraron cuentas asociadas a este cliente.",
                            "Listado de cuentas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró un cliente con ese DNI.",
                        "Listado de cuentas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }




        private void jovenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasPorTipo(TipoCuenta.Joven);

            FListadoCuentas formListado = new FListadoCuentas("Joven", cuentas);
            formListado.Show();
        }

        private void ahorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasPorTipo(TipoCuenta.Ahorro);

            FListadoCuentas formListado = new FListadoCuentas("Ahorro", cuentas);
            formListado.Show();
        }

        private void bonificadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasPorTipo(TipoCuenta.Bonificada);

            FListadoCuentas formListado = new FListadoCuentas("Bonificada", cuentas);
            formListado.Show();
        }

        private void oroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasPorTipo(TipoCuenta.Oro);

            FListadoCuentas formListado = new FListadoCuentas("Oro", cuentas);
            formListado.Show();
        }

        private void listadoDeCuentasAlDescubiertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasAlDescubierto();

            FListadoCuentas formListado = new FListadoCuentas("Cuentas al Descubierto", cuentas);
            formListado.Show();
        }

        private void recorridoUnoAUnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasBanco(); 
           
            FRecorridoCuenta formRecorrido = new FRecorridoCuenta(cuentas, ln);  
            formRecorrido.ShowDialog();

        }



        private void introducirMovimientoToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            List<Cliente> clientes = ln.LNCliente.ClientesBanco();
            List<String> dnis = new List<string>();
            foreach (Cliente cliente in clientes)
            {
                dnis.Add(cliente.DNI);
            }
            FAltaMovimiento formulario=new FAltaMovimiento(ln, dnis);
            formulario.Show();

        }


        private void porDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFecha formFecha = new FFecha();
            DialogResult resultado = formFecha.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                DateTime fechaSeleccionada = formFecha.Fecha;
                formFecha.Dispose();

                List<Movimiento> movimientos = ln.LNMovimiento.ObtenerMovimientosDia(fechaSeleccionada);

                if (movimientos != null && movimientos.Count > 0)
                {
                    FListadoMovimientos formListado = new FListadoMovimientos($"Movimientos del día {fechaSeleccionada.ToShortDateString()}", movimientos);
                    formListado.Show();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontraron movimientos registrados para la fecha seleccionada.",
                        "Movimientos por Día",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }

        }


        private void jovenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarMovimientosPorTipoCuenta(TipoCuenta.Joven, "Movimientos de cuentas Joven");
        }

        private void ahorroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarMovimientosPorTipoCuenta(TipoCuenta.Ahorro, "Movimientos de cuentas Ahorro");
        }

        private void bonificadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarMovimientosPorTipoCuenta(TipoCuenta.Bonificada, "Movimientos de cuentas Bonificada");
        }

        private void oroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarMovimientosPorTipoCuenta(TipoCuenta.Oro, "Movimientos de cuentas Oro");
        }


        private void MostrarMovimientosPorTipoCuenta(TipoCuenta tipoCuenta, string titulo)        
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasPorTipo(tipoCuenta);
            List<Movimiento> movimientos = new List<Movimiento>();

            foreach (var cuenta in cuentas)
            {
                movimientos.AddRange(ln.LNMovimiento.MovimientosCuenta(cuenta));
            }

            if (movimientos.Count > 0)
            {
                FListadoMovimientos formListado = new FListadoMovimientos(titulo, movimientos);
                formListado.Show();
            }
            else
            {
                MessageBox.Show(
                    $"No se encontraron movimientos para las cuentas de tipo {tipoCuenta}.",
                    "Movimientos por Tipo de Cuenta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }





        private void movimientosPorRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cuenta);
            DialogResult resultadoCuenta = formClave.ShowDialog();

            if (resultadoCuenta == DialogResult.OK)
            {
                string ibanCuenta = formClave.Clave;
                formClave.Dispose();

                Cuenta cuenta = ln.LNCuenta.LeerCuenta(new Cuenta(ibanCuenta, TipoCuenta.Oro, 0, DateTime.MinValue, EstadoCuenta.Abierta));

                if (cuenta != null)
                {
                    FFechaRango formFechaRango = new FFechaRango();
                    DialogResult resultadoFecha = formFechaRango.ShowDialog();

                    if (resultadoFecha == DialogResult.OK)
                    {
                        DateTime fechaInicio = formFechaRango.FechaInicio;
                        DateTime fechaFin = formFechaRango.FechaFin;
                        formFechaRango.Dispose();

                        List<Movimiento> movimientos = ln.LNMovimiento.MovimientosPorRangoFechas(cuenta, fechaInicio, fechaFin);

                        if (movimientos != null && movimientos.Count > 0)
                        {
                            FListadoMovimientos formListado = new FListadoMovimientos(
                                $"Movimientos desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}",
                                movimientos
                            );
                            formListado.Show();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontraron movimientos en el rango de fechas seleccionado.",
                                "Movimientos por Rango de Fechas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró una cuenta con ese IBAN.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        private void porIDToolStripMenuItem_Click(object sender, EventArgs e)   
        {
           
            Fclave formClave = new Fclave(TipoFormularioClave.Cuenta);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string iban = formClave.Clave;
                formClave.Dispose();
                Cuenta cuenta= ln.LNCuenta.LeerCuenta(new Cuenta(iban, TipoCuenta.Oro, 0, DateTime.MinValue, EstadoCuenta.Abierta));

                if (cuenta != null)
                {
                    FFechaYHora formFecha = new FFechaYHora();
                    DialogResult resultadoFecha = formFecha.ShowDialog();

                        DateTime fecha = formFecha.Fecha;
                        formFecha.Dispose();
                       Movimiento movimiento= ln.LNMovimiento.LeerMovimiento(cuenta, fecha);
                        if(movimiento != null)
                        {
                            FMovimientoDatos fMovimientoDatos = new FMovimientoDatos(movimiento);
                            fMovimientoDatos.Show();
                        }
                    else
                    {
                        MessageBox.Show("No hay un movimiento de esa cuenta a esa hora.");
                        return;
                    }
                     

                }
                else
                {
                    MessageBox.Show("No se encontró una cuenta con ese IBAN.");
                    return;

                }
            }           
        }

        private void movimientosDeUnaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cuenta);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string iban = formClave.Clave;
                formClave.Dispose();

                Cuenta cuenta = ln.LNCuenta.LeerCuenta(new Cuenta(iban, TipoCuenta.Oro, 0, DateTime.MinValue, EstadoCuenta.Abierta));

                if (cuenta != null)
                {
                    List<Movimiento> movimientos = ln.LNMovimiento.MovimientosCuenta(cuenta);

                    if (movimientos != null && movimientos.Count > 0)
                    {
                        FListadoMovimientos formListado = new FListadoMovimientos($"Movimientos de la cuenta {iban}", movimientos);
                        formListado.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontraron movimientos para esta cuenta.",
                            "Movimientos de Cuenta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                       "No se encontró una cuenta con el IBAN proporcionado.",
                       "Error de Cuenta",
                       MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                   );
                }
            }
        }


        private void movimientosDeUnClienteEnUnaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave;
                formClave.Dispose();
                Cliente cliente=ln.LNCliente.LeerClientePorDNI(dni);
               

                if (cliente != null)
                {
                    Fclave formClaveCuenta = new Fclave(TipoFormularioClave.Cuenta);
                    DialogResult resultadoCuenta = formClaveCuenta.ShowDialog();

                    if (resultadoCuenta == DialogResult.OK)
                    {
                        string iban = formClaveCuenta.Clave;
                        formClaveCuenta.Dispose();
                        Cuenta cuenta=ln.LNCuenta.LeerCuentaPorIBAN(iban);
                       
                        if (cuenta != null)
                        {
                            List<Movimiento> movimientos = ln.LNMovimiento.MovimientosCuenta(cuenta);

                            if (movimientos.Count > 0)
                            {
                                FListadoMovimientos formListado = new FListadoMovimientos($"Movimientos del cliente {dni} en la cuenta {iban}", movimientos);
                                formListado.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontraron movimientos para este cliente en la cuenta seleccionada.",
                                    "Movimientos de Cliente en Cuenta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontró la cuenta con el IBAN proporcionado.",
                                "Error de Cuenta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró un cliente con el DNI proporcionado.",
                        "Error de Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void clienteQueHaRealizadoMovimientoConIDIntroducidaToolStripMenuItem_Click(object sender, EventArgs e) 
        {

            Fclave formClave = new Fclave(TipoFormularioClave.Cuenta);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string iban = formClave.Clave;
                formClave.Dispose();
                Cuenta cuenta=ln.LNCuenta.LeerCuentaPorIBAN(iban);  


                if (cuenta != null)
                {  


                    FFechaYHora formFecha = new FFechaYHora();
                    DialogResult resultadofecha = formFecha.ShowDialog();
                   

                    if (resultadofecha == DialogResult.OK)
                    {
                        DateTime fechaSeleccionada = formFecha.Fecha;
                        formFecha.Dispose(); 

                        Movimiento movimiento=ln.LNMovimiento.MovimientoPorFechaYCuenta(fechaSeleccionada,iban);
                        FClienteDatos form = new FClienteDatos(movimiento.Cliente.DNI, movimiento.Cliente.Nombre, ln);
                        form.Show();



                    }
                    else
                     {
                            MessageBox.Show(
                                "ERROR DE FECHA",
                                "Error de FECHA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                    }
                }
            }
                else
                {
                    MessageBox.Show(
                        "No se encontró una cuenta con ese IBAN.",
                        "Error de Cuenta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            
          
        }

        private void recorridoUnoAUnoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = ln.LNCuenta.CuentasBanco();  
            List<Movimiento> todosLosMovimientos = new List<Movimiento>();

            foreach (Cuenta cuenta in cuentas)
            {
                List<Movimiento> movimientosCuenta = ln.LNMovimiento.MovimientosCuenta(cuenta); 
                todosLosMovimientos.AddRange(movimientosCuenta);  
            }


            FRecorridoMovimiento formRecorrido = new FRecorridoMovimiento(todosLosMovimientos);
            formRecorrido.ShowDialog();
        }




        /// <summary>
        /// Muestra el listado de movimientos.
        /// </summary>
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Movimiento> movimientos = ln.LNMovimiento.ObtenerMovimientos();
            FListadoMovimientos formListado=new FListadoMovimientos("Movimientos", movimientos);
          
            formListado.Show();
        }


        /// <summary>
        /// Abre un formulario para dar de alta a un nuevo cliente.
        /// </summary>
        protected void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave; 
                if ( !ln.LNCliente.ExisteClientePorDNI(dni))
                {
                   formClave.Dispose();
                    FAltaCliente fAltaCliente = new FAltaCliente(dni, ln); 
                    fAltaCliente.Show();
                }
                else
                {
                    DialogResult existe = MessageBox.Show("Ya existe un cliente con ese DNI\\¿Quieres introducir otro?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (existe == DialogResult.Yes)
                    {
                        altaClienteToolStripMenuItem.PerformClick();
                    }
                    else if (existe == DialogResult.No)
                    {
                        
                    }
                }
            }
        }
        /// <summary>
        /// Abre un formulario para dar de baja a un cliente.
        /// </summary>
        protected void bajaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cliente);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string dni = formClave.Clave; 
                if (!ln.LNCliente.ExisteClientePorDNI(dni))
                {
                    DialogResult existe = MessageBox.Show("No existe un cliente con ese DNI\\¿Quieres introducir otro?", "",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (existe == DialogResult.Yes)
                    {
                        bajaClienteToolStripMenuItem.PerformClick();
                    }
                    else if (existe == DialogResult.No)
                    {

                    }
                }
                else
                {

                    FEstasSeguro fEstasSeguro = new FEstasSeguro();
                    DialogResult resultado2= fEstasSeguro.ShowDialog();
                    if(resultado2 == DialogResult.OK)
                    {
                        Cliente c = ln.LNCliente.LeerClientePorDNI(dni);
                        LNClienteAdmin lnad = (LNClienteAdmin)ln.LNCliente; 
                        lnad.DarDeBajaCliente(c);
                        MessageBox.Show("Has eliminado al cliente" + c.Nombre + " " + c.Apellido + " y sus cuentas");

                    }
                    else
                    {
                        fEstasSeguro.Close();
                    }




                }
            }
        }
        /// <summary>
        /// Abre un formulario para crear una nueva cuenta.
        /// </summary>
        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclave formClave = new Fclave(TipoFormularioClave.Cuenta);
            DialogResult resultado = formClave.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string iban = formClave.Clave; // IBAN introducido
                formClave.Dispose();

             
                if (!ln.LNCuenta.ExisteCuentaPorIBAN(iban))
                {
                   
                    FCrearCuenta fCrearCuenta=new FCrearCuenta(iban, ln);
                    fCrearCuenta.Show();
                }
                else
                {
                    DialogResult resultadoNuevo = MessageBox.Show(
                        "¿Quieres introducir otro IBAN?",
                        "Ya existe una cuenta con ese IBAN",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultadoNuevo == DialogResult.Yes)
                    {
                        crearCuentaToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }
        /// <summary>
        /// Muestra el listado de clientes ordenados por saldo.
        /// </summary>
        private void listadoOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = ln.LNCliente.ClientesBanco();

            List<(Cliente cliente, decimal saldo)> listaClientes = new List<(Cliente cliente, decimal saldo)>();


            foreach (Cliente cliente in clientes)
            {
                decimal saldo = obtenerSaldo(cliente);
                listaClientes.Add((cliente, saldo));
            }

            FListadoClientesOrdenado formListado = new FListadoClientesOrdenado(listaClientes, ln);
            formListado.Show();
        }










        //METODOS BASURA RECORDAR BORRARLOS
        /// <summary>
        /// Maneja el evento de clic en el menú de búsqueda (busquedaToolStripMenuItem1).
        /// </summary>
        private void busquedaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Maneja el evento de clic en el menú de búsqueda (busquedaToolStripMenuItem1).    retirar metodos basura 
        /// </summary>
        private void busquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de carga del formulario de empleados (PREmpleado).
        /// </summary>
        private void PREmpleado_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Maneja el evento de clic en el menú de cuentas (cuentasToolStripMenuItem).
        /// Este método debería ser eliminado ya que no tiene implementación.
        /// </summary>
        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Maneja el evento de clic en el menú de clientes (clientesToolStripMenuItem).
        /// Este método debería ser eliminado ya que no tiene implementación.
        /// </summary>
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Maneja el evento de clic en el menú de búsqueda (busquedaToolStripMenuItem).
        /// Este método debería ser eliminado ya que no tiene implementación.
        /// </summary>
        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)//borrar
        {

        }
        /// <summary>
        /// Maneja el evento de clic en el menú de búsqueda por día y tipo de cuenta (porDiaYTipoDeCuentaToolStripMenuItem).
        /// Este método debería ser eliminado ya que no tiene implementación.
        /// </summary>
        private void porDiaYTipoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

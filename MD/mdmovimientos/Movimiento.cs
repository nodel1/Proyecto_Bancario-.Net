using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.MDMovimientos
{
    /// <summary>
    /// Representa un movimiento financiero realizado en una cuenta.
    /// </summary>
    public abstract class Movimiento
    {
        //transferencia: IBAN y concepto
        //Recibo: IBAN y referencia 
        //Movimiento tiene que tener solo los atributos comunes a todos
        //Hay que hacer diagrama de modelo de dominio para ver cómo diseñamos
        //Debe ser abstracta

        private DateTime fecha;
        private EstadoMovimiento estado;
        private decimal importe;
        private Cuenta cuenta;
        private string empleadoresponsable;
        private Cliente cliente;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Movimiento con los parámetros especificados.
        /// </summary>
        /// <param name="fecha">La fecha en la que se realizó el movimiento.</param>
        /// <param name="estado">El estado del movimiento.</param>
        /// <param name="importe">El importe del movimiento.</param>
        /// <param name="cuenta">La cuenta asociada al movimiento.</param>
        /// <param name="Empleadoresponsable">El nombre del empleador responsable del movimiento.</param>
        /// <param name="cliente">El cliente asociado al movimiento.</param>
        public Movimiento(DateTime fecha, EstadoMovimiento estado, decimal importe, Cuenta cuenta, string Empleadoresponsable, Cliente cliente)
        {
            this.Fecha = fecha;
            this.Estado = estado;
            this.Importe = importe;
            this.Cuenta = cuenta;
            this.empleadoresponsable = Empleadoresponsable;
            this.Cliente = cliente;
        }

        /// <summary>
        /// Obtiene o establece la fecha del movimiento.
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        /// <summary>
        /// Obtiene o establece el estado del movimiento.
        /// </summary>
        public EstadoMovimiento Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Obtiene o establece el importe del movimiento.
        /// </summary>
        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        /// <summary>
        /// Obtiene o establece la cuenta asociada al movimiento.
        /// </summary>
        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del empleador responsable del movimiento.
        /// </summary>
        public string EmpleadoResponsable
        {
            get { return this.empleadoresponsable; }
            set { empleadoresponsable = value; }
        }

        /// <summary>
        /// Obtiene o establece el cliente asociado al movimiento.
        /// </summary>
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}

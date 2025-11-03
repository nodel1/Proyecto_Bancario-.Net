using MD.MDActores;
using MD.MDCliente;
using MD.MDCuenta;
using MD.MDMovimientos;
using Persistencia.BDs.PersistenciaMovimiento;
using Persistencia.BDs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

internal class MovimientoDato : Entity<MovimientoDatoClave>
{
    private DateTime fecha;
    private string estado;
    private decimal importe;
    private string concepto;
    private string iban_destino;
    private string referencia_recibo;
    private string cuenta;
    private string id_emp;
    private string cliente;
    private string tipomovimiento;

    /// <summary>
    /// Inicializa una nueva instancia de la clase MovimientoDato.
    /// </summary>
    /// <param name="Fecha">La fecha del movimiento.</param>
    /// <param name="Estado">El estado del movimiento.</param>
    /// <param name="Importe">El importe del movimiento.</param>
    /// <param name="Concepto">El concepto o descripción del movimiento.</param>
    /// <param name="IBAN_Destino">El IBAN del destino del movimiento.</param>
    /// <param name="Referencia_Recibo">La referencia del recibo asociado.</param>
    /// <param name="Cuenta">La cuenta asociada al movimiento.</param>
    /// <param name="Id_Emp">El ID del empleado responsable del movimiento.</param>
    /// <param name="Cliente">El ID del cliente asociado al movimiento.</param>
    /// <param name="TipoMovimiento">El tipo de movimiento (por ejemplo, ingreso, retiro, etc.).</param>
    public MovimientoDato(DateTime Fecha, string Estado, decimal Importe, string Concepto, string IBAN_Destino, string Referencia_Recibo,
        string Cuenta, string Id_Emp, string Cliente, string TipoMovimiento) : base(new MovimientoDatoClave(Fecha, Cuenta))
    {
        this.fecha = Fecha;
        this.estado = Estado;
        this.importe = Importe;
        this.concepto = Concepto;
        this.iban_destino = IBAN_Destino;
        this.referencia_recibo = Referencia_Recibo;
        this.cuenta = Cuenta;
        this.id_emp = Id_Emp;
        this.cliente = Cliente;
        this.tipomovimiento = TipoMovimiento;
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
    public string Estado
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
    /// Obtiene o establece el concepto o descripción del movimiento.
    /// </summary>
    public string Concepto
    {
        get { return concepto; }
        set { concepto = value; }
    }

    /// <summary>
    /// Obtiene o establece el IBAN del destino del movimiento.
    /// </summary>
    public string IBAN_Destino
    {
        get { return iban_destino; }
        set { iban_destino = value; }
    }

    /// <summary>
    /// Obtiene o establece la referencia del recibo asociado al movimiento.
    /// </summary>
    public string Referencia_Recibo
    {
        get { return referencia_recibo; }
        set { referencia_recibo = value; }
    }

    /// <summary>
    /// Obtiene o establece la cuenta asociada al movimiento.
    /// </summary>
    public string Cuenta
    {
        get { return cuenta; }
        set { cuenta = value; }
    }

    /// <summary>
    /// Obtiene o establece el ID del empleado responsable del movimiento.
    /// </summary>
    public string EmpleadoResponsable
    {
        get { return id_emp; }
        set { id_emp = value; }
    }

    /// <summary>
    /// Obtiene o establece el ID del cliente asociado al movimiento.
    /// </summary>
    public string Cliente
    {
        get { return cliente; }
        set { cliente = value; }
    }

    /// <summary>
    /// Obtiene o establece el tipo de movimiento (por ejemplo, ingreso, retiro, etc.).
    /// </summary>
    public string TipoMovimiento
    {
        get { return tipomovimiento; }
        set { tipomovimiento = value; }
    }
}

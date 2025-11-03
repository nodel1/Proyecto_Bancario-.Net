using LN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Clase que representa la ventana del administrador en la aplicación.
    /// Hereda de PREmpleado y usa LN.LNAdmin para la lógica de negocio.
    /// </summary>
    public partial class PRAdministrador : PREmpleado
    {
        /// <summary>
        /// Constructor que inicializa la ventana del administrador.
        /// </summary>
        /// <param name="lnAdministrador">Instancia de LN.LNAdmin que maneja la lógica de negocio.</param>
        public PRAdministrador(LN.LNAdmin lnAdministrador) : base(lnAdministrador)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga el formulario.
        /// </summary>
        private void PRAdministrador_Load(object sender, EventArgs e)
        {
            // Aquí se pueden agregar inicializaciones o configuraciones al cargar el formulario.
        }
    }
}

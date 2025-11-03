using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistencia
{
    /// <summary>
    /// Clase que contiene el punto de entrada principal para la aplicación.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación. 
        /// Inicia la aplicación de Windows Forms.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita los estilos visuales para la aplicación
            Application.EnableVisualStyles();

            // Configura la compatibilidad con el texto de la interfaz
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecuta el formulario principal de la aplicación
            Application.Run(new Form1());
        }
    }
}

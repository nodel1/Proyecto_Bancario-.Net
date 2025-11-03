using MD.MDCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    /// <summary>
    /// Clase interna que transforma objetos entre las clases Cliente y ClienteDato.
    /// </summary>
    internal class TranformerCliente
    {
        /// <summary>
        /// Convierte un objeto Cliente en un objeto ClienteDato.
        /// </summary>
        /// <param name="cliente">El cliente que se desea transformar.</param>
        /// <returns>Un objeto ClienteDato que representa al cliente.</returns>
        public static ClienteDato ClienteAClienteDato(Cliente cliente)
        {
            return new ClienteDato(cliente.DNI, cliente.Nombre, cliente.Apellido, cliente.Email);
        }

        /// <summary>
        /// Convierte un objeto ClienteDato en un objeto Cliente.
        /// </summary>
        /// <param name="clienteDato">El ClienteDato que se desea transformar.</param>
        /// <returns>Un objeto Cliente que representa los datos del ClienteDato.</returns>
        public static Cliente ClienteDatoACliente(ClienteDato clienteDato)
        {
            return new Cliente(clienteDato.Nombre, clienteDato.Apellido, clienteDato.Id, clienteDato.Email);
        }
    }
}

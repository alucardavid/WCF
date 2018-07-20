using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDao
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            var resultado = clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            return resultado;
        }
    }
}

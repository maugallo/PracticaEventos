using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClienteNegocio
    {
        public List<Cliente> MockUp()
        {
            List<Cliente> lista = new List<Cliente>();

            Cliente cliente1 = new Cliente(1, "Facundo", "Hernandez", 20, "Argentina", "Masculino", false, DateTime.Now);
            lista.Add(cliente1);
            Cliente cliente2 = new Cliente(2, "Agustina", "Rodriguez", 25, "Argentina", "Femenino", true, DateTime.Now);
            lista.Add(cliente2);

            return lista;
        }
    }
}

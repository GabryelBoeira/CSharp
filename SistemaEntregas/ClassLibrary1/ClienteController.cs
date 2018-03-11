using modelos;
using System.Collections.Generic;
using System.Linq;

namespace controller
{
    public class ClienteController
    {
        // São divididas em três Partes uma query LINQ:
        //  1. Uma lista de dados.
        static List<Cliente> MeusCliente = new List<Cliente>();

        //adiciona cliente 
        public void SalvarClientes(Cliente cliente) => MeusCliente.Add(cliente);

        //pesquisa cliente pelo nome
        public Cliente PesquisarCliente(string nomeCliente) {
            // 2.Cria a Query.
            // custQuery e o IEnumerable<Cliente>
            var queryCustomers =
               from cust in MeusCliente
               where cust.Nome == nomeCliente
               orderby cust.Nome ascending
               select cust;
            // 3. Query .
            foreach (Cliente cust in queryCustomers)
            {
                if (cust != null) {
                    return cust;
                }
                else {
                    return null;
                }
               
            }
            return null;
        }

    }
}

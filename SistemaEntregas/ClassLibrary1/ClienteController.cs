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
        static int ultimoID;

        //adiciona cliente 
        public void SalvarClientes(Cliente cliente) {
            int tamanho = ultimoID +1;
            ultimoID = tamanho;           
            cliente.PessoaID = tamanho;
            MeusCliente.Add(cliente);          
        }

        //pesquisa cliente pelo nome
        public Cliente PesquisarCliente(string nomeCliente) {
            // 2.Cria a Query.
            // custQuery e o IEnumerable<Cliente>
            var queryCustomers =
               from cust in MeusCliente
               //converções
               where cust.Nome.ToLower().Equals(nomeCliente.Trim().ToLower())
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

        //pesquisa cliente por id
        public Cliente PesquisarClienteId(int idCliente) {
            // 2.Cria a Query.
            // custQuery e o IEnumerable<Cliente>
            var queryCustomers =
               from cust in MeusCliente
                   //converções
               where cust.PessoaID == idCliente
               orderby cust.Nome ascending
               select cust;
            // 3. Query .

            foreach (Cliente cust in queryCustomers)
            {
                if (cust != null)
                {
                    return cust;
                }
                else
                {
                    return null;
                }
            }
            return null;

        }

        //Remover Cliente pelo id
        public bool ExcluirCliente(int idCliente) {
            Cliente cliente = PesquisarClienteId(idCliente);
            if (cliente == null) {
                return false;
            }
            else
            {
                MeusCliente.Remove(cliente);
                return true;
            }

        }

        //lista com todos os clientes
        public List<Cliente> ListarCliente()
        {
            return MeusCliente;

        }
    }
}

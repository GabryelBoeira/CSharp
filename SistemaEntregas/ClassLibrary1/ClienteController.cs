using modelos;
using System.Collections.Generic;
using System.Linq;
using modelos.dao;
using Controller;
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
            Contexto ctx = new Contexto();



            int tamanho = ultimoID + 1;
            ultimoID = tamanho;
            cliente.PessoaID = tamanho;
            MeusCliente.Add(cliente);
        }

        //pesquisa cliente pelo nome
        public Cliente PesquisarCliente(string nomeCliente) {
            // 2.Cria a Query.

            ContextoSingleton
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
            //conexao
            Contexto ctx = new Contexto();
            //pesquisa
            return ctx.Clientes.Find(idCliente);    

        }

        //Remover Cliente pelo id
        public bool ExcluirCliente(int idCliente) {
            Contexto ctx = new Contexto();
            Cliente cliente = ctx.Clientes.Find(idCliente);
            return true;
        }

        //lista com todos os clientes
        public List<Cliente> ListarCliente() {
            Contexto ctx = new Contexto();
            return ctx.Clientes.ToList();
        }

        //altera os dados 
        public void AlterarCliente(Cliente cliente)
        {
            Cliente clienteEditar = PesquisarClienteId(cliente.PessoaID);
            if (clienteEditar != null) {

                clienteEditar.Nome = cliente.Nome;
                clienteEditar.Cpf = cliente.Cpf;
                ContextoSingleton.Instancia.Entry(clienteEditar).State = System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();

            }
        } 

    }
}

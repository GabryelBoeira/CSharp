using modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        //para casos onde não a mudança nas variaveis 
        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            Limpar = 5,
            sair = 6
        }

        //tela com o menu 
        private static OpcoesMenuPrincipal MenuCliente()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("-- Clientes --");
            Console.WriteLine("1 - Cadastro de Cliente");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("- geral -");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6 - Sair");
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);

        }

        //tela para o cadastro de clientes 
        private static Cliente CadastrarCliente()
        {
            Console.Clear();
            Cliente cliente = new Cliente();
            cliente._Endereco = new Endereco();

            Console.WriteLine("Nome do Cliente: " + "\n");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("CPF: " + "\n");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("-Endereço- " + "\n");

            Console.WriteLine("Rua: ");
            cliente._Endereco.Rua = Console.ReadLine();

            Console.WriteLine("Numero: ");
            cliente._Endereco.Numero = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Complento: ");
            cliente._Endereco.complemento = Console.ReadLine();
            return cliente;
        }

        //mostra dados inseridos pelo usuario na CadastrarCliente()
        private static void ExibirDadosCliente(Cliente cliente) {
            Console.Clear();
            Console.WriteLine("-- Dados do cliente --");

            Console.WriteLine("ID do Cliente: " + cliente.PessoaID);
            Console.WriteLine("Nome do Cliente: " + cliente.Nome);
            Console.WriteLine("Cpf do Cliente: " + cliente.Cpf);
            Console.WriteLine("- Endereço - ");
            Console.WriteLine("Rua : " + cliente._Endereco.Rua);
            Console.WriteLine("Número: " + cliente._Endereco.Numero);
            Console.WriteLine("Complemento: " + cliente._Endereco.complemento);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.sair;
            do {
               
                opcaoDigitada = MenuCliente();
                switch (opcaoDigitada)                    
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        c = CadastrarCliente();

                        ExibirDadosCliente(c);
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:                       
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        Console.WriteLine("Nome do Cliente: " + "\n");
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        Console.WriteLine("Nome do Cliente: " + "\n");
                        break;
                    case OpcoesMenuPrincipal.Limpar:
                        Console.Clear();
                        break;
                    case OpcoesMenuPrincipal.sair:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Nome do : " + "\n");
                        break;
                }
                MenuCliente();
            } while (opcaoDigitada == OpcoesMenuPrincipal.sair);
                 
       {

            }
           

        }
    }
}

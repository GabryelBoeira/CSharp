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
        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            Limpar = 4,
            sair = 5
        }

        private static OpcoesMenuPrincipal MenuCliente()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("-- Clientes --");
            Console.WriteLine("1 - Cadastro de Cliente");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("- geral -");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair");
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);

        }

        private static Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            cliente._Endereco = new Endereco();

            Console.WriteLine("Nome do Cliente: "+"\n");     
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("CPF: "+"\n");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("-Endereço- "+"\n");

            Console.WriteLine("Rua: " );
            cliente._Endereco.Rua = Console.ReadLine();

            Console.WriteLine("Numero: ");
            cliente._Endereco.Numero = 2;

            Console.WriteLine("Complento: ");
            cliente._Endereco.complemento = Console.ReadLine();

            return cliente;
        }


        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.sair;
            do {
                opcaoDigitada = MenuCliente();
                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        CadastrarCliente();
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        Console.WriteLine("Nome do Cliente: " + "\n");
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        Console.WriteLine("Nome do Cliente: " + "\n");
                        break;
                    case OpcoesMenuPrincipal.Limpar:
                        Console.WriteLine("Nome do Cliente: " + "\n");
                        break;
                    case OpcoesMenuPrincipal.sair:
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Nome do : " + "\n");
                        break;
                }
            } while (opcaoDigitada == OpcoesMenuPrincipal.sair);
                 
       {

            }
           

        }
    }
}

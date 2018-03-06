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
            CadastrarCliente,
            PesquisarCliente,
            EditarCliente,
            Limpar,
            sair
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
            //Converter para int
            //return Convert.ToInt32(Console.ReadLine());
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);

        }

        private static Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Nome do Cliente: "+"\n");     
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("CPF: "+"\n");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("Endereço: " + "\n");
            cliente._Endereco.complemento = Console.ReadLine();

           Console.WriteLine("Complento: " + "\n");
           cliente._Endereco.complemento = Console.ReadLine();


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
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        break;
                    case OpcoesMenuPrincipal.Limpar:
                        break;
                    case OpcoesMenuPrincipal.sair:
                        break;
                    default:
                        break;
                }
            } while (opcaoDigitada == OpcoesMenuPrincipal.sair);




              

    {

            }
           

        }
    }
}

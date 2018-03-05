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
        private static int MenuCliente()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("-- Clientes --");
            Console.WriteLine("1 - Cadastro de Cliente");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int opcaoDigita = MenuCliente();

            switch (opcaoDigita)            {

                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("Limpado");
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("saindo");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Digito Errado");
                    break;
            }
            Console.WriteLine("- geral -");
           

        }
    }
}

using System;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            
            Console.WriteLine("Digite seu nome");
            p.nome = Console.ReadLine();
            Console.WriteLine("Ola" + p.nome);
            Console.ReadKey();


        }
        }
    }

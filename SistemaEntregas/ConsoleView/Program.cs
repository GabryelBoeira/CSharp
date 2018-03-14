﻿using modelos;
using System;
using controller;
using System.Collections.Generic;

namespace ConsoleView
{
    class ViewPrincipal
    {
        public static ClienteController ccontrol = new ClienteController();

        //para casos onde não a mudança nas variaveis 
        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            ListarCliente = 5,
            Limpar = 6,
            sair = 7
        }

        static void Main(string[] args)
        {
            //Intaciamento padrão para as classes 
            Cliente c = new Cliente();
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.sair;
            
            do {
                opcaoDigitada = MenuCliente();
                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        c = CadastrarCliente();
                        ccontrol.SalvarClientes(c);
                        ExibirDadosCliente(c);
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        Console.WriteLine("EditarCliente: " + "\n");
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.Limpar:
                        Console.Clear();
                        break;
                    case OpcoesMenuPrincipal.ListarCliente:
                        ListarCliente();
                        ;
                        break;
                    case OpcoesMenuPrincipal.sair:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Nome do : " + "\n");
                        break;
                }
                
            } while (opcaoDigitada != OpcoesMenuPrincipal.sair);
        }

        //tela com o menu 
        private static OpcoesMenuPrincipal MenuCliente() {
            Console.Clear();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("-- Clientes --");
            Console.WriteLine("1 - Cadastro de Cliente");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("5 - Listar todos os clientes");
            Console.WriteLine("- geral -");
            Console.WriteLine("6 - Limpar Tela");
            Console.WriteLine("7 - Sair");
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
        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("-- Dados do cliente --");
            Console.WriteLine("ID do Cliente: " + cliente.PessoaID);
            Console.WriteLine("Nome do Cliente: " + cliente.Nome);
            Console.WriteLine("Cpf do Cliente: " + cliente.Cpf);
            Console.WriteLine("- Endereço - ");
            Console.WriteLine("Rua : " + cliente._Endereco.Rua);
            Console.WriteLine("Número: " + cliente._Endereco.Numero);
            Console.WriteLine("Complemento: " + cliente._Endereco.complemento);
            Console.WriteLine("Aperte qualquer Tecla para continuar");
            Console.ReadKey();

        }

        //Pesquisa Cliente Cadastrado

        private static void PesquisarCliente() {
            string nomeCliente;
            Cliente cliente = new Cliente();

            Console.Clear();
            Console.Write("Nome do Cliente: ");
            nomeCliente = Console.ReadLine();

            cliente = ccontrol.PesquisarCliente(nomeCliente);

            if (cliente != null) {
                ExibirDadosCliente(cliente);
            }
            else {
                Console.WriteLine("Cliente não encontrado" + "\n");
            }
        }

        //editar Cliente
        private static void EditarCliente()
        {
        }

        //excluir Cliente
        private static void ExcluirCliente()
        {
            int idCliente;

            Console.Clear();
            Console.Write("Id do Cliente para exclusão: ");
            idCliente = int.Parse(Console.ReadLine());

            if (ccontrol.ExcluirCliente(idCliente))
            {
                Console.WriteLine("Cliente Excluido " + "\n");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado" + "\n");
            }

        }

        //lista com todos os clientes
        private static void ListarCliente() {

            List<Cliente> clientes = ccontrol.ListarCliente();
            foreach (Cliente dados in clientes)
            {
                Console.WriteLine("Nome: "+ dados.Nome);
            }
            Console.WriteLine("Aperte qualquer Tecla para continuar");
            Console.ReadKey();
        }
       

    }
}

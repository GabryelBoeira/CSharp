﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }   
        

        private void VoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            Close();
            menu.Show();
        }

        private void SalvarCliente_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            Close();
            menu.Show();
        }
    }
}
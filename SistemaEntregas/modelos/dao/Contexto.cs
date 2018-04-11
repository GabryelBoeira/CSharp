using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelos.dao
{
    public class  Contexto : DbContext 
    {
        public Contexto() : base("stringConn")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Entregador> Entregadores { get; set; }
        public int MyProperty { get; set; }


    }
}

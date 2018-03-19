using modelos;
using System.Linq;
using System.Collections.Generic;

namespace Controller
{
    public class EnderecoController
    {

        public static List<Endereco> ListaEndereco = new List<Endereco>();
        static int ultimoID = 0;

        public int SalvarEndereco(Endereco endereco)
        {
            int tamanho = ultimoID + 1;
            ultimoID = tamanho;
            endereco.enderecoID = tamanho;
            ListaEndereco.Add(endereco);
            return tamanho;

        }

        public Endereco BuscaEndereco(int nm_endereco)
        {
            var query =
                from end in ListaEndereco
                where end.enderecoID.Equals(nm_endereco)
                select end;

            foreach (var end in ListaEndereco)
            {
                return end;
            }

            return null;
        }


        
    }
}

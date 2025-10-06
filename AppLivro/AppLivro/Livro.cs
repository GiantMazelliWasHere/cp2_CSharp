using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLivro
{
    internal class Livro
    {
        protected string titulo;
        protected string autor;
        protected int anoPublicacao;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{titulo} - {autor}");
        }
    }
}

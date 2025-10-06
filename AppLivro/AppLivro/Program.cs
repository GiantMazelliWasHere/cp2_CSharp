using AppLivro;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1984 = new Livro("1984", "George Orwell", 1949);

            livro1984.ExibirInformacoes();
        }
    }
}
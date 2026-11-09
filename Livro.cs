using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "Indefinido";
            Autor = "Indefinido";
            NumeroPaginas = 0;
            Console.WriteLine("Iniciando Livro com propriedades padrões: Titulo, Autor e N paginas");
        }
        public Livro(string Titulo)
        {
            this.Titulo = Titulo;
            Autor = "Indefinido";
            NumeroPaginas = 0;
            Console.WriteLine("Iniciando Livro com propriedades padrões: Autor e N Paginas");
        }
        public Livro(string Titulo, string Autor)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            NumeroPaginas = 0;
            Console.WriteLine("Iniciando Livro com propriedade padrão: N de paginas");
        }
        public Livro(string Titulo, string Autor, int nPaginas)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.NumeroPaginas = nPaginas;
        }
        public void exibir(){
        Console.WriteLine($" Titulo: {this.Titulo}\n Autor: {this.Autor}\n Numero de Paginas: {this.NumeroPaginas}");
        }
    }
}
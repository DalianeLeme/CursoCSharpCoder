using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {

        public static void Executar()
        {
            int id = (int)Genero.Acao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 18";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine($"{filmeParaFamilia.Titulo} é {filmeParaFamilia.GeneroDoFilme}");


        }
    }
}


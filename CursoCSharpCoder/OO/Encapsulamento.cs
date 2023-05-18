using Encapsulamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Não Reconhecido");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(NumeroCelular);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public new void MeusAcessos()
        {
            Console.WriteLine("Amigo Distante");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}

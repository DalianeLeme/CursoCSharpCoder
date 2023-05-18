using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class Struct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 3;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine($"X = {coordenadaInicial.X}");
            Console.WriteLine($"Y = {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(8, 5);
            coordenadaFinal.MoverNaDiagonal(13);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine($"X = {coordenadaFinal.X}");
            Console.WriteLine($"Y = {coordenadaFinal.Y}");
        }
    }
}

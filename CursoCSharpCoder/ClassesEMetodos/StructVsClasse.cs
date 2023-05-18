﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }

        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por Valor
            ponto1.X = 3;

            Console.WriteLine($"Ponto 1 X: {ponto1.X}");
            Console.WriteLine($"Cópia Ponto 1 X: {copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 2, Y = 1 };
            CPonto copiaPonto2 = ponto2; // Atribuição por Referencia
            ponto2.X = 1;

            Console.WriteLine($"Ponto 2 X: {ponto2.X}");
            Console.WriteLine($"Cópia Ponto 2 X: {copiaPonto2.X}");

        }
    }
}

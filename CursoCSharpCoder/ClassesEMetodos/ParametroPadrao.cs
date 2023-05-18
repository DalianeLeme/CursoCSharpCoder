﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }

        public static void Executar()
        {
            int resultado1 = Somar(10, 23);
            Console.WriteLine(resultado1);

            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action<string> algoNoConsole = (a) =>
            {
                Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole("!!!!");

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHexa = numero => numero.ToString("X");
            Console.WriteLine(conversorHexa(123));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

            Console.WriteLine(formatarData(6, 2, 2023));

        }
    }
}

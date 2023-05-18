using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class MetodosComRetorno
    {
        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            // Podem coexistir:
            // public int Somar(int c, int d, int e)
            // {
            //     return c + d;
            // }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }

        class CalculadoraCadeia
        {
            int memoria;

            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado()
            {
                return memoria;
            }
        }

        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(1, 2);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(8, 4));
            Console.WriteLine(calculadoraComum.Multiplicar(6, 7));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(4).Imprimir().Limpar().Imprimir(); //3 vai multiplicar com 4, imprimir no console o 12, limpar o valor de memoria colocando 0 e imprimir o valor 0

            resultado = calculadoraCadeia.Somar(2).Multiplicar(5).Resultado();
            Console.WriteLine(resultado);
        }
    }
}

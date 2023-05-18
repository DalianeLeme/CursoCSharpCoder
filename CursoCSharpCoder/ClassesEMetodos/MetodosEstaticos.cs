using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    public class CalculadoraEstatica
    {

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            // Método estático, não precisa da instância
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine($"Resultado: {resultado}");

            // Com instância, método não estático
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 5));

        }
    }
}


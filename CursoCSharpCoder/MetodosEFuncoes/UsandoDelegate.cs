using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }
        
        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(5, 7));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(9, 3);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(6, 4));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(5, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            double _desconto = 0.1;

            string nome;
            public string Nome
            {
                get
                {
                    return "Opcional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }

            // Propriedade autoimplementaad
            public double Preco { get; set; }

            // Somente leitura, somente get
            public double PrecoComDesconto
            {
                // get => Preco - (desconto * Preco); -- Lambda
                get
                {
                    return Preco - (_desconto * Preco);
                }
            }

            public CarroOpcional()
            {

            }

            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 5987.6);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 4879.63;

            Console.WriteLine(op2.Nome);
            Console.WriteLine($"Preço sem desconto: {op2.Preco}");
            Console.WriteLine($"Preço com desconto: {op2.PrecoComDesconto}");
        }
    }
}

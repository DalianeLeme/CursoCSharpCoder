using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //  Vai acelerar de 5 em 5
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        // Frear -5
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        // Pega o construtor da classe pai e coloquei a velocidade máxima como 200 para o uno
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        // Pega o construtor da classe pai e coloquei a velocidade máxima como 350 para a ferrari
        public Ferrari() : base(350)
        {

        }

        // Ferrari vai acelerar de 15 em 15 por ser mais rápida que o uno
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe pai, não precisa do marcador virtual
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    public class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            // Como o tipo é Carro, vai usar o método Frear  de Carro
            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

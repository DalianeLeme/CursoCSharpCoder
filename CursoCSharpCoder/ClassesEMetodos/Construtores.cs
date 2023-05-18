using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    class Construtores
    {
        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }

            public Carro()
            {
                //Construtor Padrão
            }
        }

        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "Ford Ka";
            carro1.Fabricante = "Ford";
            carro1.Ano = 2022;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("1234", "BMW", 2015);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2007
            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
        }
    }
}

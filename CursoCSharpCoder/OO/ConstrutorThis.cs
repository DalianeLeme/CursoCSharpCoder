﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.OO
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine(nome);
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        //    public override string ToString()
        //    {
        //        return $"{Nome} tem {Altura}cm de altura!";
        //    }
        //}
    }

    public class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString());
        }
    }
}

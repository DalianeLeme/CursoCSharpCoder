using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }

    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(2000, 2, 6));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Conversão explicita
            double nota = 9.7;
            int notaTrucada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTrucada}");

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado 1: {numero}");

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2 : {numero2}");

        }
    }
}

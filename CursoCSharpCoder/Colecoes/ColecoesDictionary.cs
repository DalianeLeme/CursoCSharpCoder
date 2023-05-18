using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem aranha");
            filmes.Add(2004, "Os incriveis");
            filmes.Add(2006, "O grande truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine($"2004: {filmes[2004]}");
                //Console.WriteLine($"2004: {filmes.GetValueOrDefault(2004)}");


                Console.WriteLine(filmes.ContainsValue("Amnésia"));

                Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

                filmes.TryGetValue(2006, out string filme2006);
                Console.WriteLine($"Filme: {filme2006}");

                // Percorrendo as chaves
                foreach (var chave in filmes.Keys)
                {
                    Console.WriteLine(chave);
                }

                // Percorrendo os valores
                foreach (var valor in filmes.Values)
                {
                    Console.WriteLine(valor);
                }

                // Percorrendo chaves e valores - Maneira mais complicada
                foreach (KeyValuePair<int, string> filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                }

                // Percorrendo chaves e valores - Maneira mais simples, var vai identificar que é um KeyValuePair
                foreach (var filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                }

            }
        }
    }
}

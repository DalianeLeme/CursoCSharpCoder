using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {numero}");

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"{i} é o número que queremos?");
                if (i == numero)
                {
                    Console.WriteLine("Simm!");
                    break;
                }
                else
                    Console.WriteLine("Não");
            }
        }
    }
}

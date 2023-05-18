using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpCoder.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach (object item in arrayList)
            {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}

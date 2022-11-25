using System;
using System.Linq;

namespace Krypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Krypteringssträng ? ");
            string krypteringsträng = Console.ReadLine();
            string[] array = krypteringsträng.Select(q => new string(q, 1)).ToArray();


            int lösningar = 0; 

            for (int i = 0; i <= array.Length; i++) // innanför denna forloop kollar dubbelsiffriga nummer om de är under 30
            {
                if (i < array.Length - 1)
                {
                    int x = i + 1;
                    int test = int.Parse(array[i] + array[x]);
                    Console.WriteLine(test);
                    if (test <= 29)
                    {
                        lösningar++;
                    }
                }


            }
            int y = lösningar;
            for (int i = 0; i < y; i++)
            {
                lösningar = lösningar + y - i;
            }
            lösningar++;            //Det finns alltid minst en lösning om alla nummer är individuella.
            Console.WriteLine("Antal lösningar: " + lösningar);
            

        }
    }
}

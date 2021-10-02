using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNumeroImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int a = 1; a <= n; a++) //complete seu codigo
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine(a);

                }
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            //complete o código com sua solução

            int num1 = 1;
            int num2 = 0;


            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);


            if ((1 < X & X < 20) && (Y < 100000))
            {
                for (num1 = 1; num1 <= Y; num1++)
                {
                    num2++;
                    if (num2 == X)
                    {
                        Console.WriteLine("{0:D} ", num1);
                        num2 = 0;
                    }
                    else
                    {
                        Console.Write("{0:D} ", num1);
                    }

                }
            }


        }
    }
}

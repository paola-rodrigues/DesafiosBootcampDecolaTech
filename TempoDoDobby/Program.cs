using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTempoDoDobby
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(" ");
            string[] line2 = Console.ReadLine().Split(" ");

            int finalExpediente = int.Parse(line1[0]);

            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);

            //continue a solucao


            if ((presente1 + presente2) > finalExpediente)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else
            {
                Console.WriteLine("Farei hoje!");
            }
        }
    }
}

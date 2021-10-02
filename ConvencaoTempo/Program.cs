using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvencaoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            //continue a solucao
            var hours = timeInSeconds / 3600;
            var minutes = (timeInSeconds - (3600 * hours)) / 60;
            var seconds = (timeInSeconds - (3600 * hours)) - (minutes * 60);

            Console.WriteLine($"{hours}:{minutes}:{seconds}");

            Console.ReadLine();

        }
    }
}

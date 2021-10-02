using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');


            //complete declarando as variáveis
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);


            int MAIORAB = (a + b + (Math.Abs(a - b))) / 2;

            int MAIOR = (MAIORAB + c + (Math.Abs(MAIORAB - c))) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");


        }
    }
}

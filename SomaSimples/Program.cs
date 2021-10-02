using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSomaSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            int A = Int32.Parse(System.Console.ReadLine().Trim());
            int B = Int32.Parse(System.Console.ReadLine().Trim());


            //Insira as variaveis de acordo com o solicitado
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);
        }
    }
}

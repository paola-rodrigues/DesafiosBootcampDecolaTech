using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTiposDeTriangulos
{
    class Desafio
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            double n;

            if (b > a && b > c)
            {
                n = a;
                a = b;
                b = n;
            }
            else if (c > a)
            {
                n = a;
                a = c;
                c = n;
            }

            //continue a solucao
            if (a >= b + c)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a * a == (b * b) + (c * c))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a * a > (b * b) + (c * c))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a * a < (b * b) + (c * c))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();


        }
    }
}

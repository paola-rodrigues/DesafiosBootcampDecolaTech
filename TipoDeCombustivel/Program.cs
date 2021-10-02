using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTipoDeCombustivel
{
    class URI
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;
            int n = 0;

            do
            {

                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            alcool++;
                            break;
                        }

                    case 2:
                        {
                            gasolina++;
                            break;

                        }



                    case 3:
                        {
                            diesel++;
                            break;

                        }

                    case 4:
                        {
                            Console.WriteLine("MUITO OBRIGADO");
                        }

                        break;
                    default:
                        continue;
                }
            }

             while (n != 4);
             {
                Console.WriteLine("Alcool: {0}", alcool);
                Console.WriteLine("Gasolina: {0}", gasolina);
                Console.WriteLine("Diesel: {0}", diesel);


             }


        }
    }
}

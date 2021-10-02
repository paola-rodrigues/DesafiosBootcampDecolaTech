using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioValidacaoDeNotas
{
    class MinhaClasse
    {
        static void Main(string[] args)
        {
            //implente sua solução aqui
            int contador = 0;
            float soma = 0;
            float media = 0;


            do
            {
                float nota = float.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {

                    Console.WriteLine("nota invalida");

                }

                else
                {
                    contador++;
                    soma += nota;
                }

            } while (contador < 2);

            media = (soma) / 2;
            Console.WriteLine("media = " + media.ToString("N2"));


        }
    }
}

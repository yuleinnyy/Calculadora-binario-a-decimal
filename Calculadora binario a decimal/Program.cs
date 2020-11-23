using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_binario_a_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string bin = "";
            bool v = true;
            Console.Write("Escribe un numero binario: ");
            bin = Console.ReadLine();
            for (int x = bin.Length - 1, Y = 0; x >= 0; x--, Y++)
            {
                if (bin[x] == '0' || bin[x] == '1')
                    n += (int)(int.Parse(bin[x].ToString()) * Math.Pow(2, Y));
                else
                {
                    Console.Write("El numero no es binario");
                    v = false;
                    break;
                }
            }
            if (v)
                Console.Write("El numero decimal es: {0}", n);
            Console.ReadKey();

        }
    }
}

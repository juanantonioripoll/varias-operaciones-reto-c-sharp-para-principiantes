using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varias_Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro número");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} X {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);
            Console.ReadLine();
        }
    }
}

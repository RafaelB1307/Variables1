using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enteros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 54;
            int num3 = 20;
            int total = num1 + num2 + num3;
            Console.WriteLine("el valor de suma es:" + total);
            Console.WriteLine("presiona cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}

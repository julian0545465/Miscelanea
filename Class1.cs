using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class1
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Ingrese dos valores enteros");
            Console.WriteLine("");

            Console.WriteLine("Ingrese él primer valor");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(""); 

            Console.WriteLine("Ingrese él segundo valor");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("El valor total es: " + SumaEnteros(num1, num2));

        }
        static string SumaEnteros(int num1, int num2)
        {
            return Convert.ToString(num1 + num2);
        }
    }
}







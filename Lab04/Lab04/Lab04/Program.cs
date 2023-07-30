using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, sub, mul, div, num1, num2; 
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            Console.WriteLine("sum of the inputs:" + sum);
            Console.WriteLine("substraction of the inputs:" + sub);
            Console.WriteLine("multiplication of the inputs" + mul);
            Console.WriteLine("divition of the inputs:" + div);
            Console.ReadLine();
        }
    }
}

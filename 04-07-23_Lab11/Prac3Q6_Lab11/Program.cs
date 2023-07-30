using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3Q6_Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            AClass obj1 = new AClass();
            int[] array = obj1.AMethod(size);

            Console.WriteLine("\n Display the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

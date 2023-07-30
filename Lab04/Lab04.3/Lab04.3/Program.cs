using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; ++i)
                Console.WriteLine("Enter the number:" + i);
            if (i % 2 == 0) 
            {
                Console.WriteLine("Is an even number");
            }
            else
            {
                Console.WriteLine("Is a odd number");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 5, 6, 7, 8 };
            int smallest = num[0];
            int biggest = num[0];
            for(int i = 0; i < num.Length; i++)
            {
                if(smallest > biggest)
                {
                    smallest = num[i];
                }
                if (biggest < smallest)
                {
                    biggest = num[i];
                }
            }
            Console.WriteLine("Smallest:" + smallest);
            Console.WriteLine("Biggest:" + biggest);
            Console.ReadLine();
        }
    }
}
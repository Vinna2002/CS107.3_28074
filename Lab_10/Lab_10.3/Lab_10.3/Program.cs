using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 5, 6, 7, 8, 24, 56, 76 };
            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = 0; j < num.Length - 1; i++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + "");
            }
            Console.ReadLine();
        }
    }
}

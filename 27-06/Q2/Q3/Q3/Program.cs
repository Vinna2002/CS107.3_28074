using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3 //accending 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 10,20 }, { 23, 43 } };
            int min = num[0, 0];
            int max = num[0, 0];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for(int j=0; j < num.GetLength(1);j++)
                {
                    if (num[i,j]<min)
                    {
                        min = num[i,j];
                    }
                    if (num[i, j] > max)
                    {
                        max = num[i,j];
                    } 
                }

                
            }


            Console.WriteLine("Maximum " + max);
            Console.WriteLine("Minimum" + min);
            
           
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          
            Console.Write("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi" + name);

            int marks = 50;

            if (marks >= 75)
            {
                Console.Write("Grade: A");
            }
            else if (marks >= 60 && marks < 75)
            {
                Console.Write("Grade: B");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.Write("Grade: C");
            }
            else if (marks >= 40 && marks < 50)
            {
                Console.Write("Grade: D");
            }
            else
            {
                Console.Write("Fail");
            }
            Console.ReadLine();
        }
    }
}

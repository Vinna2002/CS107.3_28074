using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Please enter kilometers:");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double meters = kilometers / 1000;
        Console.WriteLine(meters + "Meters");
        }
    }
}

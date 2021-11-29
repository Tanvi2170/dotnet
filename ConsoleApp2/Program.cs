using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine("Maximum value is " +largerValue);
            largerValue = Math.Min(firstValue, secondValue);
            Console.WriteLine("Minimum value is " +largerValue);
            Console.ReadLine();
        }
    }
}

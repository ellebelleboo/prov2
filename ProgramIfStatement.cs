using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number: ");
            string num = Console.ReadLine();
            int age = Convert.ToInt32(num);

            if (age > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (age < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }


            Console.ReadLine();

        }
    }
}

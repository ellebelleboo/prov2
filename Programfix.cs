using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Asking user to enter numbers and converting to double
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            double sum = (num1 + num2);
            double difference = (num1 - num2);
            double product = (num1 * num2);
            double quotient = (num1/num2);

            //sums, differences, products and quotinents of numbers
            Console.WriteLine($"The sum of the numbers is: {num1} + {num2} = {sum}");
            Console.WriteLine($"The difference of the numbers is: {num1} - {num2} = {difference}");
            Console.WriteLine($"The product of the numbers is: {num1} * {num2} = {product}");
            Console.WriteLine($"The quotient of the numbers is: {num1} / {num2} = {quotient}");

            Console.ReadLine();
        }

    }
}


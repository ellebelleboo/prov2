using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Asking the user to enter a value and converting
            Console.Write("Enter an integer value: ");
            int myInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a double value: ");
            double myDouble = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a float value: ");
            float myFloat = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter a string value: ");
            String myString = Console.ReadLine();

            //printing out inputs
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myFloat);
            Console.WriteLine(myString);

            //brief explanations
            Console.WriteLine("\nInt stores whole numbers.");
            Console.WriteLine("double stores numbers with decimals up to 15 decimal digits.");
            Console.WriteLine("float also stores decimals but only up to 6-7 decimal digits.");
            Console.WriteLine("string stores text.");


            Console.ReadLine();


        }
    }
}

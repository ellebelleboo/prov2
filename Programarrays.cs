using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Two arrays
            string[] names = { "Alice", "John", "Mia" };
            int[] num = { 12, 45, 78, 3, 99, 21, 8 };

            //Looping the first array
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hello" + " " + names[i]);
            }
            
            //sorting, removing and printing out the second array
            num = num.OrderByDescending(i => i).ToArray();
            num= num.Take(num.Length - 1).ToArray();

            foreach (int value in num)
            {
                Console.Write(value + " ");
            }


            Console.ReadLine();
        }
    }
}

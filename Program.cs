using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            string myString = "";
            string[] vowels = { "a", "e", "i", "o", "u" };
            int vowelCount = 0;

            //Enter a string
            Console.WriteLine("Enter a string: ");

            //user inputs a string
            myString = Console.ReadLine();

            //
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Methods_3
{
    class Mathamatics
    {
        public void twoParameter(int num1, int num2)
        {
            int multiBy6 = num1 * 6;
            Console.WriteLine($"Your first number {num1} times 6 = {multiBy6}");
            Console.WriteLine($"Your second number is {num2} no math operation carried out.");
            Console.WriteLine("\n\n\nPress ENTER to continue");
            Console.Read();
            return;
        }
    }
}

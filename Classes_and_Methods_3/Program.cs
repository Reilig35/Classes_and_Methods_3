using System;

namespace Classes_and_Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Mathamatics myMethod = new Mathamatics();
            myMethod.twoParameter(num1, num2);
        }
    }
}

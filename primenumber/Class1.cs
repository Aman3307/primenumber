using System;

namespace primenumber
{
    public class Class1
    {
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[]args)
        {
            Console.Write("Enter an integer.");
            int number = int.Parse(Console.ReadLine());
            if (IsEven(number))
            {
                Console.WriteLine(number + "is an even number");
            }
            else 
            {
                Console.WriteLine(number + "is an even number");
            }
        }
    }
}
       
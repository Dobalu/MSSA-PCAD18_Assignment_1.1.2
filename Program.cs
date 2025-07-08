// Write a C# program to print the sum of two numbers. Get the input from user.

namespace Assignment_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers to add together.");
            Console.Write("First number: ");
            string num1Str = Console.ReadLine();
            Console.Write("Second number: ");
            string num2Str = Console.ReadLine();

            double num1 = Convert.ToDouble(num1Str);
            double num2 = Convert.ToDouble(num2Str);
            double sum = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            Console.WriteLine("These two numbers have a sum of: " + sum);
        }
    }
}
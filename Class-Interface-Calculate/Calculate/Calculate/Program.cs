using Services.Implementations;
using Services.Interfaces;
using System;

namespace Calculate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Calculate(num1, num2, operation));
        }
    }
}

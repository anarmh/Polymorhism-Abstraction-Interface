using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class Calculation : ICalculation

    {
        public double Calculate(double num1, double num2, string operation)
        {
            double result = 0;

            switch(operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }
    }
}

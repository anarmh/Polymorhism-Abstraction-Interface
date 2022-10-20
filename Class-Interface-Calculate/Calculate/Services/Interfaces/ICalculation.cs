using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICalculation
    {
        public double Calculate(double num1,double num2,string operation);
    }
}

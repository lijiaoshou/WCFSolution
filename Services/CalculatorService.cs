using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CalculatorService : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x/y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Substract(double x, double y)
        {
            return x -y;
        }
    }
}

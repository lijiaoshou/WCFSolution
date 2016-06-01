using Client.CalculatorServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CaculatorServiceClient proxy = new CaculatorServiceClient())
            {
                Console.WriteLine("x + y = {2} when x = {0} and y = {1}", 1, 2, proxy.Add(1, 2));
                Console.WriteLine("x - y = {2} when x = {0} and y = {1}", 1, 2, proxy.Substract(1, 2));
                Console.WriteLine("x * y = {2} when x = {0} and y = {1}", 1, 2, proxy.Multiply(1, 2));
                Console.WriteLine("x / y = {2} when x = {0} and y = {1}", 1, 2, proxy.Divide(1, 2));
                Console.ReadKey();
            }
        }
    }
}

using Service.Services.Implementation;
using System;

namespace Poly_Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Calculate());
        }
    }
}

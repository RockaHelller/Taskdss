using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Implementation
{
    public class Calculation : ICalculation
    {
        public int Calculate()
        {
            int result = 0;
            Console.WriteLine("Please Add First Number");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine("Please Add Second Number");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Add Operation");
            Operator:  string operation = Console.ReadLine();


            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                if (operation == "+")
                {
                    return result = n + m;
                    
                }
                else if (operation == "-")
                {
                    return result = n - m;
                }
                else if (operation == "*")
                {
                    return result = n * m;
                }
                else if (operation == "/")
                {
                    return result = n / m;
                }
                return result;

            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun reqem daxil edin");
                goto Operator;
            }



        }
    }
}

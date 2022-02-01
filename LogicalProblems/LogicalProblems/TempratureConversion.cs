using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class TempratureConversion
    {
        public void temperatureConversion()
        {
            Console.WriteLine("Select the option from below : ");
            Console.WriteLine("1] Convert Celsius to Fahrenheit");
            Console.WriteLine("2] Convert Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the temperature in Celsius: ");
                    double C = Convert.ToDouble(Console.ReadLine());
                    double F = (C * 9 / 5) + 32;
                    Console.WriteLine(C + "°C to " + F + "°F");
                    break;
                case 2:
                    Console.WriteLine("Enter the temperature in Fahrenheit: ");
                    double f = Convert.ToDouble(Console.ReadLine());
                    double c = (f - 32) * 5 / 9;
                    Console.WriteLine(f + "°F to " + c + "°C");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}

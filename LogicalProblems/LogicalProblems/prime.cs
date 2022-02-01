using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class prime
    {
        public void primeNumber()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= (num / 2) + 1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num}Number is not prime");
                    break;
                }
                else
                {
                    Console.WriteLine($"{num}Number is prime");
                }


            }
        }
    }
}
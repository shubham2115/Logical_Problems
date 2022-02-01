using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNumber
    {
        public void reverseNmuber()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reverse of " + num + " is :");
            int reverse = 0;
            String s = "";
            while (num != 0)
            {
                int pick_last = num % 10;
                s = s + Convert.ToInt32(pick_last);
                num = num / 10;
            }
            Console.WriteLine(s);
        }
    }
    
}

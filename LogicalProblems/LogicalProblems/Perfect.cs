using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Perfect
    {
        public void perfectNumber()
        {

			Console.WriteLine("Enter a number : ");
			int num = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			for (int i = 1; i < num; i++)
			{
				if (num % i == 0)
					sum = sum + i;
			}
			if (sum == num)
			{
				Console.WriteLine("Perfect Number");
			}
			else
			{
				Console.WriteLine("Not an Perfect Number");
			}
		}
	}
}
        

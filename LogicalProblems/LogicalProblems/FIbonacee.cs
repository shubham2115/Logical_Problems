using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class FIbonacee
    {
        public void Series()
        {
			Console.WriteLine("Enter the limit : ");
			int lim = Convert.ToInt32(Console.ReadLine());
			if (lim > 0)
			{
				int y = 0, z = 1, s;
				Console.Write("Fibonacci Series : " + y + "  " + z + "  ");
				while (z <= lim)
				{
					s = y + z;
					y = z;
					z = s;
					if (z <= lim)
						Console.Write(z + "  ");
				}
			}
			else
				Console.WriteLine("Wrong Input");
		}
	}
}
        

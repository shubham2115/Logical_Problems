using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class DayForDate
    {
        public void checkDayForADate()
        {
            int yr, mn, dt;

            Console.Write(" Find the day for a given date :\n ");
            Console.Write("------------------------------------\n");

            Console.Write(" Input the Day : ");
            dt = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the Month : ");
            mn = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the Year : ");
            yr = Convert.ToInt32(Console.ReadLine());

           
            DateTime d = new DateTime(yr, mn, dt);
            Console.WriteLine(" The formatted Date is : " + d.ToString("dd/MM/yyyy"));

            
            DateTime pp;
            pp = DayOfWeek(d);
            Console.WriteLine(" The day for the date is : " + pp.DayOfWeek);
        }
        public static DateTime DayOfWeek(DateTime dt)
        {
            DateTime ss = new DateTime(dt.Year, dt.Month, dt.Day);
            return ss;
        }

    }
}

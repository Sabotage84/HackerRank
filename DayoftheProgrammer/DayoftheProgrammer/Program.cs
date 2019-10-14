using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayoftheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 2017;
            Console.WriteLine(dayOfProgrammer(y));
            Console.ReadKey();
        }

        static string dayOfProgrammer(int year)
        {

            if(year == 1918)
                return "27.09.1918";
            if (year < 1918)
            {
                if (year % 4 == 0)
                    return "12.09." + year;
                else
                    return "13.09." + year;
            }
            else
            {
                if(year % 400 == 0)
                    return "12.09." + year;
                else if (year % 4 == 0 && year%100!=0)
                    return "12.09." + year;
                else
                    return "13.09." + year;
            }
           
        }
    }
}

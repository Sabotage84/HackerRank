using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input.Add(73);
            input.Add(67);
            input.Add(38);
            input.Add(33);

            List<int> res = gradingStudents(input);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> res = new List<int>();
            foreach (var item in grades)
            {
                if (item < 38)
                {
                    res.Add(item);
                }
                else
                {
                    if (item % 5 > 2)
                        res.Add(item / 5 * 5 + 5);
                    else
                        res.Add(item);
                }
            }


            return res;
        }
    }
}

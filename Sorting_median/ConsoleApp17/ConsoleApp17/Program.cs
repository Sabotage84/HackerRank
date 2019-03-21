using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Program
    {
        static void Main(string[] args)
        {
            int d = 10000;
            
            string path = @"test.txt";
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }
           
            var arr= Array.ConvertAll(text.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));
            int r = activityNotifications(arr, d);
            Console.WriteLine(r);
            Console.ReadKey();
        }

        static public int activityNotifications(int[] expenditure, int d)
        {
            int res = 0;
            Array.Reverse(expenditure);
            //List<int> lst = new List<int>();
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            double med = 0;
            for (int j = 1; j <= d; j++)
            {
                //lst.Add(expenditure[j]);
                if (dic.ContainsKey(expenditure[j]))
                    dic[expenditure[j]]++;
                else
                    dic.Add(expenditure[j], 1);
            }
            //lst.Sort();
            
            double dd = (double)d % 2;

            if (dd != 0)
            {
                int tt = d / 2+1;
                foreach (var item in dic)
                {
                    tt -= item.Value;
                    if (tt <= 0)
                    {
                        med = item.Key;
                        break;
                    }

                }
                //med = lst[d/2];
            }
            else
            {
                int tt = d / 2+1;
                foreach (var item in dic)
                {
                    tt -= item.Value;
                    if (tt <= 0)
                    {
                        med = item.Key;
                        break;
                    }
                    if (tt == 1)
                    {
                        double t1 = item.Key;
                        double t2 = item.Key+1;
                        med=(t1+t2)/2;
                        break;
                    }

                }


                
            }



            for (int i = 0; i <= expenditure.Length - 1 - d; i++)
            {
               
                if (expenditure[i] >= med * 2)
                    res++;
                if ((i + 1 + d) <= expenditure.Length - 1)
                {
                    //lst.Remove(expenditure[i + 1]);
                    if (dic.ContainsKey(expenditure[i + 1]))
                    {
                        dic[expenditure[i + 1]]--;
                        if (dic[expenditure[i + 1]] == 0)
                            dic.Remove(expenditure[i + 1]);
                    }
                    //else
                    //    dic.Add(expenditure[j], 1);




                    //lst.Add(expenditure[i + 1 + d]);
                    if (dic.ContainsKey(expenditure[i + 1 + d]))
                        dic[expenditure[i + 1 + d]]++;
                    else
                        dic.Add(expenditure[i + 1 + d], 1);


                    if (dd != 0)
                    {
                        int tt = d / 2+1;
                        foreach (var item in dic)
                        {
                            tt -= item.Value;
                            if (tt <= 0)
                            {
                                med = item.Key;
                                break;
                            }

                        }
                        
                    }
                    else
                    {
                        int tt = d / 2+1;
                        foreach (var item in dic)
                        {
                            tt -= item.Value;
                            if (tt <= 0)
                            {
                                med = item.Key;
                                break;
                            }
                            if (tt == 1)
                            {
                                double t1 = item.Key;
                                double t2 = item.Key + 1;
                                med = (t1 + t2) / 2;
                                break;
                            }

                        }

                    }
                }
            }
            return res;
        }
    }
}

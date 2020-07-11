using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "10101","11100","11010","00101" };
            acmTeam(str);
        }

        static int[] acmTeam(string[] topic)
        {
            int[] res = new int[2];
            int tres1 = 0;
            


            for (int i = 0; i < topic.Length-1; i++)
            {
                for (int l = i + 1; l < topic.Length; l++)
                {
                    tres1 = 0;
                    for (int j = 0; j < topic[i].Length; j++)
                    {
                        if(topic[i][j]=='1' || topic[l][j]=='1' )
                        {
                            tres1++;
                        }
                    }
                    if (tres1>res[0])
                    {
                        res[0] = tres1;
                        res[1] = 1;
                    }
                    else if (tres1==res[0])
                    {
                        res[1]++;
                    }
                }

            }














            //for (int i = 0; i < topic.Length; i++)
            //{
            //    //Console.WriteLine( topic[i]);
            //    string s = topic[i];
            //    char[] ch = s.ToCharArray();

            //    byte[] e = System.Text.Encoding.UTF8.GetBytes(ch);
            //    BitArray a = new BitArray(e);

            //}

            return res;
        }
    }
}

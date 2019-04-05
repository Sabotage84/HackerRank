using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CharInd
    {
        char ch;
        int indexS1;
        int indexS2;

        public CharInd(char ch, int index1, int index2)
        {
            this.ch = ch;
            this.indexS1 = index1;
            this.indexS2 = index2;
        }
        public override bool Equals(object obj)
        {
            CharInd temp = (CharInd)obj;

            if (this.ch == temp.ch && indexS1 == temp.indexS1 && indexS2 == temp.indexS2)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -461525457;
            hashCode = hashCode * -1521134295 + ch.GetHashCode();
            hashCode = hashCode * -1521134295 + indexS1.GetHashCode();
            hashCode = hashCode * -1521134295 + indexS2.GetHashCode();
            return hashCode;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = "WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS";
            string s2 = "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC";
            
            int t= commonChild(s1, s2);
            //commonChild("SHINCHAN", "NOHARAAA");
            Console.WriteLine(t);
            Console.ReadKey();
        }
        public static int commonChild(string s1, string s2)
        {
            int res = 0;
            int[] arr = new int[s1.Length];
            for (int i = s1.Length-1; i >=0; i--)
            {
                for (int j = 0; j<s2.Length; j++)
                {
                    if(s1[i]==s2[j])
                    {
                        
                        arr[j]=1;

                        int tempMax = 0;
                        for (int k = j+1; k < arr.Length; k++)
                        {
                            if (tempMax < arr[k])
                                tempMax = arr[k];
                        }
                        arr[j] += tempMax;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (res < arr[i])
                    res = arr[i];
            }

            return res;
        }

        //private static int CommonChildReq3(string s1, string s2, int start1,int start2, Dictionary<CharInd, int> dic)
        //{
        //    int res = 0;
        //    int tempRes = 0;
        //    List<char> alredyDone = new List<char>();
            
        //    for (int i =start1; (i < s1.Length && res <= (s1.Length - i)); i++)
        //    {
        //        if (!alredyDone.Contains(s1[i]))
        //        {
        //            alredyDone.Add(s1[i]);
        //            List<char> alredyDone2 = new List<char>();
        //            for (int j = start2; (j < s2.Length && res <= (s2.Length - j)); j++)
        //            {
        //                if (!alredyDone2.Contains(s2[j]))
        //                {
        //                    alredyDone2.Add(s2[j]);
        //                    if (s1[i] == s2[j])
        //                    {
        //                        if (dic.ContainsKey(new CharInd(s1[i], i, j)))
        //                            tempRes = dic[new CharInd(s1[i], i, j)];
        //                        else
        //                        {
        //                            tempRes++;
        //                            if (s2.Length - j > res)
        //                               tempRes += CommonChildReq3(s1, s2,i+1,j+1, dic);

        //                            dic.Add(new CharInd(s1[i], i, j), tempRes);
        //                        }
        //                    }
                            
        //                }
        //                if (tempRes > res)
        //                        res = tempRes;
        //                    tempRes = 0;
        //            }
        //        }
                
        //    }

        //    return res;
        //}

        //private static void ShowList(List<char> alredyDone)
        //{
        //    foreach (var item in alredyDone)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

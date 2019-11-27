using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "lyylyyllyyylllyylyyylyllylyllllllyyylyllyyyylllllylyylyyllylyylllyhyllllyylllyllylyllylyllllyylylylyyylyllyyylylllyylylllyyllyylylyyllyylyyylllyllylyyllyllllyylylyylllllllyllyyyyyylllyyylylylylyyyyyyyymylyyyylyyyylyyyylyyyylylylylylyllylyylllyllyylylyyllyyyylylllyyyyyllllllyllyylllylyylyllllyyllllylyyyyyllllylylllyyyylyylyyyllyylyyyylylyyyylyyyyylyylllyyllylyyllyllyyyyyylylllylyyyyyllyylyyyyylyyylyylyylylylyyllllyylllyylylllyllyylylyllylllyllyyyyyylyyyllyllyyllyllyylyllyllyyylyyyyylylllyyylllyyyllylyllylylyyllylllylyyyyylyyyylyyyylyyyyylylllllyylyylyyyylyylyyylyylllllllyyyyyyyylyyylylllllylyrlyylllyylylllllylyylyylyyllylyyyyllyyyllylllyllylllylyyyyylylylyyllyyyyylllyyyllllylyllyyyllllyyllyyylllylyylyyyllllyllylllylyllylllyyllllyllyyymyylylllyylllllllyyyyylyyyllyyyyyyylylylyylylyylylyyllyyyllylylyyyylyyyyyyyyyyylllylylllllylllyylllyyllllllyylllllyllyyllyylyyllllyylyylyyllllyyyllllyyylylylylyylyllylllyyylylylylyyylyllllllylyllllyylyllylllyllyylylllylllyllllylyyylylllyyylllyylllllllyllyyy";
            string b = "LYYLYYLYYYLLLYYLYYYYLLYLLLLLLYYYLYLLYYYYLLLLYLYLYYLLYLYLLYYLLLYYLLLLYLYLLYLYLLLLYYLYLLYYLYLLYLLLLYLYLLYLYYLLYYLLYYLYYYLLLYLYLYYLLYLLYYYLYLLLLLLLYLLYYYYYLLLYYYLYLYLYLYYYYYYYLYYYLYYYYLYYLYYYYLYYLYLYLYLLYLYYLLLYLLYYLYLYLLYYYLYLLLYYYYLLLLLLYLLYYLLLYLYYLYLLLLYLLLYLYYYYYLLLLLYLLLYYYYLYYLYYLLYYLYYYYLYLYYYYLYYYYYLYYLLLYYLLYLYLLYLLYYYYYLYLLYLYYYYYLLYYLYYYYLYYYLYYLYYLYLYLYYLLLLYYLLLYYLYLLLYLLYLYLYLLYLLLYLLYYYYYYLYYYLLYLYYLLYLLYLYLLYLLYYYLYYYYLLLLYYYLLLYYYLLYLYLLYLYLYYLLYLLLYLYYYYYLYYYYLYYYYLYYYYYLYLLLLLYYLYYLYYYLYYYYYLYYLLLLLLLYYYYYYYYLYYLYLLLLYLYLYYLLYYLYLLLLLYLYYLYYLYLLYLYYYLYYYLYLLLYLLYLLYLYYYYYLLYYYLLYYYYYLLYYYLLLLYLYLLYYYLLLLYYLLYYYLLLYLYYLYYYLLLYLLYLYLYLLYLLYYLLLYLLYYYYYLYLLLYYLLLLLLLYYYYYLYYLLYYYYYYLYYLLYYLYLYYLLYYYLLYYLYYYYLYYYYYYYYYYYLLLYYLLLLLYLLLYYLLLYYLLLLLYYLLLLYLYYLLYYLYYLLLYYLYYLYYLLLLYYYLLLLYYYYLYLYLYYYLLYLLLYYYLYLYLYLYYLYLLLLLYLYLLLYYYLLYLYLLYYLYLLYLLLYLLYLYYYLYLLLYYLLYYLLLLLLYLYY";
            Console.WriteLine(abbreviation(a, b));
            Console.ReadKey();
        }

        static string abbreviation(string a, string b)
        {
            string origB = b;
            string origA = a;

            int t = 0;
            if (b.Length > a.Length)
                return "NO";
            a= a.ToLower();
            b= b.ToLower();
            int innerIndex = 0;
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = innerIndex; j < a.Length; j++)
                {
                    if(b[i]==a[j])
                    {
                        t = 0;
                        //if (i==b.Length-1)
                        //    return "YES";
                        innerIndex = j+1;
                        break;
                    }
                    if (j == a.Length - 1)
                    {
                        Console.WriteLine("i={0}, j={0}", i, j);
                        return "NO";
                    }
                    if (char.IsUpper(origA[j]))
                    {
                        if (j == 0)
                            return "NO";

                        if(origB[i-1]==origA[j] && t<2)
                        {
                            t++;
                        }
                        else
                        {
                            return "NO";
                        }
                        //Console.WriteLine("i={0}, j={0}", i, j);
                        //Console.WriteLine(origA.Substring(0, j+1));
                        //Console.WriteLine(origB.Substring(0, i+1));

                    }
                }
                if (a.Length - innerIndex+1 < b.Length - i)
                    return "NO";

            }

            for (int i = innerIndex; i < a.Length; i++)
            {
                if (char.IsUpper(origA[i]))
                {

                    if (origB[b.Length - 1] == origA[i] && t < 2)
                    {
                        t++;
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }
    }
}

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
            string a = "ERreEerREeerErrrrRRyeReErrerrereEEeRRErRrrereeeeerErereerReRereeeeCrreErREreeerrRrRERreeererererEeEEeerrerrereeRRerreeerrreRererereeSerEeeRereerrReErrrereErrerrrreererrsRRecerEreeRrrreRereerErrRRrrEeEererRrrreRerReRrereererereEeereEereesrERreReeerReErEeeeeRererReereRereerRrrRRerrerreeereEeeereerrEreeERreReRrEErRRerEereeeRreeErReerrEerEeEreerrTeeeEErreRErrerreeeeereeEeerERErRrereerreerRrrreerEreeRrErreeeRReRerrreerrEreerrerEeEeerreeeeEeerRrrerrsrerrereReREerEerrRerRErereRreerRreRReEeeeRerRereeerRerererrerrrreeReeERereeeesrrEerrrreeeeerrrrereeeeeerRrRrreeereRrreeseERrrrerReeeerreeeeereEerErrrRrreeeerRerrrrrErRreREeeerrrrrrrErrreerrRrereerrRrEEErsREeeerReEeErrrrRrRererereeererreereeRreerrerREeEReereerrrrrrereereeeerEeeeerreerSrReererrRereREreereErEReEReeeerrerEeeEeeRreeeRreeeEreeeeEreerrrEeereeerrrrERrRERReeerreEeJEEeSEeeeEeEeeRrRrrreeeRerrreerEreeererEereeeeRRrreReRrEerreEreeeerEErRrRrrrrerrereeEERErerreerrRrrreeeErEeErEreRrErRrErrreeeereeerrrrSeReeeeRerrrrerrEreerEeeeeeeerrreerreRerrREr";
            string b = "ERREREERERRREERREERRERRREEEERRREREEECEREERRRERREEEERRREERRERRRRSERERERERERERRRRRREERREREERRREEERERRRRRRREREEESEREREREEEERRERERRRERRRRREEREREERERREERRERRERREREEEERRTEEEEREEREEEEEEEERERRRRERREERREREERRREREREEREEREEERRRERERERREEREERRERRERERERRRREEERRREERRRRREREREREEEEERRRRRRRREERRERRERRRERERRREEERRRRERRERERRRERRRREREERREEESREEREERRRERREEEERRERERREEREREEREERREEEEEERRRSRERREREEEERERREREEERRERREEEEEEEREEERERRERREREEJEESEEEEEEERRRREEREREEEEEERERRRRRRREEEEREERRREEREEERRREEEEREERRERRERRRSREEERERREERRRRER";
            Console.WriteLine(abbreviation(a, b));
            Console.ReadKey();
        }

        static string abbreviation(string a, string b)
        {
            string res = "NO";

            List<MyChar> astr = new List<MyChar>();
            if (char.IsUpper(a[0]))
                astr.Add(new MyChar(a[0], 1, 0));
            else
                astr.Add(new MyChar(char.ToUpper(a[0]), 0, 1));

            for (int i = 1; i < a.Length; i++)
            {
                if(char.ToUpper(a[i])== char.ToUpper(a[i-1]))
                {
                    if (char.IsUpper(a[i]))
                        astr.Last().H++;
                    else
                        astr.Last().L++;
                }
                else
                {
                    astr.Add(new MyChar(char.ToUpper(a[i]),0, 0));
                    if (char.IsUpper(a[i]))
                        astr.Last().H++;
                    else
                        astr.Last().L++;
                }
            }

            foreach (var item in astr)
            {
                Console.WriteLine("{0}-> {1}  {2}", item.name, item.H, item.L);
            }

            return res;
        }

        class MyChar
        {
            public char name;
            public int H;
            public int L;

            public MyChar(char name, int h, int l)
            {
                this.name = name;
                H = h;
                L = l;
            }

            public MyChar()
            {

            }
        }
    }
}

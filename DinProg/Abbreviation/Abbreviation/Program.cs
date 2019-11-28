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
            string origB = b;
            string upperA = a.ToUpper();
            bool lowFind = false;
            bool upperFind = false;
            int t = 0;
            if (b.Length > a.Length)
                return "NO";

            int innerIndex = 0;
            for (int i = 0; i < b.Length; i++)
            {
                lowFind = false;
                upperFind = false;
                for (int j = innerIndex; j < a.Length; j++)
                {
                    Console.WriteLine(a.Substring(0, j + 1));
                    Console.WriteLine(b.Substring(0, i + 1));
                    if (b[i] == a[j] && !lowFind)
                    {
                        innerIndex = j + 1;
                        upperFind = true;
                        break;
                    }
                    else if (b[i] == a[j] && lowFind)
                    {
                        if (!(i == b.Length - 1) && b[i + 1] != b[i])
                        {
                            innerIndex = j + 1;
                            break;
                        }
                        else if (!(i == b.Length - 1) && b[i + 1] == b[i])
                        {
                            break;
                        }
                        else
                            break;
                    }
                    else if (!lowFind && b[i] == upperA[j])
                    {
                        lowFind = true;
                        innerIndex = j + 1;
                    }
                    else if (char.IsUpper(a[j]) && !lowFind)
                    {
                        Console.WriteLine("1");
                        Console.WriteLine(a.Substring(0, j+1));
                        Console.WriteLine(b.Substring(0, i+1));
                        return "NO";
                    }
                    else if (char.IsUpper(a[j]) && lowFind)
                    {
                        break;
                    }
                    if (j == a.Length - 1 && !lowFind)
                    {
                        Console.WriteLine("2");
                        return "NO";
                    }
                }
                if (a.Length - innerIndex + 1 < b.Length - i)
                {
                    Console.WriteLine("3");
                    return "NO";
                }


            }

            for (int i = innerIndex; i < a.Length; i++)
            {
                if (char.IsUpper(a[i]))
                {
                    if (a[i] == b.Last() && upperFind)
                    {
                        Console.WriteLine("4");
                        return "NO";
                    }
                    else if (a[i] == b.Last() && !upperFind)
                        upperFind = true;
                    else
                    {
                        Console.WriteLine("5");
                        return "NO";
                    }

                }
            }

            return "YES";
        }
    }
}

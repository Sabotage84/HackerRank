using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTimeinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            


    

        }
        static string timeInWords(int h, int m)
        {
            string res = "";
            string hour = @"o' clock";
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            string ten = "ten";
            string eleven = "eleven";
            string twelve = "twelve";
            string thirteen = "thirteen";
            string fourteen = "fourteen";
            string fifteen = "quarter";
            string sixteen = "sixteen";
            string seventeen = "seventeen";
            string eighteen = "eighteen";
            string nineteen = "nineteen";
            string twenty = "twenty";

            if (m > 30)
                h++;

            switch (h)
            {
                
                case 1:
                    res += one;
                    break;
                case 2:
                    res += two;
                    break;
                case 3:
                    res += three;
                    break;
                case 4:
                    res += four;
                    break;
                case 5:
                    res += five;
                    break;
                case 6:
                    res += six;
                    break;
                case 7:
                    res += seven;
                    break;
                case 8:
                    res += eight;
                    break;
                case 9:
                    res += nine;
                    break;
                case 10:
                    res += ten;
                    break;
                case 11:
                    res += eleven;
                    break;
                case 12:
                    res += twelve;
                    break;
                default:
                    
                    break;
            }

            if (m==00)
            {
                return res + " " + hour;
            }
            else if (m==30)
            {
                return "half past " + res;
            }
            else
            {
                int t;
                if (m < 30)
                    t = m;
                else
                    t = 60 - m;
                if (m < 30)
                    res = "past " + res;
                else
                {
                    res = "to " + res;
                }
                string min = " minutes ";
                switch (t)
                {

                    case 1:
                        res = one + " minute " +res;
                        break;
                    case 2:
                        res = two + min + res;
                        break;
                    case 3:
                        res = three + min + res;
                        break;
                    case 4:
                        res = four + min + res;
                        break;
                    case 5:
                        res = five + min + res;
                        break;
                    case 6:
                        res = six + min + res;
                        break;
                    case 7:
                        res = seven + min + res;
                        break;
                    case 8:
                        res = eight + min + res;
                        break;
                    case 9:
                        res = nine + min + res;
                        break;
                    case 10:
                        res = ten + min + res;
                        break;
                    case 11:
                        res = eleven + min + res;
                        break;
                    case 12:
                        res = twelve + min + res;
                        break;
                    case 13:
                        res = thirteen + min + res;
                        break;
                    case 14:
                        res = fourteen + min + res;
                        break;
                    case 15:
                        res = fifteen +" "+ res;
                        break;
                    case 16:
                        res = sixteen + min + res;
                        break;
                    case 17:
                        res = seventeen +min + res;
                        break;
                    case 18:
                        res = eighteen + min + res;
                        break;
                    case 19:
                        res = nineteen + min + res;
                        break;
                    case 20:
                        res = twenty + min + res;
                        break;
                    case 21:
                        res = twenty+" "+one + min + res;
                        break;
                    case 22:
                        res = twenty + " " + two + min + res;
                        break;
                    case 23:
                        res = twenty + " " + three + min + res;
                        break;
                    case 24:
                        res = twenty + " " + four + min + res;
                        break;
                    case 25:
                        res = twenty + " " + five + min + res;
                        break;
                    case 26:
                        res = twenty + " " + six + min + res;
                        break;
                    case 27:
                        res = twenty + " " + seven + min + res;
                        break;
                    case 28:
                        res = twenty + " " + eight + min + res;
                        break;
                    case 29:
                        res = twenty + " " + nine + min + res;
                        break;
                    default:
                        
                        break;
                }


            }

            return res;
        }

    }
}

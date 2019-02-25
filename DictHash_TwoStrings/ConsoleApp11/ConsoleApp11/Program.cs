﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ConsoleApp11
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!temp.Contains(s1[i].ToString()))
                    temp.Add(s1[i].ToString());
            }
            foreach (var item in temp)
            {
                if (s2.Contains(item))
                    return "YES";
            }
            return "NO";
        }

        static void Main(string[] args)
        {


            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
                Console.ReadKey();

               // textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }


}



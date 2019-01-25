using System.CodeDom.Compiler;
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

class Solution
{

    // Complete the arrayManipulation function below. 
    static long arrayManipulation(int n, int[][] queries)
    {
        int[] ARR = new int[n];
        long max = 0;
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            for (int j = queries[i][0] - 1; j < queries[i][1]; j++)
            {
                ARR[j] += queries[i][2];
                if (max < ARR[j])
                    max = ARR[j];
                Console.WriteLine(max.ToString());
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        string[] arStr = File.ReadAllLines("arr.txt");


        string[] nm = arStr[0].Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(arStr[i+1].Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}
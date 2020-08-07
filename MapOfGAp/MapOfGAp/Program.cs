using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOfGAp
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        static string[] cavityMap(string[] grid)
        {
            string[] res= new string[grid.Length];
            res[0] = grid[0];
            for (int i = 1; i < grid.Length-1; i++)
            {
                res[i] += grid[i][0];
                for (int j = 1; j < grid[i].Length-1; j++)
                {
                    int cur = int.Parse(grid[i][j].ToString());
                    int l = int.Parse(grid[i][j - 1].ToString());
                    int t = int.Parse(grid[i-1][j].ToString());
                    int r = int.Parse(grid[i][j + 1].ToString());
                    int b = int.Parse(grid[i+1][j].ToString());
                    if (cur>l && cur>t && cur>r && cur>b)
                    {
                        res[i] += "X";
                    }
                    else
                    {
                        res[i] += cur.ToString();
                    }
                }
                res[i] += grid[i][grid[i].Length-1];
            }
            res[res.Length - 1] = grid[grid.Length - 1];
            return res;
        }

    }
}

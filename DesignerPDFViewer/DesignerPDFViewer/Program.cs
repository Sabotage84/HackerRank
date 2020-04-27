using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] H = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string s = "abc";
            Console.WriteLine(designerPdfViewer(H, s));
            Console.ReadLine();
        }

        static int designerPdfViewer(int[] h, string word)
        {
            
            int hmax=0;
            for (int i = 0; i < word.Length; i++)
            {
               
                if ((h[Convert.ToInt32(word[i]) - 97]) > hmax)
                    hmax = h[Convert.ToInt32(word[i]) - 97];
            }

            return hmax*word.Length;
        }
    }
}

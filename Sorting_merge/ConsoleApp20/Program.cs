using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 2, 1, 3, 1, 2 };
            int res = 0;
           mergeSort(arr, ref res);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static void mergeSort(int[] arr, ref int res)
        {
            mergeSort(arr, new int[arr.Length], 0, arr.Length - 1, ref res);
        }

        private static void mergeSort(int[] arr, int[] temp, int leftStart, int rightEnd, ref int  res)
        {
            if (leftStart >= rightEnd)
                return ;
            int mid = (leftStart + rightEnd) / 2;
            mergeSort(arr, temp, leftStart, mid,ref res);
            mergeSort(arr, temp, mid + 1, rightEnd,ref res);
            mergeHalves(arr, temp, leftStart, rightEnd,ref res);
            
        }

        private static void mergeHalves(int[] arr, int[] temp, int leftStart, int rightEnd, ref int res)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;
            while (left <= leftEnd && right <= rightEnd)
            {
                if (arr[left] <= arr[right])
                {
                    temp[index] = arr[left];
                    left++;
                    
                }
                else
                {
                    temp[index] = arr[right];
                    right++;
                    res++;
                }
                index++;
               
            }
            if(leftEnd - left + 1==1)
                res++;
            ShowArray(arr);
            Array.Copy(arr, left, temp, index, leftEnd - left + 1);
            Array.Copy(arr, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, arr, leftStart, size);
            
        }

        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
        }


    //    long res = 0;
    //    for (int j = 1; j<arr.Length; j++){ 
    //        int key = arr[j];
    //    int i = j - 1;
    //        while (i >= 0 && arr[i] > key){ 
    //            arr[i + 1] = arr[i];
    //            i = i - 1;
    //            res++;
    //       }
    //arr[i + 1] = key;
    //    }
    //    return res;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.MergeSort
{
    public class MergeSortClass
    {
        public int []  Mergesort(int[] MyArray)
        {
            int n=MyArray.Length;
            if (n>1)
            {

           
            int mid = n / 2;
            int[] Left = new int[mid];
            int[] Right = new int[n - mid];
                for (int i = 0; i < mid; i++)
            {
                Left[i] = MyArray[i];
            }

            for (int i = mid; i < n; i++)
            {
                Right[i - mid] = MyArray[i];
            }
            Mergesort(Left);
            Mergesort(Right);
            Merge(Left, Right, MyArray);
            }
            return MyArray;

        }
        public void Merge(int[] Left, int[] Right, int[] MyArray)
        {
            int i = 0;
            int j = 0;           
            int k = 0;           
            while (i < Left.Length && j < Right.Length)
            {
                if (Left[i] <= Right[j])
                {
                    MyArray[k] = Left[i];
                    i += 1;
                }
                else
                {
                    MyArray[k] = Right[j];
                    j += 1;
                }
                k += 1;
            }

            while (i < Left.Length)
            {
                MyArray[k] = Left[i];
                i++;
                k++;
            }
            while (j < Right.Length)
            {
                MyArray[k] = Right[j];
                j++;
                k++;
            }
        }
   

    }
   
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.sorting.QuickSort
{
    public class QuickSortClass
    {

        //QuickSort method
        public int [] QuickSort(int[] myArray,int Left,int Right)
        {
            if (Left<Right)
            {
                int position = Partition(myArray,Left,Right);
                QuickSort(myArray,Left,position-1);
                QuickSort(myArray,position+1,Right);
            }
            return myArray;
        }
        //Partition method
        public int Partition (int [] myArray,int Left,int Right)
        {
            int pivot = myArray[Right];
            int Low = Left - 1;
            for (int i = Left; i < Right; i++)
            {
                if (myArray[i] <= pivot)
                {
                    Low++;
                    Swap(myArray,i,Low);
                }
            }
            Swap(myArray,Right,Low+1);
            return Low + 1;
        }
    //    // Swap Method
        public void Swap(int[] myArray,int i,int low)
        {
            int temp = myArray[i];
            myArray[i] = myArray[low];
            myArray[low] = temp;
            
        }
  


    }
}

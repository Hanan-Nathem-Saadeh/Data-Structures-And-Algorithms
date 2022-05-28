using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.InsertionSort
{
    public class InsertionSortClass
    {


        public int[] InsertionSort(int[] arr)
        {
            try
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int j = i - 1;
                    int temp = arr[i];
                    while (j >= 0 && temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = temp;
                }
                return arr;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}

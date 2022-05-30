using System;
using Xunit;
using ConsoleApp.Challenges.sorting.QuickSort;

namespace TestQuickSort
{
    public class TestQuickSort
    {
        QuickSortClass quickSort = new QuickSortClass();
           
            [Fact]
            public void Test1()
            {
                int[] array = { 20, 14, 1, 5, 8 };
                int[] result = { 1, 5, 8, 14, 20 };
                Assert.Equal(result, quickSort.QuickSort(array,0,array.Length-1));
            }
        [Fact]
        public void Test2()
        {
            int[] array = { 100, 20, 32, -56, 0 };
            int[] result = { -56, 0, 20, 32, 100 };
            Assert.Equal(result, quickSort.QuickSort(array, 0, array.Length - 1));
        } 
        [Fact]
        public void Test3()
        {
            int[] array = { 0, 0, 0, 0, 0 };
            int[] result = { 0, 0, 0, 0, 0 };
            Assert.Equal(result, quickSort.QuickSort(array, 0, array.Length - 1));
        }
        [Fact]
        public void Test4()
        {
            int[] array = { -20, -100, -12, -34, 0 };
            int[] result = { -100, -34, -20, -12, 0 };
            Assert.Equal(result, quickSort.QuickSort(array, 0, array.Length - 1));
        }
        [Fact]
        public void Test5()
        {
            int[] array = { 20, 18, 12, 8, 5,-2 };
            int[] result = { -2, 5, 8, 12, 18 ,20 };
            Assert.Equal(result, quickSort.QuickSort(array, 0, array.Length - 1));
        }
        [Fact]
        public void Test6()
        {
            int[] array = { 5, 12, 7, 5, 5, 7 };
            int[] result = { 5, 5, 5, 7, 7, 12 };
            Assert.Equal(result, quickSort.QuickSort(array, 0, array.Length - 1));
        }
        [Fact]
        public void Test7()
        {
            int[] array = { 2, 3, 5, 7, 13, 11 };
            int[] result = { 2, 3, 5, 7, 11, 13 };
            Assert.Equal(result, quickSort.QuickSort(array, 0, array.Length - 1));
        }
       

    }
}

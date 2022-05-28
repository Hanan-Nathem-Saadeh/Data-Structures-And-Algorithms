using ConsoleApp.Challenges.MergeSort;
using System;
using Xunit;

namespace TestMergeSort
{
    public class UnitTest1
    {
        MergeSortClass MergeSort = new MergeSortClass();

            [Fact]
            public void Test1()
            {
            int[] Array1 = { 100, 50, 11, 211, 0 };
            int[] ArrayResult = { 0, 11, 50, 100, 211 };
           
            Assert.Equal(MergeSort.Mergesort(Array1), ArrayResult);
         
            }

        [Fact]
        public void Test2()
        {
            int[] Array1 = { 10, 8, 6, 4, 2 };
            int[] ArrayResult = { 2, 4, 6, 8, 10 };
            
            Assert.Equal(ArrayResult, MergeSort.Mergesort(Array1));
        }
        [Fact]
        public void Test3()
        {
            int[] Array1 = { 14, 100, 23, 4, 1 };
            int[] ArrayResult = { 1, 4, 14, 23, 100 };

            Assert.Equal(ArrayResult, MergeSort.Mergesort(Array1));
        }
        [Fact]
        public void Test4()
        {
            int[] Array1 = { -7, -100, -23 , -4, 1 };
            int[] ArrayResult = { -100, -23, -7, -4, 1 };

            Assert.Equal(ArrayResult, MergeSort.Mergesort(Array1));
        }
    }
}

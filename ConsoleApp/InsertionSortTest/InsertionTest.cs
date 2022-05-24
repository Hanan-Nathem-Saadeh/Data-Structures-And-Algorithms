using System;
using Xunit;
using ConsoleApp.Challenges.InsertionSort;
namespace InsertionSortTest
{
    public class InsertionTest
    {
        InsertionSortClass insertionSort = new InsertionSortClass();
        //Test Psitive values
        [Fact]
        public void Test1()
        {
            int[] array = { 20, 14, 1, 5, 8 };
            int[] result = { 1, 5, 8, 14, 20 };
            Assert.Equal(result, insertionSort.InsertionSort(array));
        }
        // test possitive and negative values
        [Fact]
        public void Test2()
        {
            int[] array = { 100, 20, 32, -56, 0 };
            int[] result = { -56, 0, 20, 32, 100 };
            Assert.Equal(result, insertionSort.InsertionSort(array));
        }
        // test zeros
        [Fact]
        public void Test3()
        {
            int[] array = { 0, 0, 0, 0, 0 };
            int[] result = { 0, 0, 0, 0, 0 };
            Assert.Equal(result, insertionSort.InsertionSort(array));
        }
        // Test negative values
        [Fact]
        public void Test4()
        {
            int[] array = { -20, -100, -12, -34, 0 };
            int[] result = { -100, -34, -20, -12, 0 };
            Assert.Equal(result, insertionSort.InsertionSort(array));
        }

    }
}


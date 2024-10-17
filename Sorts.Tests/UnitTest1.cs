using NUnit.Framework;
using System;
using ConsoleApp1;

namespace Sorts.Tests
{
    [TestFixture]
    public class SortingTests
    {
        private static Random random = new Random();

        private int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10000);
            }
            return array;
        }

        private bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                    return false;
            }
            return true;
        }

        [Test]
        public void TestBubbleSort()
        {
            var array = GenerateRandomArray(1000);
            SortingAlgorithms.BubbleSort(array);
            Assert.IsTrue(IsSorted(array));
        }

        [Test]
        public void TestSelectionSort()
        {
            var array = GenerateRandomArray(1000);
            SortingAlgorithms.SelectionSort(array);
            Assert.IsTrue(IsSorted(array));
        }

        [Test]
        public void TestQuickSort()
        {
            var array = GenerateRandomArray(1000);
            SortingAlgorithms.QuickSort(array, 0, array.Length - 1);
            Assert.IsTrue(IsSorted(array));
        }
    }
}

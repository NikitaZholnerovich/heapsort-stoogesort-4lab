using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_PPVS_
{
    public class Stoogesort
    {
        public void Swap<T>(ref T a, ref T b) where T : IComparable
        {
            var t = a;
            a = b;
            b = t;
        }

        public T[] StoogeSort<T>(T[] array, int startIndex, int endIndex) where T : IComparable
        {
            if (array[startIndex].CompareTo(array[endIndex]) > 0)
            {
                Swap(ref array[startIndex], ref array[endIndex]);
            }

            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSort(array, startIndex, endIndex - len);
                StoogeSort(array, startIndex + len, endIndex);
                StoogeSort(array, startIndex, endIndex - len);
            }

            return array;
        }

        public T[] StoogeSort<T>(T[] array) where T : IComparable
        {
            return StoogeSort(array, 0, array.Length - 1);
        }
    }
}

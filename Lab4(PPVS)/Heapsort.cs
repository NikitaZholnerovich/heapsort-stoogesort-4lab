using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_PPVS_
{
    public class Heapsort
    {
        public void HeapSort<T>(T[] arr, int n) where T:IComparable
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }
        }

        private void Heapify<T>(T[] arr, int n, int i) where T:IComparable
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            //if (left < n && arr[left] > arr[largest])
            //    largest = left;
            //if (right < n && arr[right] > arr[largest])
            //    largest = right;

            if (left < n && arr[left].CompareTo(arr[largest])>0)
                largest = left;

            if (right < n && arr[right].CompareTo( arr[largest])>0)
                largest = right;

            if (largest != i)
            {
                T swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }

        }
    }
}
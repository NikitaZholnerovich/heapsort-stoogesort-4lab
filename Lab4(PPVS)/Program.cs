using System;

namespace Lab4_PPVS_
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomGenerator = new RandomGenerator();

            var stoogsort = new Stoogesort();
            var heapsort = new Heapsort();

            var randomIntArray = randomGenerator.GenerateRandomIntArray();
            var randomWordsArray = randomGenerator.GenerateRandomWordsArray();
            Car[] customClassArray = {
                new Car {Name="BMW",Speed=360 },
                new Car { Name = "Audi",Speed = 200 },
                new Car { Name = "Mercedes",Speed = 400 },
                new Car { Name = "Opel",Speed = 120 },
                new Car { Name = "Reno",Speed = 150 }
            };

            Sort("Stooge Sort Integers", randomIntArray, (arr) => stoogsort.StoogeSort(arr));
            Sort("Stooge Sort Words", randomWordsArray, (arr) => stoogsort.StoogeSort(arr));
            Sort("Stooge Sort Custom", customClassArray, (arr) => stoogsort.StoogeSort(arr));

            // Need to recreate arrays, because they were already sorted
            randomIntArray = randomGenerator.GenerateRandomIntArray();
            randomWordsArray = randomGenerator.GenerateRandomWordsArray();
            customClassArray = new Car[] {
                new Car {Name="BMW",Speed=360 },
                new Car { Name = "Audi",Speed = 200 },
                new Car { Name = "Mercedes",Speed = 400 },
                new Car { Name = "Opel",Speed = 120 },
                new Car { Name = "Reno",Speed = 150 }
            };

            Sort("Heap Sort Integers", randomIntArray, (arr) => heapsort.HeapSort(arr, arr.Length));
            Sort("Heap Sort Words", randomWordsArray, (arr) => heapsort.HeapSort(arr, arr.Length));
            Sort("Heap Sort Custom", customClassArray, (arr) => heapsort.HeapSort(arr, arr.Length));

            Console.ReadKey();                       
        }



        static void Sort<T>(string name, T[] arr, Action<T[]> sort)
        {
            int n = arr.Length;


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(name);
            Console.WriteLine();
            Console.ResetColor();


            Console.Write("\nInitial array is:\n");
            for (var i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            sort(arr);

            Console.Write("\n\nSorted Array is:\n");
            for (var i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\n");
        }
       
    }
}

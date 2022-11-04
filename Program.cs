using System;

namespace AlgmorithicSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int[] inputArray = { 5, 7, 10, 2, 3, 19, 23, 54, 27, 69, 100, 234, 126, 189, 1, 0, 123123, 834789, 923487, 12356173, 1273213, 17263, 8734, 347, 192783};
            int[] inputArray2 = { 5, 7, 10, 2, 3, 19, 23, 54, 27, 69, 100, 234, 126, 189, 1, 0, 123123, 834789, 923487, 12356173, 1273213, 17263, 8734, 347, 192783 };
            int[] inputArray3 = { 5, 7, 10, 2, 3, 19, 23, 54, 27, 69, 100, 234, 126, 189, 1, 0, 123123, 834789, 923487, 12356173, 1273213, 17263, 8734, 347, 192783 };
            int[] inputArray4 = { 5, 7, 10, 2, 3, 19, 23, 54, 27, 69, 100, 234, 126, 189, 1, 0, 123123, 834789, 923487, 12356173, 1273213, 17263, 8734, 347, 192783 };
            int[] arr = { 5, 7, 10, 2, 3, 19, 23, 54, 27, 69, 100, 234, 126, 189, 1, 0, 123123, 834789, 923487, 12356173, 1273213, 17263, 8734, 347, 192783 };
            int[] inputArray5 = { 5, 7, 10, 2, 3, 19, 23, 54, 27, 69, 100, 234, 126, 189, 1, 0, 123123, 834789, 923487, 12356173, 1273213, 17263, 8734, 347, 192783 };
            int key = 5;
            int key2 = 5;
            Console.WriteLine("Binary Search");
            watch.Start();
            Console.WriteLine(BinarySearch.BinarySearchIterative(inputArray, key));
            watch.Stop();
            Console.WriteLine($"\nExecution Time: {watch.Elapsed} ms");
            Console.WriteLine("---------------------------------------------------------------------------- \n\n");


            Console.WriteLine("Bubble Sort");
            watch.Start();
            BubbleSearch.BubbleSort(inputArray2);
            watch.Stop();
            Console.WriteLine($"\n\nExecution Time: {watch.Elapsed} ms");
            Console.WriteLine("---------------------------------------------------------------------------- \n\n");


            Console.WriteLine("Linear Search");
            watch.Start();
            Console.WriteLine(LinearSearch.LinearSearch2(inputArray3, key2));
            watch.Stop();
            Console.WriteLine($"\nExecution Time: {watch.Elapsed} ms");
            Console.WriteLine("---------------------------------------------------------------------------- \n\n");


            Console.WriteLine("Selection Sort");
            watch.Start();
            SelectionSort.Sort(inputArray4);
            watch.Stop();
            Console.WriteLine($"\nExecution Time: {watch.Elapsed} ms");
            Console.WriteLine("---------------------------------------------------------------------------- \n\n");


            Console.WriteLine("Quick Sort");
            watch.Start();
            int right = arr.Length - 1;
            int n = arr.Length, i;
            QuickSort.quickSort(arr, 0, right);
            Console.Write("Sorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            watch.Stop();
            Console.WriteLine($"\nExecution Time: {watch.Elapsed} ms");
            Console.WriteLine("---------------------------------------------------------------------------- \n\n");


            Console.WriteLine("Merge Sort");
            watch.Start();
            MegeSort.mergeSort(inputArray5, 0, n-1);
            watch.Stop();
            int k = inputArray5.Length, j;
            Console.Write("Sorted Array is: ");
            for (j = 0; j < k; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine($"\nExecution Time: {watch.Elapsed} ms");
            Console.WriteLine("---------------------------------------------------------------------------- \n\n");
        }
    }
}

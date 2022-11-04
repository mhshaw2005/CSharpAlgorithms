using System;
using System.Collections.Generic;
using System.Text;

namespace AlgmorithicSearch
{
    class BubbleSearch
    {

        public static void BubbleSort(int[] arr)
        {
            // Creates a temp variabe to hold the int that will move
            int temp;
            // Interates through the array to get a num to compare
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                // iterates through rest of list to compare the numbers
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    // Checks the 2 numbers and moves them if the first is lower if the num is in a greater position
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            // Prints out the sorted array
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AlgmorithicSearch
{
    class BinarySearch
    {

        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            // Sorts array
            Array.Sort(inputArray);
            // Creates the min index and max index to look through
            int min = 0;
            int max = inputArray.Length - 1;
            // Creates the while loop that goes until there is not numbers left in the range of the min and max
            while (min <= max)
            {
                // Finds the middle of the current range on the array
                int mid = (min + max) / 2;
                // If the Key is equal to the middle number it returns the middle index + 1
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                // If the key is less than the middle number then the array is shrunk down to all numbers to the left of the middle
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                // If the key is greater than the middle number then the array is shrunk down to all numbers to the right of the middle
                else
                {
                    min = mid + 1;
                }
            }
            // If the number is not in the array it returns Nil
            return "Nil";
        }
    }
}

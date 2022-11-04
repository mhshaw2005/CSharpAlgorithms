using System;
using System.Collections.Generic;
using System.Text;

namespace AlgmorithicSearch
{
    class LinearSearch
    {
        public static int LinearSearch2(int[] arr, int key)
        {
            int num = 0;
            while (num <= arr.Length)
            {
                if (arr[num] == key)
                {
                    return num;
                }
                num++;
            }
            return -1;
        }
    }
}

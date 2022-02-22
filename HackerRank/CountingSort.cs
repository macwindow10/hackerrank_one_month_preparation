using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    class CountingSort
    {
        public static void execute()
        {
            List<int> arr = new List<int>();
            arr.AddRange(new int[] {
                1, 1, 3, 2, 1
            });
            List<int> result = countingSort(arr);
        }

        public static List<int> countingSort(List<int> arr)
        {
            int[] result = new int[100];
            for (int i = 0; i < arr.Count; i++)
            {
                result[arr[i]]++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            return new List<int>(result);
        }
    }
}

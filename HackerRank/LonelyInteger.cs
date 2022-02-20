using System;
using System.Collections.Generic;

namespace HackerRank
{
    class LonelyInteger
    {
        public static void execute()
        {
            List<int> A = new List<int>();
            A.AddRange(new int[] { 1, 2, 3, 4, 1, 2, 3 });
            int result = lonelyinteger(A);
        }

        public static int lonelyinteger(List<int> a)
        {
            int result = 0;
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (keyValues.ContainsKey(a[i]))
                {
                    int c = keyValues[a[i]];
                    c++;
                    keyValues[a[i]] = c;
                }
                else
                {
                    keyValues.Add(a[i], 1);
                }
            }

            foreach (var dd in keyValues)
            {
                if (dd.Value == 1)
                {
                    result = dd.Key;
                    break;
                }
            }
            Console.WriteLine(result);
            return result;
        }

    }
}

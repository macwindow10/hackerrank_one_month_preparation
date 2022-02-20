using System;
using System.Collections.Generic;

namespace HackerRank
{
    class MatchingStrings
    {
        public static void execute()
        {
            List<string> strings = new List<string>();
            List<string> queries = new List<string>();

            strings.AddRange(new string[] { "aba", "baba", "aba", "xzxb" });
            queries.AddRange(new string[] { "aba", "xzxb", "ab" });
            List<int> result = matchingStrings(strings, queries);
        }

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>(queries.Count);

            for (int i = 0; i < queries.Count; i++)
            {
                int c = 0;
                int lastIndex = Array.IndexOf(strings.ToArray(), queries[i]);
                while (lastIndex != -1)
                {
                    c++;
                    lastIndex = Array.IndexOf(strings.ToArray(), queries[i], lastIndex + 1);
                }

                result.Add(c);
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Pangram
    {
        public static void execute()
        {
            String s = "We promptly judged antique ivory buckles for the next prize";
            String result = pangrams(s);
        }

        public static string pangrams(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            keyValuePairs.Add('a', 0);
            keyValuePairs.Add('b', 0);
            keyValuePairs.Add('c', 0);
            keyValuePairs.Add('d', 0);
            keyValuePairs.Add('e', 0);
            keyValuePairs.Add('f', 0);
            keyValuePairs.Add('g', 0);
            keyValuePairs.Add('h', 0);
            keyValuePairs.Add('i', 0);
            keyValuePairs.Add('j', 0);
            keyValuePairs.Add('k', 0);
            keyValuePairs.Add('l', 0);
            keyValuePairs.Add('m', 0);
            keyValuePairs.Add('n', 0);
            keyValuePairs.Add('o', 0);
            keyValuePairs.Add('p', 0);
            keyValuePairs.Add('q', 0);
            keyValuePairs.Add('r', 0);
            keyValuePairs.Add('s', 0);
            keyValuePairs.Add('t', 0);
            keyValuePairs.Add('u', 0);
            keyValuePairs.Add('v', 0);
            keyValuePairs.Add('w', 0);
            keyValuePairs.Add('x', 0);
            keyValuePairs.Add('y', 0);
            keyValuePairs.Add('z', 0);

            keyValuePairs.Add(' ', 0);

            for (int i = 0; i < s.Length; i++)
            {
                keyValuePairs[Char.ToLower(s[i])] = keyValuePairs[Char.ToLower(s[i])] + 1;
            }

            bool pangram = true;
            foreach (var v in keyValuePairs)
            {
                if (v.Value == 0)
                {
                    pangram = false;
                }
            }
            return (pangram) ? "pangram" : "not pangram";
        }

    }
}

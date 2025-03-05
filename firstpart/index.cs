using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static string LongestUniqueSubstring(string s)
        {
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int start = 0; 
            string longestSubstr = "";  

            for (int end = 0; end < s.Length; end++)
            {
                // Si encontramos un car]acter repetido, movemos el inicio de la subcadena
                if (charIndexMap.ContainsKey(s[end]) && charIndexMap[s[end]] >= start)
                {
                    start = charIndexMap[s[end]] + 1;
                }

                // Actualizamos la posici[on del caracter actual
                charIndexMap[s[end]] = end;

                // Actualizamos la subcadena m[as larga
                if (end - start + 1 > longestSubstr.Length)
                {
                    longestSubstr = s.Substring(start, end - start + 1);
                }
            }

            return longestSubstr;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(LongestUniqueSubstring("abcabcbb"));
            Console.WriteLine(LongestUniqueSubstring("bbbbb"));    
            Console.WriteLine(LongestUniqueSubstring("pwwkew"));
    }
}

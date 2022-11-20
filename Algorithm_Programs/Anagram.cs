using System;

namespace Algorithm_Programs
{
    public class Anagram
    {
        public void CheckAnagram(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the words are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the Words are not Anagrams");
            }
        }
    }
}

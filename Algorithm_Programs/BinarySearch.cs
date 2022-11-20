using Newtonsoft.Json;
using System;
using System.Collections;

namespace Algorithm_Programs
{
    public class BinarySearch
    {
        public string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";

        public void BinarySearchWordCheck(string str)
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.SerializeObject(words);

            List<string> list = word.Split(',').ToList<string>();
            list.Sort();
            int pos = list.BinarySearch(str);

            if (pos >= 0)
            {
                Console.WriteLine($"{str} found at position " + pos + "\n");
            }
            else
            {
                Console.WriteLine($"{str} not found\n");
            }

        }
    }
}

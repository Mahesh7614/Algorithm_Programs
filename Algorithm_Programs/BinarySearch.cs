using Newtonsoft.Json;
using System;
using System.Collections;

namespace Algorithm_Programs
{
    public class BinarySearch<M> 
    {
        private string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";

        public void BinarySearchWordCheck(M str) 
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');
            Array.Sort(wordsArray);
            int pos = Array.BinarySearch(wordsArray,str);

            if (pos+1 >= 0)
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

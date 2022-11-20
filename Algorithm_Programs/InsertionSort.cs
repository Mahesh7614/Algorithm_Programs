using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Algorithm_Programs
{
    public class InsertionSort
    {
        public string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";
        public void ArrayData()
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');

            Console.WriteLine("Unsorted Array :: ");
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
            SortUsinhgInsertionSort(wordsArray);
        }
        public void SortUsinhgInsertionSort(string[] wordsArray)
        {

            for (int i = 1; i < wordsArray.Length; ++i)
            {
                string key = wordsArray[i];
                int j = i - 1;

                while (j >= 0 && wordsArray[j].CompareTo(key) < 0)
                {
                    wordsArray[j + 1] = wordsArray[j];
                    j = j - 1;
                }
                wordsArray[j + 1] = key;
                Console.WriteLine("Sorted Array Using Insertion Sort ::");
            }
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
            SortUsinhgInsertionSort(wordsArray);
        }
    }
}

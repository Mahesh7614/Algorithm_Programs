using Newtonsoft.Json;
using System;

namespace Algorithm_Programs
{
    public class BubbleSort
    {
        public string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";

        public void ArrayData()
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');

            Console.WriteLine("***************************** Unsorted Array *****************************");
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
            SortUsinhgBubbleSort(wordsArray);
        }
        public void SortUsinhgBubbleSort(string[] wordsArray)
        {
            for (int j = 0; j < wordsArray.Length - 1; j++)
            {
                for (int i = j + 1; i < wordsArray.Length; i++)
                {
                    if (wordsArray[j].CompareTo(wordsArray[i]) > 0)
                    {
                        string temp = wordsArray[j];
                        wordsArray[j] = wordsArray[i];
                        wordsArray[i] = temp;
                    }
                }
            }

            Console.WriteLine("\n***************************** Sorted Array Using Bubble Sort *****************************");
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
        }
    }
}

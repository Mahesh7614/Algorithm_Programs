using Newtonsoft.Json;
using System;

namespace Algorithm_Programs
{
    public class BubbleSort
    {
        private string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";

        public void ArrayData()
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');

            Console.WriteLine("***************************** Unsorted Array *****************************");
            Display(wordsArray);
            SortUsinhgBubbleSort(wordsArray);
            Console.WriteLine("\n***************************** Sorted Array Using Bubble Sort *****************************");
            Display(wordsArray);
        }
        private void Display(string[] wordsArray)
        {
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
        }
        private void SortUsinhgBubbleSort(string[] wordsArray)
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
        }
    }
}

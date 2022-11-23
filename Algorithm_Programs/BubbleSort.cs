using Newtonsoft.Json;
using System;

namespace Algorithm_Programs
{
    public class BubbleSort<M> where M : IComparable
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
        private void Display<M>(M[] wordsArray)
        {
            foreach (M car in wordsArray)
            {
                Console.WriteLine(car);
            }
        }
        private void SortUsinhgBubbleSort<M>(M[] wordsArray) where M : IComparable
        {
            for (int j = 0; j < wordsArray.Length - 1; j++)
            {
                for (int i = j + 1; i < wordsArray.Length; i++)
                {
                    if (wordsArray[j].CompareTo(wordsArray[i]) > 0)
                    {
                        M temp = wordsArray[j];
                        wordsArray[j] = wordsArray[i];
                        wordsArray[i] = temp;
                    }
                }
            }            
        }
    }
}

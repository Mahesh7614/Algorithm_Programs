using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Algorithm_Programs
{
    public class InsertionSort<M>
    {
        private string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";
        public void ArrayData()
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');

            Console.WriteLine("***************************** Unsorted Array *****************************");
            Display(wordsArray);
            SortUsinhgInsertionSort(wordsArray);
            Console.WriteLine("\n***************************** Sorted Array Using Insertion Sort *****************************");
            Display(wordsArray);
        }
        private void Display<M>(M[] wordsArray)
        {
            foreach (M car in wordsArray)
            {
                Console.WriteLine(car);
            }
        }
        private void SortUsinhgInsertionSort<M>(M[] wordsArray) where M : IComparable
        {

            for (int i = 1; i < wordsArray.Length; i++)
            {
                M key = wordsArray[i];
                int j = i - 1;

                while ((j >= 0) && (wordsArray[j].CompareTo(key) > 0))
                {
                    wordsArray[j + 1] = wordsArray[j];
                    j--;
                }
                wordsArray[j + 1] = key;                
            }
        }
    }
}

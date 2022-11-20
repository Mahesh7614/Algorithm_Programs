using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Algorithm_Programs
{
    public class MergeSort
    {
        private string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Algorithm_Programs\Algorithm_Programs\JSON\BinarySearchData.json";
        public void ArrayData()
        {
            string words = File.ReadAllText(filePath);
            string word = JsonConvert.DeserializeObject<string>(words);

            string[] wordsArray = word.Split(',');
            Console.WriteLine("\n***************************** Unsorted Array *****************************");
            Display(wordsArray);
            sort(wordsArray, 0, wordsArray.Length-1);
            Console.WriteLine("\n***************************** Sorted Array Using Merge Sort *****************************");
            Display(wordsArray);
        }
        private void Display(string[] wordsArray)
        {
            foreach (string car in wordsArray)
            {
                Console.WriteLine(car);
            }
        }
        private void SortUsinhgMergeSort(string[] wordsArray, int initialPosition, int MiddlePosition, int length)
        {
            int n1 = MiddlePosition - initialPosition + 1;
            int n2 = length - MiddlePosition;

            string[] L = new string[n1];
            string[] R = new string[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = wordsArray[initialPosition + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = wordsArray[MiddlePosition + 1 + j];
            }

            i = 0;
            j = 0;

            int k = initialPosition;
            while (i < n1 && j < n2)
            {
                if (L[i].CompareTo(R[j]) <=0)
                {
                    wordsArray[k] = L[i];
                    i++;
                }
                else
                {
                    wordsArray[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                wordsArray[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                wordsArray[k] = R[j];
                j++;
                k++;
            }
        }
        private void sort(string[] wordsArray, int initialPosition, int length)
        {
            if (initialPosition < length)
            {
                int MiddlePosition = initialPosition + (length - initialPosition) / 2;
                sort(wordsArray, initialPosition, MiddlePosition);
                sort(wordsArray, MiddlePosition + 1, length);
                SortUsinhgMergeSort(wordsArray, initialPosition, MiddlePosition, length);
            }
        }
    }
}

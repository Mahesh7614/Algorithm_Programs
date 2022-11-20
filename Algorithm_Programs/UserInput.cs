using System;

namespace Algorithm_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Permutation ");
            Console.WriteLine("Enter - 2. Binary Search ");
            Console.WriteLine("Choose - 3. Insertion Sort ");
            Console.WriteLine("Choose - 4. Bubble Sort ");
            Console.WriteLine("Choose - 5. Merge Sort ");

            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("\nEnter String for Permutation : ");
                    string str = Console.ReadLine();
                    Console.WriteLine("Using Recursion Method Permutations are :: ");
                    Permutations.RecursionPermutation(str, 0, str.Length - 1); // using Recursion Menthod
                    Console.WriteLine("Using Iterative Method Permutations are :: ");
                    Permutations.IterationPermutation(str); // using iterative Menthod
                    break;

                case 2:
                    Console.Write("\nEnter the Car Name which you want to search Using Binary Search : ");
                    string cars = Console.ReadLine();
                    BinarySearch search = new BinarySearch();
                    search.BinarySearchWordCheck(cars);
                    break;

                case 3:
                    InsertionSort insertion = new InsertionSort();
                    insertion.ArrayData();
                    break;

                case 4:
                    BubbleSort bubble = new BubbleSort();
                    bubble.ArrayData();
                    break;

                case 5:
                    MergeSort merge = new MergeSort();
                    merge.ArrayData();
                    break;
            }
        }
    }
}

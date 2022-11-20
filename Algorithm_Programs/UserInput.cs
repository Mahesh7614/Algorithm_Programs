using System;

namespace Algorithm_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Permutation ");
            Console.WriteLine("Enter - 2. Binary Search ");


            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("\nEnter String for Permutation : ");
                    string str = Console.ReadLine();
                    int Length = str.Length;
                    Permutations permutations = new Permutations();
                    Console.WriteLine("Using Recursion Method Permutations are :: ");
                    permutations.Recursionpermutation(str, 0, Length - 1); // using Recursion Menthod
                    Console.WriteLine("Using Iterative Method Permutations are :: ");
                    permutations.IterationPermutation(str); // using iterative Menthod
                    break;

                case 2:
                    Console.Write("\nEnter the Car Name which you want to search Using Binary Search : ");
                    string cars = Console.ReadLine();
                    BinarySearch search = new BinarySearch();
                    search.BinarySearchWordCheck(cars);
                    break;
            }
        }
    }
}

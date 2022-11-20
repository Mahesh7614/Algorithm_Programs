using System;

namespace Algorithm_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Permutation ");

            Console.Write("Enter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("\nEnter String for Permutation");
                    string str = Console.ReadLine();
                    int Length = str.Length;
                    Permutations permutations = new Permutations();
                    Console.WriteLine("Using Recursion Method Permutations are :: ");
                    permutations.Recursionpermutation(str, 0, Length - 1); // using Recursion Menthod
                    Console.WriteLine("Using Iterative Method Permutations are :: ");
                    permutations.IterationPermutation(str); // using iterative Menthod
                    break;
            }
        }
    }
}

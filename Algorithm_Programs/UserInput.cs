using System;

namespace Algorithm_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Permutation ");

            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("\nEnter String for Permutation : ");
                    string str = Console.ReadLine();
                    int Length = str.Length;
                    Console.WriteLine("Using Recursion Method Permutations are :: ");
                    Permutations.RecursionPermutation(str, 0, Length - 1); // using Recursion Menthod
                    Console.WriteLine("Using Iterative Method Permutations are :: ");
                    Permutations.IterationPermutation(str); // using iterative Menthod
                    break;
            }
        }
    }
}

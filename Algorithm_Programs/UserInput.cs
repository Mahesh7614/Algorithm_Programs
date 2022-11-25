using System;

namespace Algorithm_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Permutation ");
            Console.WriteLine("Enter - 2. Binary Search ");
            Console.WriteLine("Enter - 3. Insertion Sort ");
            Console.WriteLine("Enter - 4. Bubble Sort ");
            Console.WriteLine("Enter - 5. Merge Sort ");
            Console.WriteLine("Enter - 6. Check Anagram ");
            Console.WriteLine("Enter - 7. Prime Number within Range ");
            Console.WriteLine("Enter - 8. Prime Number within Range its Anagram and Palindrome ");
            Console.WriteLine("Enter - 9. Guess Number Game");
            Console.WriteLine("Enter - 10. Task Schedule");
            Console.WriteLine("Enter - 11. Message Demonstration");

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
                    BinarySearch<string> search = new BinarySearch<string>();
                    search.BinarySearchWordCheck(cars);
                    break;

                case 3:
                    InsertionSort<string> insertion = new InsertionSort<string>();
                    insertion.ArrayData();
                    break;

                case 4:
                    BubbleSort<string> bubble = new BubbleSort<string>();
                    bubble.ArrayData();
                    break;

                case 5:
                    MergeSort<string> merge = new MergeSort<string>();
                    merge.ArrayData();
                    break;

                case 6:
                    Console.Write("Enter 1st Word : ");
                    string str1 = Console.ReadLine();
                    Console.Write("Enter 2nd Word : ");
                    string str2 = Console.ReadLine();
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram(str1,str2);
                    break;

                case 7:
                    Console.Write("Starting number of range: ");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ending number of range : ");
                    int End = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The prime numbers between {0} and {1} are : \n", start, End);
                    PrimeNumber prime = new PrimeNumber();
                    prime.CheckPrimeNumber(start, End);
                    break;

                case 8:
                    Console.Write("Starting number of range: ");
                    int startNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ending number of range : ");
                    int endNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The prime numbers between {0} and {1} are : \n", startNo, endNo);
                    PrimeNumberCheckAnagramAndPalindrome primeobj = new PrimeNumberCheckAnagramAndPalindrome();
                    primeobj.CheckPrimeNumber(startNo, endNo);
                    break;

                case 9:
                    Console.Write("Enter Highest value which you want guess number between 0 and that value : ");
                    int high = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Guess the Number between 0 and {high-1} : ");
                    Console.ReadLine();
                    FindYourNumber find = new FindYourNumber();
                    find.FindNumber(high);
                    break;

                case 10:
                    Console.Write("Enter the Number of Tasks : ");
                    int tasks = Convert.ToInt32(Console.ReadLine());
                    TaskSchedule task = new TaskSchedule();
                    task.TaskScheduling(tasks);
                    break;

                case 11:
                    MessageDemonstration message = new MessageDemonstration();
                    Console.Write("Enter First Name : ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name : ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Mobile Number with Country Code and - between them : ");
                    string mobileNumber = Console.ReadLine();
                    Console.Write("Enter Date : ");
                    string date = Console.ReadLine();
                    Console.WriteLine($"Hello {message.FirstNameAndLastName(firstName)}, We have your full\r" +
                        $"\nname as {message.FirstNameAndLastName(firstName)} {message.FirstNameAndLastName(lastName)} in our system. " +
                        $"your contact number is {message.MobileNumber(mobileNumber)}.\r\nPlease,let us know in case of any clarification" +
                        $" Thank you BridgeLabz {message.Date(date)}");
                    break;

            }
        }
    }
}

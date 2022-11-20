using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class PrimeNumberCheckAnagramAndPalindrome
    {
        public void CheckPrimeNumber(int startNo, int EndNo)
        {
            int count = 0;
            List<int> numbers = new List<int>();
            for (int num = startNo; num <= EndNo; num++)
            {
                bool flag = false;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag && num != 1)
                {
                    Console.WriteLine("{0} ", num); 
                    CheckPalindrome(num);
                    numbers.Add(num);
                    count++;
                }
            }
            Console.WriteLine($"Total Prime Numbers from {startNo} to {EndNo} are {count}");

            Console.WriteLine("************************** Anagram Numbers **************************");
            bool[] visited = new bool[numbers.Count];
            for (int i = 0; i < numbers.Count; i++) 
            {
                if (visited[i] == true)
                {
                    continue;
                }
                for (int j= 1; j < numbers.Count; j++)
                {
                    CheckAnagram(numbers[i], numbers[j], visited, j);
                }
            }
        }
        private void CheckAnagram(int num1, int num2, bool[] visited,int j)
        {

            char[] ch1 = Convert.ToString(num1).ToCharArray();
            char[] ch2 = Convert.ToString(num2).ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2 && num1 != num2)
            {
                visited[j] = true;
                Console.WriteLine($"{num1} and {num2} are Anagrams");
            }
        }
        private void CheckPalindrome(int num1)
        {
            int reverse = 0;
            int num2 = num1;
            while (num1 != 0)
            {
                int reminder = num1 % 10;
                reverse = reverse * 10;
                reverse = reminder + reverse;
                num1 = num1 / 10;

            }
            if (num2 == reverse)
            {
                Console.Write($"********** {num2} is Palindrome Number **********");
            }
        }
    }
}

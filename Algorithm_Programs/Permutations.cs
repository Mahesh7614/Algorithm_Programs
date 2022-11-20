using System;


namespace Algorithm_Programs
{
    public class Permutations
    {
        // Recursion Method
        public void Recursionpermutation(string str, int initialPositionStr, int Lengthstr)
        {
            if (initialPositionStr == Lengthstr)
                Console.WriteLine(str);
            else
            {
                for (int i = initialPositionStr; i <= Lengthstr; i++)
                {
                    str = Swap(str, initialPositionStr, i);
                    Recursionpermutation(str, initialPositionStr + 1, Lengthstr);
                    str = Swap(str, initialPositionStr, i);
                }
            }
        }
        public static string Swap(string str, int position1, int position2)
        {
            char temp;

            char[] charArray = str.ToCharArray();

            temp = charArray[position1];
            charArray[position1] = charArray[position2];
            charArray[position2] = temp;
            string s = new string(charArray);
            return s;
        }
        //Permutation in Iterative Way
        public void IterationPermutation(string str)
        {
            int number = str.Length;
            int fact = Factorial(number);

            for (int i = 0; i < fact; i++)
            {
                StringBuilder stringBuilder = new StringBuilder(str);
                int temp = i;

                for (int div = number; div >= 1; div--)
                {
                    int quotient = temp / div;
                    int remiander = temp % div;

                    Console.Write(stringBuilder[remiander]);
                    stringBuilder.Remove(remiander, 1);
                    temp = quotient;
                }
                Console.WriteLine();
            }
        }
        public int Factorial(int number)
        {
            int val = 1;
            for (int i = 2; i <= number; i++)
            {
                val *= i;
            }
            return val;
        }
    }
}


namespace Algorithm_Programs
{
    public class FindYourNumber
    {
        public void FindNumber(int high)
        {
            int low = 0, value = 0, count = 0;
            int[] array = new int[high];

            for (int i = 0; i < high; i++)
            {
                array[i] = value;
                value++;
            }
            while (low != high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("Enter 1 if no is between " + low + " and " + mid + "\nEnter 2 if no is between "
                        + (mid + 1) + " and " + high);
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    high = array[mid];
                }
                else if (input == 2)
                {
                    low = array[mid] + 1;
                }
                count++;
            }
            Console.Write("The Guessed Number is : " + low);
            Console.Write("\nNumber of times Question asked to the user is : " + count);
        }
    }
}

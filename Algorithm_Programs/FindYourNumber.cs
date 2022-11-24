
namespace Algorithm_Programs
{
    public class FindYourNumber
    {
        public void FindNumber(int high)
        {
            int low = 0,value = 0;
            int[] array = new int[high+1];
            for (int i = 0; i <= high; i++)
            {
                array[i] = value;
                value++;
            }
            while (low != high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("Enter 1 if no is between " + low + " and " + mid + "\nEnter 2 if no is between "
                        + (mid + 1) + " and " + high);
                int c = Convert.ToInt32(Console.ReadLine());
                mid = Array.BinarySearch(array, mid);
                if (c == 1)
                {
                    high = array[mid];
                }
                else if (c == 2) 
                {
                    low = array[mid] + 1;
                }
            }
            Console.Write("The Guessed Number is : " + low);
        }
    }
}

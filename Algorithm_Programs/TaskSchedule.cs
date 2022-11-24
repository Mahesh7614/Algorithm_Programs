
namespace Algorithm_Programs
{
    public class TaskSchedule
    {
        public void TaskScheduling(int tasks)
        {
            int[] dead = new int[tasks];
            int[] min = new int[tasks];
            for (int i = 1; i <= min.Length; i++)
            {
                Console.WriteLine("task " + i + " time");
                min[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("task " + i + " deadline");
                dead[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

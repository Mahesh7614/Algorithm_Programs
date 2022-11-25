
namespace Algorithm_Programs
{
    public class Task
    {
        public int noOfDays { get; set; }
        public int min { get; set; } = 0;
        public int maxDays { get; set; } = 0;
        public bool isCompleted { get; set; } = false;
    }
    public class TaskSchedule
    {
        public void TaskScheduling(int tasks)
        {
            bool isCompleted = false;
            List<Task> list = new List<Task>();

            for (int k = 1; k <= tasks; k++)
            {
                Console.WriteLine($"Enter the deadline for {k}  in Days");
                int days = Convert.ToInt32(Console.ReadLine());
                list.Add(new Task() { noOfDays = days });
            }
            int task = 1;
            for (int i = 0; i < list.Count; i++)
            {
                while (!list[i].isCompleted)
                {
                    if ((list[i].noOfDays * 9 * 60) >= list[i].min)
                    {
                        Random random = new Random();
                        int minutes = random.Next(0, (list[i].noOfDays * 9 * 60));
                        list[i].min = list[i].min + minutes;
                        list[i].maxDays++;
                    }
                    else if (list[i].maxDays > list[i].noOfDays && !list[i].isCompleted)
                    {
                        list[i].isCompleted = true;
                        list[i].maxDays = list[i].maxDays - list[i].noOfDays;
                        Console.WriteLine($"no of Days overshoot deadline of task {task} is {list[i].maxDays} ");
                        task++;
                    }

                }
            }
        }
    }
}

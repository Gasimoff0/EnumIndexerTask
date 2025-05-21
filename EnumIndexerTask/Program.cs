namespace EnumIndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            Person[] people = new Person[]
                {
                    new Person { Name = "Vusal",Surname = "Kerimov" , Age = 31 },
                    new Person { Name = "Ayxan",Surname = "Salamzade" , Age = 21 },
                    new Person { Name = "Mahabbat",Surname = "Gasimov" , Age = 19 },
                    new Person { Name = "Valeh",Surname = "Meherremov" , Age = 20 },
                };

            // IComparable
            //Array.Sort(people);

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}

            // operator ile
            //for(int i = 0; i < people.Length; i++)
            //{
            //    for(int j = 0; j < people.Length - 1 - 1; j++)
            //    {
            //        if (people[j] > people[j+1])
            //        {
            //            var change = people[j];
            //            people[j] = people[j+1];
            //            people[j+1] = change;
            //        }
            //    }
            //}
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion
            #region task2
            //TaskStatus status = TaskStatus.InProgress;

            //switch (status)
            //{
            //    case TaskStatus.NotStarted:
            //        Console.WriteLine("Task has not been started yet.");
            //        break;

            //    case TaskStatus.InProgress:
            //        Console.WriteLine("Task is currently in progress.");
            //        break;

            //    case TaskStatus.Completed:
            //        Console.WriteLine("Task has been completed successfully.");
            //        break;

            //    case TaskStatus.Cancelled:
            //        Console.WriteLine("Task has been cancelled.");
            //        break;
            //}
            #endregion
            Task task1 = new Task { Title = "Do homework", Status = TaskStatus.NotStarted };
            Task task2 = new Task { Title = "Clean room", Status = TaskStatus.InProgress };
            Task task3 = new Task { Title = "Read book", Status = TaskStatus.Completed };
            Console.WriteLine($"Task: {task1.Title}, Status: {task1.Status}");
            Console.WriteLine($"Task: {task2.Title}, Status: {task2.Status}");
            Console.WriteLine($"Task: {task3.Title}, Status: {task3.Status}");
            

        }

    }
}

using System;

namespace ConsoleApp1
{
    public class RunEnum2
    {
        public static void Run()
        {
            Schedule task1 = new Schedule("Team Meeting", WeekDays.Monday);
            Schedule task2 = new Schedule("Project Deadline", WeekDays.Friday);
            Schedule task3 = new Schedule("Workout", WeekDays.Sunday);

            task1.DisplaySchedule();
            task2.DisplaySchedule();
            task3.DisplaySchedule();
        }
    }
}

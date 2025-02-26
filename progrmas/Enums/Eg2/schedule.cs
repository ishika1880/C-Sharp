using System;

namespace ConsoleApp1
{
    public class Schedule
    {
        public string Task { get; set; }
        public WeekDays Day { get; set; }

        public Schedule(string task, WeekDays day)
        {
            Task = task;
            Day = day;
        }

        public void DisplaySchedule()
        {
            Console.WriteLine($"Task: {Task}, Scheduled on: {Day}");
        }
    }
}

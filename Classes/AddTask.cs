using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGatesOOPSession.Interfaces;

namespace TechGatesOOPSession.Classes
{
    public class AddTask : CheckStatus,ITaskExecution
    {
        private readonly Tasks _tasks;
        private TaskDetails _taskDetails;

        public AddTask(Tasks tasks)
        {
            _tasks = tasks;
        }
        public void Addtask(string Title,string Description, string DuoDate,string priority,StatusEnum status)
        {
            _taskDetails = new TaskDetails()
            {
                Title = Title,
                Description = Description,
                DuoDate = DuoDate,
                Priority = priority,
                Status = status
            };
            _tasks.AllTasks.Add(_taskDetails);
        }

        public void excute()
        {
            string title;
            string Description;
            string DuoDate;
            string priority;
            string InputStatus;
            StatusEnum Status= StatusEnum.unknown;

            Console.Write("Enter your task title : ");
            title = Console.ReadLine().ToLower();
            Console.Write("Enter your Description :");
            Description=Console.ReadLine().ToLower();
            Console.Write("Enter date: ");
            DuoDate = Console.ReadLine().ToLower();
            Console.Write("Enter the prority: ");
            priority=Console.ReadLine().ToLower();
            while (Status == StatusEnum.unknown)
            {
                Console.Write("Enter the status(pending, inprogress,completed): ");
                InputStatus=Console.ReadLine().ToLower();
                Status=Checkstatus(InputStatus);
            }
            Addtask(title,Description,DuoDate,priority,Status);
            Console.WriteLine("Your Task Added Successfully! ");
        }
    }
}

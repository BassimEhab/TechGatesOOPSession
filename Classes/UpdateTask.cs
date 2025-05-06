using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGatesOOPSession.Interfaces;

namespace TechGatesOOPSession.Classes
{
    internal class UpdateTask : CheckStatus, ITaskFound, ITaskExecution
    {
        private Tasks _tasks;
        public UpdateTask(Tasks tasks)
        {
            _tasks = tasks;
        }
        public void Updatetask(string Title,StatusEnum status)
        {
            var IsFound = _tasks.AllTasks.FirstOrDefault(t => t.Title == Title);
            if (IsFound != null)
            {
                IsFound.Status = status;
            }

        }
        public TaskDetails FoundTask(string Title)
        {
            return _tasks.AllTasks.FirstOrDefault(x => x.Title == Title);
        }
        public void excute()
        {
            string Title;
            string InputStatus;
            StatusEnum Status = StatusEnum.unknown;
            Console.Write("Enter the title of the task you want to update: ");
            Title = Console.ReadLine().ToLower();
            var Founded = FoundTask(Title);
            if (Founded != null)
            {
                while (Status == StatusEnum.unknown)
                {
                    Console.Write("Enter the new Status: ");
                    InputStatus = Console.ReadLine().ToLower();
                    Status = Checkstatus(InputStatus);
                }
                Founded.Status = Status;
                Console.WriteLine("Status updated successfully!");
            }
            else
            {
                Console.WriteLine("This Task is not in your list!");
            }
        }


    }
}

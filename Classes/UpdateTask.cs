using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGatesOOPSession.Interfaces;

namespace TechGatesOOPSession.Classes
{
    internal class UpdateTask :  ITaskExecutor
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

        public void Execute()
        {
            string Title;
            string InputStatus;
            StatusEnum Status = StatusEnum.unknown;
            Console.Write("Enter the title of the task you want to update: ");
            Title = Console.ReadLine().ToLower();
            var Founded = _tasks.FindTask(Title);
            if (Founded != null)
            {
                while (Status == StatusEnum.unknown)
                {
                    Console.Write("Enter the new Status: ");
                    InputStatus = Console.ReadLine().ToLower();
                    Status = CheckStatus.Checkstatus(InputStatus);
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

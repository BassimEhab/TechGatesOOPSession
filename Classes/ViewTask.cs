using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGatesOOPSession.Interfaces;

namespace TechGatesOOPSession.Classes
{
    internal class ViewTask : CheckStatus , ITaskExecution
    {
        private Tasks _tasks;
        public ViewTask(Tasks tasks)
        {
            _tasks = tasks;
        }

        /*
        public void Viewtasks()
        {
            foreach (var task in _tasks.AllTasks)
            {
                Console.WriteLine($"title {task.Title}");
                Console.WriteLine($"description {task.Description}");
                Console.WriteLine($"due date {task.DuoDate}");
                Console.WriteLine($"priority {task.Priority}");
                Console.WriteLine($"status {task.Status}");
            }
        }*/
        public void Viewtasks(StatusEnum status)
        {
            foreach (var task in _tasks.AllTasks)
            {
                if (task.Status == status)
                {
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine($"title [{task.Title}]");
                    Console.WriteLine($"description [{task.Description}]");
                    Console.WriteLine($"due date [{task.DuoDate}]");
                    Console.WriteLine($"priority [{task.Priority}]");
                    Console.WriteLine($"status [{task.Status}]");
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
            }
        }
        public void excute()
        {
            string InputStatus;
            StatusEnum Status = StatusEnum.unknown;
            Console.Write("Enter the status to see the tasks : ");
            InputStatus = Console.ReadLine().ToLower();
            while (Status == StatusEnum.unknown)
            {
                Status = Checkstatus(InputStatus);
            }
            Viewtasks(Status);
        }

    }
}

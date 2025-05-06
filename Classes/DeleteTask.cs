using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using TechGatesOOPSession.Interfaces;

namespace TechGatesOOPSession.Classes
{
    internal class DeleteTask : ITaskExecutor
    {
        private Tasks _tasks;
        public DeleteTask(Tasks tasks)
        {
            _tasks = tasks;
        }
        public void Deletetask(string title)
        {
            TaskDetails? IsFound = _tasks.AllTasks.FirstOrDefault((x) => x.Title == title);
            if (IsFound != null)
            {
                _tasks.AllTasks.Remove(IsFound);
            }
        }
        public void Execute()
        {
            string Title;
            Console.Write("Enter the title of the task you want to delete: ");
            Title = Console.ReadLine().ToLower();
            var Founded =_tasks.FindTask(Title);
            if (Founded != null)
            {
                _tasks.AllTasks.Remove(Founded);
                Console.WriteLine("Task Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("This Task is not in your list!");
            }
        }
    }
}

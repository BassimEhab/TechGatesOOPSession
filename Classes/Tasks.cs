using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGatesOOPSession.Classes
{
    public  class Tasks
    {
        public List<TaskDetails> AllTasks { get; set; } = new List<TaskDetails>();
        public TaskDetails FindTask(string Title)
        {
            return AllTasks.FirstOrDefault(x => x.Title == Title);
        }

    }
}

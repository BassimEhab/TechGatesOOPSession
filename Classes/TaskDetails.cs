using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGatesOOPSession.Classes
{
    public class TaskDetails
    {
        public string Title { set; get; }
        public string Description { set; get; }
        public string DuoDate { set; get; }
        public string Priority { set; get; }
        public StatusEnum Status { set; get; }
    }
}

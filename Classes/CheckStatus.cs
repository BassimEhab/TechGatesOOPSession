using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGatesOOPSession.Classes
{
    public static class CheckStatus
    {
        public static StatusEnum Checkstatus(string Status)
        {
            if (Enum.TryParse(Status, true, out StatusEnum state))
            {
            return state;
            }
            else
            {
                Console.WriteLine("your status is WRONG!!!, write only one of these (pending, inprogress,completed)");
                return StatusEnum.unknown;
            }
        }
    }
}

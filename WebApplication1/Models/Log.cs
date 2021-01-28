using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Log
    {


        public int LogID { get; set; }
        public string UserName { get; set; }
        public string ActionName { get; set; }
        public string ActionDate { get; set; }
        public string  Description { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student :Person
    {
        public Student()
        {
            Kelases = new List<Kelas>();
        }
        public int StudentID { get; set; }
        
        public List<Kelas> Kelases { get; set; }

    }

    
}


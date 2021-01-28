using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Kelas
    {
        public Kelas()
        {
            Students = new List<Student>();
        }
        public int KelasID  { get; set; }
        public Teacher Teacher{ get; set; }

        public Course Cours { get; set; }
        public string Zaman { get; set; }
        public string Makan { get; set; }
        public List<Student> Students { get; set; }
    }
}

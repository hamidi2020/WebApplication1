using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TeacherRepository
    {

        private FirstDbContext firstDbContext;

        public TeacherRepository()
        {
            firstDbContext = new FirstDbContext();
        }


        public Teacher Add(string Fristname, string Lastname)
        {
            Teacher teacher = new Teacher()
            {
                Fristname = Fristname,
                Lastname = Lastname,

            };
            firstDbContext.Teacher.Add(teacher);
            firstDbContext.SaveChanges();
            return teacher;
        }

        public Teacher Update(int TeacherID, string Fristname, string Lastname)
        {
            Teacher teacher = new Teacher()
            {
                Fristname = Fristname,
                Lastname = Lastname,
                TeacherID = TeacherID,
            };

            firstDbContext.Teacher.Update(teacher);
            firstDbContext.SaveChanges();
            return teacher;
        }




    }

}

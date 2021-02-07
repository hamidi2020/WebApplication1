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
        public void DeleteTeacher(int id)
        {
            Teacher teacher = firstDbContext.Teacher.Find(id);
            if (teacher != null)
            {
                firstDbContext.Teacher.Remove(teacher);
                firstDbContext.SaveChanges();
            }
        }

        public IEnumerable<Teacher> SearchTeacher(Func<Teacher, bool> func)
        {
            return firstDbContext.Teacher.Where(func);
        }


        //public void updateTeacher(Teacher teacher)
        //{
        //    firstDbContext.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    firstDbContext.SaveChanges();
        //}


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

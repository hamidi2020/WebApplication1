using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class StudentRepository
    {
      private FirstDbContext firstDbContext;

        public StudentRepository()
        {
            firstDbContext = new FirstDbContext();
        }


        public Student Add(string Fristname, string Lastname)
        {
            Student student = new Student()
            {
                Fristname = Fristname,
                Lastname = Lastname,
                
            };
            firstDbContext.Student.Add(student);
            firstDbContext.SaveChanges();
            return student;
        }

        public void DeleteStudent(int id)
        {
            Student student = firstDbContext.Student.Find(id);
            if (student != null)
            {
                firstDbContext.Student.Remove(student);
                firstDbContext.SaveChanges();
            }
        }

        public IEnumerable<Student> SearchStudent(Func<Student, bool> func)
        {
            return firstDbContext.Student.Where(func);
        }


        //public void updateStudent(Student student)
        //{
        //    firstDbContext.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    firstDbContext.SaveChanges();
        //}



        public Student Update(int StudentID, string Fristname, string Lastname)
        {
            Student student = new Student()
            {
                Fristname = Fristname,
                Lastname = Lastname,
                StudentID = StudentID,
            };
          
            firstDbContext.Student.Update(student);
            firstDbContext.SaveChanges();
            return student;
        }

        internal bool UserInRole(string username, string rolename)
        {
            throw new NotImplementedException();
        }
        public IList<Student> GetList()
        {

            return firstDbContext.Student.ToList();
        }
    }
}




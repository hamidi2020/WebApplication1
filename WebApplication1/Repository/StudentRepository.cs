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
    }
}

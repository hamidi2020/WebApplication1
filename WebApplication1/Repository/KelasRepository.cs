using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class KelasRepository
    {

        private FirstDbContext firstDbContext;

        public KelasRepository()
        {
            firstDbContext = new FirstDbContext();
        }


        public Kelas Add(int CourseID, int TeacherID, string Zaman,string Makan)
        {
            
            Kelas kelas = new Kelas()
            {

                Teacher = firstDbContext.Teacher.FirstOrDefault(p => p.TeacherID == TeacherID),
                Cours = firstDbContext.Course.FirstOrDefault(x => x.CourseID == CourseID),
                 Zaman = Zaman,
                 Makan= Makan,
                



            };
            firstDbContext.Kelas.Add(kelas);
            firstDbContext.SaveChanges();
            return kelas;
        }

        public Kelas Update( string Zaman, string Makan)
        {
            Kelas kelas = new Kelas()
            {
              //  Cours = Cours,
                Zaman = Zaman,
                Makan = Makan,
            };

            firstDbContext.Kelas.Update(kelas);
            firstDbContext.SaveChanges();
            return kelas;
        }




    }

}

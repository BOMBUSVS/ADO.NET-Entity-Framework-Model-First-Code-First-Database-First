using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            using( var db = new StudyModelFirstEntities ())
            {
                var class_id = new School()
                {
                    Subjects = "Math",
                    Teachers = "Marina Olexandrivna"
              };
               
                var class_id2 = new School()
                {
                    Subjects = "English",
                    Teachers = "Natalia Simonenko"
                };

                var Student_id = new Student()
                {
                    Name = "Igor",
                    Age = 17
                };

                db.Students.Add(Student_id);
                db.SchoolS.Add(class_id2);
                db.SchoolS.Add(class_id);
                db.SaveChanges();


            }

        }
    }
}

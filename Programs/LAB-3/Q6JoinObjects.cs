using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class Q6JoinObjects
    {
        public static void JoinObj()
        {
            var students = new[]
           {
                new { ID = 1, Name = "Ram", Age = 20 },
                new { ID = 2, Name = "Shyam", Age = 22 },
                new { ID = 3, Name = "Hari", Age = 21 }
            };

            var grades = new[]
            {
                new { StudentID = 1, Course = "Math", Grade = "A" },
                new { StudentID = 1, Course = "Science", Grade = "B" },
                new { StudentID = 2, Course = "Math", Grade = "C" },
                new { StudentID = 2, Course = "Science", Grade = "A" },
                new { StudentID = 3, Course = "Math", Grade = "B" },
                new { StudentID = 3, Course = "Science", Grade = "A" }
            };

            var result = from s in students
                         join g in grades on s.ID equals g.StudentID
                         select new
                         {
                             s.Name,
                             g.Course,
                             g.Grade
                         };

            foreach (var item in result)
            {
                Console.WriteLine("{0} took {1} and got {2}", item.Name, item.Course, item.Grade);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Entidades
{
    public class Teacher: Person
    {
        public string User { get; set; }
        public string Pass { get; set; }

        public List<Student> Students { get; set; }

        public Teacher()
        {
            Students = new List<Student>();
        }

        public bool AddStudent(Student student)
        {
            try
            {
                Students.Add(student);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}

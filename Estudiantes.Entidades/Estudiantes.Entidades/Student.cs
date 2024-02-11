using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Entidades
{
    public class Student : Person
    {
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}

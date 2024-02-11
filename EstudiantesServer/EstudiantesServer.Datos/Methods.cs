using Estudiantes.Entidades;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesServer.Datos
{
    public class Methods
    {
        public static List<Student> lstStudents = new List<Student>();
        public static List<Teacher> lstTeachers = new List<Teacher>();

        public Methods(){ }

        #region Student
        public string AddStudent(Student student)
        {
            try
            {
                lstStudents.Add(student);
                return "Estudiante Agregado Exitosamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message; 
            }
        }

        public List<Student> GetStudents()
        {
            return lstStudents;
        }

        public bool EditStudent(Student newStudent)
        {
            Student student = lstStudents.FirstOrDefault(p => p.Id == newStudent.Id);
            if (student != null)
            {
                student.Name = newStudent.Name;
                student.Gender = newStudent.Gender;
                student.BirthDate = newStudent.BirthDate;
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool StudentExists(int id)
        {
            return lstStudents.Exists(student => student.Id == id);
        }

        public bool DeleteStudent(int index)
        {
            return lstStudents.Remove(lstStudents[index]); 
        }

        #endregion

        #region Teacher
        public string AddTeacher(Teacher teacher)
        {
            try
            {
                lstTeachers.Add(teacher);
                return "Profesor Agregado Exitosamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

        public bool AddStudentToTeacher(int idTeacher, int idStudent)
        {
            try
            {
                Student student = lstStudents.FirstOrDefault(s => s.Id == idStudent);
                lstTeachers.FirstOrDefault(t => t.Id == idTeacher).AddStudent(student);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }            
        }

        public List<Teacher> GetTeachers()
        {
            return lstTeachers;
        }

        public bool EditTeacher(Teacher newTeacher)
        {
            Teacher teacher = lstTeachers.FirstOrDefault(p => p.Id == newTeacher.Id);
            if (teacher != null)
            {
                teacher.Name = newTeacher.Name;
                teacher.User = newTeacher.User;
                teacher.Pass = newTeacher.Pass;
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteTeacher(int index)
        {
            return lstTeachers.Remove(lstTeachers[index]);
        }

        public bool TeacherExists(int id)
        {
            return lstTeachers.Exists(teacher => teacher.Id == id);
        }

        public bool TeacherUsernameExists(string username)
        {
            return lstTeachers.Exists(teacher => teacher.User == username);
        }


        #endregion
    }
}

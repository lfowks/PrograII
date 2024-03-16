using POO.Listas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POO.Listas.Servicios
{
    public class StudentService : IStudentService
    {
        List<Student> listStudent = new List<Student>();

        public List<Student> GetStudents()
        {
            // IR A BASE DE DATOS
            return listStudent;
        }
        public Student AddStudent(Student student)
        {
            student.Id = listStudent.Count + 1;
            listStudent.Add(student); // AGREGAR a Base de Datos
            return student;
        }
        public Student GetStudentById(int id)
        {
            //foreach (Student item in listStudent)
            //{
            //    if(item.Id == id)
            //    {
            //        return item;
            //    }
            //}

            Student studentFound = listStudent.Find((item) => item.Id == id);
            
            return studentFound;            
        }
        public Student UpdateStudent(int id, Student student)
        {
            Student studentToUpdate = listStudent.Find((item) => item.Id == id);

            studentToUpdate.Name = student.Name;
            studentToUpdate.LastName = student.LastName;

            return studentToUpdate;
        }
        public void DeleteStudent(int id)
        {
            Student studentFound = listStudent.Find((item) => item.Id == id);
            listStudent.Remove(studentFound);
        }

    }
}

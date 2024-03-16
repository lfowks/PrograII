using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Listas.Entidades;

namespace POO.Listas.Servicios
{
    public interface IStudentService
    {
        public List<Student> GetStudents();

        public Student GetStudentById(int id);

        public Student AddStudent(Student student);

        public void DeleteStudent(int id);

        public Student UpdateStudent(int id, Student student);

    }

}

// See https://aka.ms/new-console-template for more information


using POO.Entidades;
using POO.Listas.Entidades;
using POO.Listas.Servicios;

//Estudiante objEstudiante = new Estudiante();
//Estudiante2 objEstudiante2 = new Estudiante2();

//objEstudiante.AgregarEstudiante();
//objEstudiante2.AgregarEstudiante();
void PrintList(List<Student> listStudent)
{
    foreach (Student item in listStudent)
    {
        Console.WriteLine(item.Id);
        Console.WriteLine(item.Name);
        Console.WriteLine(item.LastName);
        Console.WriteLine();
    }
}


StudentService studentService = new StudentService();


//AGREGAR

Student newStudent = new Student
{
    Name = "Student 1",
    LastName = "Student Last Name 1"
};

Student newStudent2 = new Student
{
    Name = "Student 2",
    LastName = "Student Last Name 2"
};

Student newStudent3 = new Student
{
    Name = "Student 3",
    LastName = "Student Last Name 3"
};


studentService.AddStudent(newStudent);
studentService.AddStudent(newStudent2);
studentService.AddStudent(newStudent3);


List<Student> listStudent = new List<Student>();

Console.WriteLine("GetStudents");
Console.WriteLine();
listStudent = studentService.GetStudents();

PrintList(listStudent);

Student studentFound = studentService.GetStudentById(2);

Console.WriteLine("GetStudentById");
Console.WriteLine();
Console.WriteLine(studentFound.Id);
Console.WriteLine(studentFound.Name);
Console.WriteLine(studentFound.LastName);
Console.WriteLine();


Console.WriteLine("Delete");
studentService.DeleteStudent(3);

Console.WriteLine("GetStudents after Deleting");
Console.WriteLine();
listStudent = studentService.GetStudents();

PrintList(listStudent);

Console.WriteLine("Update");
Console.WriteLine();
Student newStudentUpdated = new Student
{
    Name = "Student 1 - 1",
    LastName = "Student Last Name 1 - 1"
};

studentService.UpdateStudent(1, newStudentUpdated);

PrintList(listStudent);
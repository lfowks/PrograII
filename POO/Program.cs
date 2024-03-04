// See https://aka.ms/new-console-template for more information


using POO.Entidades;

//Estudiante objEstudiante = new Estudiante();
//Estudiante2 objEstudiante2 = new Estudiante2();

//objEstudiante.AgregarEstudiante();
//objEstudiante2.AgregarEstudiante();

List<int> listIntegers = new List<int>();

listIntegers.Add(1);
listIntegers.Add(2);
listIntegers.Add(3);

foreach (int item in listIntegers)
{
    Console.WriteLine(item);
}


List<Producto> listProducts = new List<Producto>();

foreach (Producto item in listProducts)
{
    Console.WriteLine(item.Nombre);
}





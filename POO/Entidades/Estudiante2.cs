namespace POO.Entidades
{
    public class Estudiante2 : Persona, IEstudiante
    {
        public string Carrera { get; set; }

        public void AgregarEstudiante()
        {
            Console.WriteLine("Agregar Estudiante (Estudiante 2)");
        }
        public void ActualizarEstudiante()
        {
            
        }
        public void EliminarEstudiante()
        {
            
        }
    }
}

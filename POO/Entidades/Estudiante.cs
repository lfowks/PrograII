namespace POO.Entidades
{
    public class Estudiante : Persona, IEstudiante
    {
        public string Carrera { get; set; }

        public void AgregarEstudiante()
        {
            Console.WriteLine("Agregar Estudiante (Estudiante)");
        }
        public void ActualizarEstudiante()
        {
            
        }
        public void EliminarEstudiante()
        {
            
        }
    }
}

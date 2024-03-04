namespace POO.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        //Relaciones
        public List<Producto> Productos { get; set; }
    }
}

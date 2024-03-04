using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entidades
{
    public class Producto : IProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        //Relaciones
        public int IdCategoria { get; set; }

        public void AgregarProducto()
        {
            Console.WriteLine("Agregar producto");
        }
    }
}

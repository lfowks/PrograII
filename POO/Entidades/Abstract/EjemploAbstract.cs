using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entidades.Abstract
{
    public abstract class EjemploAbstract
    {
        public virtual double CalcularBase()
        {

            return 2 + 2;
        }

        public abstract double Calcular();

    }
}

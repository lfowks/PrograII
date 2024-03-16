using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entidades.Abstract
{
    public class AbstractDerivada : EjemploAbstract
    {
        public override double Calcular()
        {
            return  9 + 9;
        }

        public override double CalcularBase()
        {
            return base.CalcularBase();
        }
    }

}

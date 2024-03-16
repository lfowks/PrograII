using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entidades
{
    public class Salario
    {

        private double _total;

        private double _getTotal()
        {
            //calculos

            return 0.0;
        }

        public double Total
        {
            get
            {
                double newResult = _total + _getTotal();
                return newResult;
            }

            set
            {
                double newValue = value + _getTotal();
                _total = newValue;
            }
        }

        public double Total2 { get; set; }
    }
}

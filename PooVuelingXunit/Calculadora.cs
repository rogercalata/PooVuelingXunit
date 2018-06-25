using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVuelingXunit
{
    public class Calculadora : ICalculadora, ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
        //creacion de los metodos 
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

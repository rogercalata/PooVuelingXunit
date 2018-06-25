using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXunit.Integration.Test
{
    public class Calculadora_Test
    {
        //añadimos interfaz
        ICalculadora iCalculadora = new Calculadora();
        private readonly Calculadora _Calculadora;

        public Calculadora_Test()
        {
            _Calculadora = new Calculadora();
        }

        //Xunit test Suma
        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(2, 1, 3)]
        public void Suma(int num1, int num2, int result)
        {
            Assert.Equal(result, num1 + num2);
        }

        //Xunit test Resta
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(2, 1, 1)]
        public void Resta(int num1, int num2, int result)
        {
            Assert.Equal(result, num1 - num2);
        }

        //Xunit test Division
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(2, 1, 2)]
        public void Division(int num1, int num2, int result)
        {
            Assert.Equal(result, num1 / num2);
        }

        //Xunit test Multiplicacion
        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(2, 1, 2)]
        public void Multiplicacion(int num1, int num2, int result)
        {
            Assert.Equal(result, num1 * num2);
        }
       

    }
}

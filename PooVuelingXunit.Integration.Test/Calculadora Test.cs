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
        ICalculadora iCalculadora = new Calculadora();
        private readonly Calculadora _Calculadora;

        public Calculadora_Test()
        {
            _Calculadora = new Calculadora();
        }

        [Fact]
        public void Suma()
        {
            var result = _Calculadora.Suma(1, 2);

            Assert.True(iCalculadora.Suma(num1, num2)==result);
        }

    }
}


using PooVuelingXunit;
using PooVuelingXunit.Unit.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXunit.Tests
{
    
    public class CalculadoraTests : IClassFixture<CalculadoraNmockTest>
    {
        CalculadoraNmockTest fixture;

        //creamos fixture
        public CalculadoraTests(CalculadoraNmockTest fixture)
        {
            this.fixture = fixture;
        }
        //creacion del test suma
        [Fact]
        public void Suma()
        {
            var result = fixture.MockObject.Suma(3, 2);
            Assert.Equal(5, result);
        }

        //creacion del test resta
        [Fact]
        public void Resta()
        {
            var result = fixture.MockObject.Resta(5, 2);
            Assert.Equal(3, result);
        }

        //creacion del test division
        [Fact]
        public void Division()
        {
            var result = fixture.MockObject.Suma(6, 2);
            Assert.Equal(3, result);
        }

        //creacion del test multiplicacion
        [Fact]
        public void Multiplicacion()
        {
            var result = fixture.MockObject.Multiplicacion(6, 2);
            Assert.Equal(12, result);
        }

    }
}
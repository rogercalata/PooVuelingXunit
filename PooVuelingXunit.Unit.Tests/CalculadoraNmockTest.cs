using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMock;
using Xunit;
using PooVuelingXunit;

namespace PooVuelingXunit.Unit.Tests
{
    public class CalculadoraNmockTest 
    {
        private MockFactory _factory = new MockFactory();

        public CalculadoraNmockTest()
        {
            // Creacion del Mock
            var _mock = _factory.CreateMock<ICalculadora>();
            _mock.Expects.One.MethodWith(znum => znum.Suma(3, 2)).WillReturn(5);
            _mock.Expects.One.MethodWith(znum => znum.Resta(5, 2)).WillReturn(3);
            _mock.Expects.One.MethodWith(znum => znum.Division(6, 2)).WillReturn(3);
            _mock.Expects.One.MethodWith(znum => znum.Multiplicacion(6, 2)).WillReturn(12);
            this.MockObject = _mock.MockObject;
        }
        public ICalculadora MockObject { get; private set; }
    }
}

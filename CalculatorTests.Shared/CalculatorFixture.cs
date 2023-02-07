using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests.Shared
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator { get; private set; }

        public CalculatorFixture()
        {
            Calculator = new Calculator();
        }

        public void Dispose()
        {
        }
    }
}

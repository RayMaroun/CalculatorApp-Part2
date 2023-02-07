using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTests.Shared
{
    [CollectionDefinition("Calculator Collection")]
    public class CalculatorCollection : ICollectionFixture<CalculatorFixture> { }
}

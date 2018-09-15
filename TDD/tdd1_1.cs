using System;
using Xunit;

namespace buenas_practicas_desarrollo1
{
    public class GreeterShould
    {
        [Fact]
        public void Greet()
        {
            var greeter = new Greeter();

            var greet = greeter.Greet("Bob");

            Assert.Equal("Hello, Bob", greet);
        }
    }
}

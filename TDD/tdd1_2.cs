using System;
using Xunit;

namespace buenas_practicas_desarrollo2
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

    public class Greeter
    {
        public string Greet(string name)
        {
            return "Hello, Bob";
        }
    }
}

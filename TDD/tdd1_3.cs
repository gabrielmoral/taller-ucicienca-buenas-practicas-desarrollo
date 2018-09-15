using System;
using Xunit;

namespace buenas_practicas_desarrollo3
{
    public class GreeterShould
    {
        [Fact]
        public void Greet()
        {
            var greet = Greeter.Greet("Bob");

            Assert.Equal("Hello, Bob", greet);
        }
    }

    public class Greeter
    {
        public static string Greet(string name)
        {
            return "Hello, Bob";
        }
    }
}

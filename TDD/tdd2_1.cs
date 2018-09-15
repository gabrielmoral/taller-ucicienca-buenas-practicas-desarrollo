using System;
using Xunit;

namespace buenas_practicas_desarrollo4
{
    public class GreeterShould
    {
        [Fact]
        public void Greet()
        {
            var greet = Greeter.Greet("Bob");

            Assert.Equal("Hello, Bob", greet);
        }

        [Fact]
        public void DefaultGreet()
        {
            var greet = Greeter.Greet(null);

            Assert.Equal("Hello, my friend", greet);
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

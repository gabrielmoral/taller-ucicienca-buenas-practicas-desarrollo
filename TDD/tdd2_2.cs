using System;
using Xunit;

namespace buenas_practicas_desarrollo5
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
            if (name == null)
            {
                name = "my friend";
            }

            return $"Hello, {name}";
        }
    }
}

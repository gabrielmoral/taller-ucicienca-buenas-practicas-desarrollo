using System;
using Xunit;

namespace buenas_practicas_desarrollo10
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

        [Fact]
        public void Shout()
        {
            var greet = Greeter.Greet("JERRY");

            Assert.Equal("HELLO, JERRY", greet);
        }
    }

    public class Greeter
    {
        public static string Greet(string name)
        {
            var normalizedName = Normalize(name);

            return ComposeGreet(normalizedName);
        }

        private static string Normalize(string name)
        {
            if (name == null) return "my friend";

            return name;
        }

        private static string ComposeGreet(string name)
        {
            var hello = "Hello";

            if (IsShouting(name))
            {
                hello = hello.ToUpper();
            }

            return $"{hello}, {name}";
        }

        private static bool IsShouting(string name)
        {
            return name.Equals(name.ToUpper(), StringComparison.InvariantCulture);
        }
    }
}

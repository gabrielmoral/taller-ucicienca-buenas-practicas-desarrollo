
public class GreeterShould
{
    [Fact]
    public void Greet()
    {
        var greet = Greeter.Greet("Mercedes");

        Assert.Equal("Hello, Mercedes", greet);
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
        var greet = Greeter.Greet("MARITZA");

        Assert.Equal("HELLO, MARITZA", greet);
    }
}

public class Greeter
{
    public static string Greet(string name)
    {
        var normalizedName = Normalize(name);

        return $"Hello, {normalizedName}";
    }

    private static string Normalize(string name)
    {
        if (name == null) return "my friend";

        return name;
    }
}


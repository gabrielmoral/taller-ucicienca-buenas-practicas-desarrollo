
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
}

public class Greeter
{
    public static string Greet(string name)
    {
        return $"Hello, {name}";
    }
}


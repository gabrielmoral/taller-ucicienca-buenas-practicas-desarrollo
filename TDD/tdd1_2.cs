
public class GreeterShould
{
    [Fact]
    public void Greet()
    {
        var greeter = new Greeter();

        var greet = greeter.Greet("Mercedes");

        Assert.Equal("Hello, Mercedes", greet);
    }
}

public class Greeter
{
    public string Greet(string name)
    {
        return $"Hello, {name}";
    }
}


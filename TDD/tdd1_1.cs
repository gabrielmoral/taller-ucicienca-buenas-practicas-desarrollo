
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


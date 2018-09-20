public class StringUtilShould
{
    [Fact]
    public void ReverseText()
    {
        //Preparar
        var input = "abc";

        //Actuar
        var result = StringUtil.Reverse(input);

        //Afirmar
        Assert.Equal("cba", result);
    }
}

public class StringUtil
{
    public static string Reverse(string input)
    {
        var characters = input.ToCharArray();
        Array.Reverse(characters);
        return new string(characters);
    }
}
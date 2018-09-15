using System;
using System.Collections.Generic;
using Xunit;

namespace buenas_practicas_desarrollo
{
    public class StringUtilShould
    {
        [Fact]
        public void ReverseText()
        {
            //Arrange
            var input = "abc";

            //Act
            var result = StringUtil.Reverse(input);

            //Assert
            Assert.Equal("cba", result);
        }
    }

    internal class StringUtil
    {
        internal static string Reverse(string input)
        {
            var characters = input.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }
    }
}

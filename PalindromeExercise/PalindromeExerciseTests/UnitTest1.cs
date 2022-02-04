using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("redivider", true)]
        [InlineData("civic", true)]
        [InlineData("radar", true)]
        [InlineData("eric", false)]
        [InlineData("rotor", true)]
        [InlineData("kayak", true)]
        [InlineData("gold", false)]
        [InlineData("Gold", false)]
        [InlineData("reviver", true)]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("Golf", false)]
        [InlineData("golf", false)]
        [InlineData("madam", true)]
        [InlineData("Madam", true)]
        [InlineData("refer", true)]
        [InlineData("Refer", true)]
        [InlineData("Redivider", true)]
        [InlineData("Civic", true)]
        [InlineData("Radar", true)]
        [InlineData("Eric", false)]
        [InlineData("Rotor", true)]
        [InlineData("Kayak", true)]
        [InlineData("Reviver", true)]

        public void Test1(string word, bool expected)
        {
            //Arrange

            var tester = new WordSmith();

            //Act

            var actual = WordSmith.IsAPalindrome(word);

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}

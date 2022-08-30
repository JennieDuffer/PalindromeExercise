using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("kayak", true)]
        [InlineData("nana", false)]
        [InlineData("wow", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
        //Arrange:
        var instance = new WordSmith();

        //Act:
        bool actual = instance.IsAPalindrome(word);

            //Assert:
            Assert.Equal(expected, actual);
        }
    }
}

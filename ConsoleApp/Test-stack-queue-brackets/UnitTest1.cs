using System;
using Xunit;
using ConsoleApp.Challenges.multi_bracket_validation;
namespace Test_stack_queue_brackets
{
    public class UnitTest1
    {
        // Test {}
        [Fact]
        public void Test1()
        {
            bool Result= multi_bracket_validation.multiBracketValidation("{}");
            Assert.True(Result);
        }
        // Test {}(){}	
        [Fact]
        public void Test2()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("{}(){}");
            Assert.True(Result);
        }
        // Test ()[[Extra Characters]]	
        [Fact]
        public void Test3()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("()[[My Name Is Hanan Saadeh]]");
            Assert.True(Result);
        }
        [Fact]

        // Test (){}[[]]
        public void Test4()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("(){}[[]]");
            Assert.True(Result);
        }
        [Fact]

        // Test {}{Code}[Fellows](())
        public void Test5()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("{}{c#.Hello}[Fellows](())");
            Assert.True(Result);
        }
        [Fact]

        // Test Return False [({}]
        public void Test6()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("[({}]");
            Assert.False(Result);
        }
        [Fact]

        // Test Return False (](
        public void Test7()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("(](");
            Assert.False(Result);
        }
        [Fact]
        // Test Return False {(}
        public void Test8()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("{(})");
            Assert.False(Result);
        }
        [Fact]
        public void Test56()
        {
            bool Result = multi_bracket_validation.multiBracketValidation("{a(})");
            Assert.True(Result);
        }



    }
}

using LeetCode_C_.TopInterview150.Array_String;
namespace Tests.TopInterview150.Array_String
{
    public class _917_ReverseOnlyLetters_Test
    {
        private readonly _917_ReverseOnlyLetters _algorithm;

        public _917_ReverseOnlyLetters_Test()
        {
            _algorithm = new _917_ReverseOnlyLetters();
        }

        [Theory]
        [InlineData("ab-cd", "dc-ba")]
        [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        public void ReverseOnlyLetters_Input_Returns(string s, string expected)
        {
            //Act
            var result = _algorithm.ReverseOnlyLetters(s);
            
            // Assert
            Assert.Equal(expected, result);
        }

    }
}

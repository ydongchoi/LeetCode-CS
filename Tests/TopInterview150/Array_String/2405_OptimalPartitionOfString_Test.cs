using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _2405_OptimalPartitionOfString_Test
    {
        private readonly _2405_OptimalPartitionOfString _algorithm;

        public _2405_OptimalPartitionOfString_Test()
        {
            _algorithm = new _2405_OptimalPartitionOfString();
        }

        [Theory]
        [InlineData("abacaba", 4)]
        [InlineData("ssssss", 6)]
        public void PartitionString_Input_Returns(string s, int expected)
        {
            // Act
            var result = _algorithm.PartitionString(s);
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}

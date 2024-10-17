using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _1492_TheKthFactorOfN_Test
    {
        private readonly _1492_TheKthFactorOfN _algorithm;

        public _1492_TheKthFactorOfN_Test()
        {
            _algorithm = new _1492_TheKthFactorOfN();
        }

        [Theory]
        [InlineData(12, 3, 3)]
        [InlineData(7, 2, 7)]
        [InlineData(4, 4, -1)]
        public void KthFactor_Input_Retuns(int n, int k, int expected)
        {
            // Act
            var result = _algorithm.KthFactor(n, k);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

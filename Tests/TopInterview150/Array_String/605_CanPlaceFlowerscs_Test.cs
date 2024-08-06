
using LeetCode_C_.TopInterview150.Array_String;

namespace Tests.TopInterview150.Array_String
{
    public class _605_CanPlaceFlowerscs_Test
    {
        private readonly _605_CanPlaceFlowerscs _algorithm;

        public _605_CanPlaceFlowerscs_Test()
        {
            _algorithm = new _605_CanPlaceFlowerscs();
        }

        [Theory]
        [InlineData(new int[] { 1, 0, 0, 0, 1 }, 1, true)]
        [InlineData(new int[] { 1, 0, 0, 0, 1 }, 2, false)]
        public void CanPlaceFlowers_Input_Returns(int[] flowerbed, int n, bool expectedResult)
        {
            var result = _algorithm.CanPlaceFlowers(flowerbed, n);
            Assert.Equal(expectedResult, result);
        }
    }
}

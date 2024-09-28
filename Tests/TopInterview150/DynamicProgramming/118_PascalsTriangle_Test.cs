
using LeetCode_C_.TopInterview150.DynamicProgramming;

namespace Tests.TopInterview150.DynamicProgramming
{
    public class _118_PascalsTriangle_Test
    {
        private readonly _118_PascalsTriangle _algorithm;

        public _118_PascalsTriangle_Test()
        {
            _algorithm = new _118_PascalsTriangle();
        }

        [Theory]
        [InlineData(5)]
        public void Generate_Test(int numRows)
        {
            var expected = new List<IList<int>>
            {
                new List<int> {1},
                new List<int> {1, 1},
                new List<int> {1, 2, 1},
                new List<int> {1, 3, 3, 1},
                new List<int> {1, 4, 6, 4, 1}
            };

            var result = _algorithm.Generate(numRows);

            Assert.Equal(expected, result);
        }
    }
}

using LeetCode_C_.TopInterview150.UnionFind;

namespace Tests.TopInterview150.UnionFind
{
    public class _547_NumberOfProvinces_Test
    {
        private readonly _547_NumberOfProvinces _algorithm;

        public _547_NumberOfProvinces_Test()
        {
            _algorithm = new _547_NumberOfProvinces();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void FindCircleNum_Test(int[][] isConnected, int expected)
        {
            var result = _algorithm.FindCircleNum(isConnected);
            Assert.Equal(expected, result);
        }

        public static TheoryData<int[][], int> TestData()
        {
            var testData = new TheoryData<int[][], int>();
            testData.Add(new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } }, 2);
            testData.Add(new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 } }, 3);
            return testData;
        }
    }
}

using LeetCode_C_.TopInterview150.TwoPointers;

namespace Tests.TopInterview150.TwoPointers
{
    public class _15_3Sum_Test
    {
        private readonly _15_3Sum _algorithm;

        public _15_3Sum_Test()
        {
            _algorithm = new _15_3Sum();
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void ThreeSum_Test(int[] nums, int[][] expected)
        {
            var result = _algorithm.ThreeSum(nums);
            Assert.Equal(expected.Length, result.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new[] { -1, 0, 1, 2, -1, -4 }, new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } } };
            yield return new object[] { new int[] { }, new int[][] { } };
            yield return new object[] { new[] { 0 }, new int[][] { } };
        }
    }
}

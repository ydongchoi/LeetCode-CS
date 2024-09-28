using LeetCode_C_.TopInterview150.BackTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TopInterview150.BackTracking
{
    public class _39_CombinationSum_Test
    {
        private readonly _39_CombinationSum _algorithm;

        public _39_CombinationSum_Test()
        {
            _algorithm = new _39_CombinationSum();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void CombinationSum_Test(int[] candidates, int target, int[][] expected)
        {
            var result = _algorithm.CombinationSum(candidates, target);

            Assert.Equal(expected.Length, result.Count);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new int[] { 2, 3, 5 }, 8, new int[][] { new int[] { 2, 2, 2, 2 }, new int[] { 2, 3, 3 }, new int[] { 3, 5 } } };
        }
    }
}

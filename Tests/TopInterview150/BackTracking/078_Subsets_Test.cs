using LeetCode_C_.TopInterview150.BackTracking;

namespace Tests.TopInterview150.BackTracking
{
    public class _078_Subsets_Test
    {
        private readonly _078_Subsets _algorithm;

        public _078_Subsets_Test()
        {
            _algorithm = new _078_Subsets();
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Subsets_Test(int[] nums, int[][] expected)
        {
            var result = _algorithm.Subsets(nums);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i].ToList(), result[i]);
            }
        }

        public static TheoryData<int[], int[][]> TestData()
        {
            return new TheoryData<int[], int[][]>
                {
                    { new int[] { 1, 2, 3 }, new int[][] { new int[] {}, new int[] { 1 }, new int[] { 2 }, new int[] { 3 }, new int[] { 1, 2 }, new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 1, 2, 3 } } },
                    { new int[] { 0 }, new int[][] { new int[] { }, new int[] { 0 } } }
                };
        }
    }
}

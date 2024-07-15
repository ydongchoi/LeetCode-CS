
// Time Complexity : O(2N), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/subsets/description/

namespace LeetCode_C_.TopInterview150.BackTracking
{
    public class _078_Subsets
    {
        public IList<int> singleAnswer;
        public IList<IList<int>> answer;

        public _078_Subsets()
        {
            singleAnswer = new List<int>();
            answer = new List<IList<int>>();
        }

        public IList<IList<int>> Subsets(int[] nums)
        {
            answer.Add(new List<int>());

            for (int idx = 0; idx < nums.Length; ++idx)
            {
                singleAnswer = new List<int>();
                FindSubset(0, idx, 0, nums.Length, nums);
            }

            return answer;
        }

        public void FindSubset(int curCnt, int setCnt, int nxtIdx, int numsLength, int[] nums)
        {
            if (curCnt == setCnt + 1)
            {
                answer.Add(new List<int>(singleAnswer));
                return;
            }

            for (int idx = nxtIdx; idx < numsLength; ++idx)
            {
                singleAnswer.Add(nums[idx]);
                FindSubset(curCnt + 1, setCnt, idx + 1, numsLength, nums);
                singleAnswer.RemoveAt(singleAnswer.Count - 1);
            }
        }
    }
}

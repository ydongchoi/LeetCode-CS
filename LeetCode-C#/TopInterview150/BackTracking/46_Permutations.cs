
// Time Complexity: O(n!), Space Complexity: O(N^2)
// Linke: https://leetcode.com/problems/permutations/description/?envType=problem-list-v2&envId=backtracking

namespace LeetCode_C_.TopInterview150.BackTracking
{
    public class _46_Permutations
    {
        private bool[] _isVisited;
        private List<IList<int>> _answer;

        public IList<IList<int>> Permute(int[] nums)
        {
            _isVisited = new bool[nums.Length];
            _answer = new List<IList<int>>();

            BackTracking(new List<int>(), 0, nums);

            return _answer;
        }

        private void BackTracking(List<int> one, int choice, int[] nums)
        {
            if (choice == nums.Length)
            {
                _answer.Add(new List<int>(one));
            }

            for (int idx = 0; idx < nums.Length; ++idx)
            {
                if (_isVisited[idx]) continue;

                _isVisited[idx] = true; one.Add(nums[idx]);
                BackTracking(one, choice + 1, nums);
                _isVisited[idx] = false; one.Remove(nums[idx]);
            }
        }
    }
}

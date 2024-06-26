
// Time Complexity : O(2^N) , Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/jump-game/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _055_JumpGame
    {
        public bool CanJump(int[] nums)
        {
            bool[] isJumped = new bool[nums.Length];
            for (int idx = 0; idx < nums.Length; ++idx) isJumped[idx] = true;

            var result = dfs(0, nums.Length - 1);

            bool dfs(int pos, int end)
            {
                if (pos >= end) return true;

                bool canJump = false;
                for(int jump = 1; jump <= nums[pos]; ++jump)
                {
                    if (isJumped[pos + jump] == false) continue;

                    canJump = dfs(pos + jump, end);
                    
                    if (canJump) return true;
                    else isJumped[pos + jump] = canJump;
                }

                return canJump;
            }


            return result;
        }
    }
}

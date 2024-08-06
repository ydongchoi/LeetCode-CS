
// Time Complexity : O(M + N), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/can-place-flowers/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _605_CanPlaceFlowerscs
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (flowerbed.Length == 1)
            {
                return flowerbed[0] == 0 ? n <= 1 : n <= 0;
            }

            int possible = 0;
            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1; possible += 1;
            }

            for (int idx = 1; idx < flowerbed.Length - 1; idx++)
            {
                int prev = idx - 1; int next = idx + 1;

                if (flowerbed[prev] == 0 && flowerbed[next] == 0 && flowerbed[idx] == 0)
                {
                    flowerbed[idx] = 1; possible += 1;
                }
            }

            if (flowerbed[flowerbed.Length - 2] == 0 && flowerbed[flowerbed.Length - 1] == 0)
            {
                flowerbed[flowerbed.Length - 1] = 1; possible += 1;
            }

            if (possible >= n) return true;
            else return false;

        }
    }
}

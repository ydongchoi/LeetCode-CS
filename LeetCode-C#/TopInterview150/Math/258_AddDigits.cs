
// Time Complexity : O(1), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/add-digits/description/

namespace LeetCode_C_.TopInterview150.Math
{
    public class _258_AddDigits
    {
        public int AddDigits(int num)
        {

            while (num / 10 != 0)
            {

                int nxtNum = num;
                num = 0;

                while (nxtNum != 0)
                {
                    num = num + (nxtNum % 10);

                    nxtNum /= 10;
                }
            }

            return num;
        }
    }
}

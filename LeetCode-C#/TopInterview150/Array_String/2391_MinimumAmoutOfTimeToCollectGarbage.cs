
// Time Complexity : O(NM), Spacious Complexity : O(1)
// Link : https://leetcode.com/problems/minimum-amount-of-time-to-collect-garbage/description/

namespace LeetCode_C_.TopInterview150.Array_String
{
    public class _2391_MinimumAmoutOfTimeToCollectGarbage
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            // P, G, M
            char[] trucks = new char[] { 'P', 'G', 'M' };
            int costTime = 0;

            for (int idx = 0; idx < trucks.Length; ++idx)
            {
                char type = trucks[idx];
                int travelTime = 0;

                for (int idx1 = 0; idx1 < garbage.Length; idx1++)
                {
                    if (!garbage[idx1].Contains(type))
                    {
                        if (idx1 != 0) travelTime = travelTime + travel[idx1 - 1];
                        continue;
                    }

                    int minute = garbage[idx1].ToCharArray().Count(cc => cc == type);
                    if (idx1 != 0) travelTime = travelTime + travel[idx1 - 1];

                    costTime = costTime + minute + travelTime;
                    travelTime = 0;
                }
            }

            return costTime;
        }
    }
}

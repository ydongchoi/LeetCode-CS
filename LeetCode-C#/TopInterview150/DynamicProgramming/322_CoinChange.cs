
// Time Complexity : O(CN), Spacious Complexity : O(N)
// Link : https://leetcode.com/problems/coin-change/description/

namespace LeetCode_C_.TopInterview150.DynamicProgramming
{
    public class _322_CoinChange
    {
        private int _answer;
        private int[] _memo;

        public int CoinChange(int[] coins, int amount)
        {
            _answer = 10001;
            _memo = new int[10001];

            DP(0, 0, coins, amount);

            if (_answer == 10001) return -1;
            return _answer;
        }

        private void DP(int cnt, int curAmount, int[] coins, int amount)
        {
            if (curAmount == amount)
            {
                _answer = _answer > cnt ? cnt : _answer;
                return;
            }
            if (curAmount > amount)
            {
                return;
            }

            for (int idx = coins.Length - 1; idx >= 0; idx--)
            {
                if (coins[idx] > 10000) continue;

                int nxtAmount = curAmount + coins[idx];
                int nxtCnt = cnt + 1;

                if (nxtCnt >= _answer || nxtAmount > amount || (_memo[nxtAmount] != 0 && _memo[nxtAmount] <= nxtCnt)) continue;

                _memo[nxtAmount] = nxtCnt;
                DP(nxtCnt, nxtAmount, coins, amount);
            }
        }
    }
}

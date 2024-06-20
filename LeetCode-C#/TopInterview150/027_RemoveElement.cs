using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_C_.TopInterview150
{
    public class _027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int answer = 0;
            List<int> data = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    data.Add(nums[i]);
                    answer++;
                }
            }

            for(int i = 0; i < data.Count; ++i)
            {
                nums[i] = data[i];
            }

            return answer;
        }
    }
}

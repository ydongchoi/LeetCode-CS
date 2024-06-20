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
            int existed = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[existed++] = nums[i];
                }
            }

            return existed;
        }
    }
}

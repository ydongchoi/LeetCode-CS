using LeetCode_C_.TopInterview150.LinkedList;
using Xunit.Sdk;

namespace Tests.TopInterview150.LinkedList
{
    public class _24_SwapNodesInPairs_Test
    {
        private readonly _24_SwapNodesInPairs _algorithm;

        public _24_SwapNodesInPairs_Test()
        {
            _algorithm = new _24_SwapNodesInPairs();
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { 2, 1, 3 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        public void SwapPairs_Test(int[] input, int[] output)
        {
            // Arrange
            var head = new ListNode(input[0]);
            var cur = head;
            for (int idx = 1; idx < input.Length; idx++)
            {
                cur.next = new ListNode(input[idx]);
                cur = cur.next;
            }

            // Act
            ListNode result = _algorithm.SwapPairs(head);


            // Assert
            for(int idx = 0; idx < output.Length; idx++)
            {
                Assert.Equal(output[idx], result.val);
                result = result.next;
            }
        }
    }
}

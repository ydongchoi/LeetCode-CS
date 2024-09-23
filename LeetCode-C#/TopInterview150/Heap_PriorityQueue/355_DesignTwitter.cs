
// Time Complexity : , Spacious Complexity : 
// Link : https://leetcode.com/problems/design-twitter/description/

namespace LeetCode_C_.TopInterview150.Heap_PriorityQueue
{
    public class _355_DesignTwitter
    {
        Dictionary<int, HashSet<int>> relationship;
        Dictionary<int, List<Tuple<int, int>>> tweet;
        int tweetCnt;

        public _355_DesignTwitter()
        {
            relationship = new Dictionary<int, HashSet<int>>();
            tweet = new Dictionary<int, List<Tuple<int, int>>>();
            tweetCnt = 0;
        }

        public void PostTweet(int userId, int tweetId)
        {
            if (tweet.ContainsKey(userId))
            {
                tweet[userId].Add(new Tuple<int, int>(tweetId, tweetCnt++));
            }
            else
            {
                var tmp = new List<Tuple<int, int>>();
                tmp.Add(new Tuple<int, int>(tweetId, tweetCnt++));
                tweet.Add(userId, tmp);
            }
        }

        public IList<int> GetNewsFeed(int userId)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            int last; int start;
            if (tweet.ContainsKey(userId))
            {
                last = tweet[userId].Count - 1;
                start = last - 9; start = start >= 0 ? start : 0;
                for (int idx = last; idx >= start; idx--)
                {
                    pq.Enqueue(tweet[userId][idx].Item1, tweet[userId][idx].Item2);
                }
            }

            if (relationship.ContainsKey(userId))
            {
                foreach (var elem in relationship[userId])
                {
                    if (!tweet.ContainsKey(elem)) continue;

                    last = tweet[elem].Count - 1;
                    start = last - 9; start = start >= 0 ? start : 0;

                    for (int idx = last; idx >= start; idx--)
                    {
                        pq.Enqueue(tweet[elem][idx].Item1, tweet[elem][idx].Item2);
                    }
                }
            }

            List<int> tweets = new List<int>();
            while (pq.Count != 0 && tweets.Count < 10)
            {
                tweets.Add(pq.Dequeue());
            }
            return tweets;
        }

        public void Follow(int followerId, int followeeId)
        {
            if (relationship.ContainsKey(followerId))
            {
                relationship[followerId].Add(followeeId);
            }
            else
            {
                var set = new HashSet<int>(); set.Add(followeeId);
                relationship.Add(followerId, set);
            }
        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (relationship.ContainsKey(followerId))
            {
                relationship[followerId].Remove(followeeId);
            }
        }
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        foreach(var n in nums) {
            dict[n] = dict.GetValueOrDefault(n,0)+1;
        }
        return dict.OrderByDescending(d => d.Value).Select(x => x.Key).Take(k).ToArray();
    }
}

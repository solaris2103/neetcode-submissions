public class Solution {
    public int FindDuplicate(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(var n in nums){
            dict[n] = dict.GetValueOrDefault(n,0)+1;
        }
        return dict.OrderByDescending(kvp => kvp.Value).First().Key;
    }
}

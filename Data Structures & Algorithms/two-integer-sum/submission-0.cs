public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();
        for(var i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if(dict.TryGetValue(complement, out int complementIndex)){
                return new int[] {complementIndex,i};
            }
            dict.Add(nums[i],i);
        }
        return Array.Empty<int>();
    }
}

public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = 0;
        int n = nums.Length;
        int expectedSum = n * (n+1) / 2;
        for(var i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        return expectedSum - sum;
    }
}

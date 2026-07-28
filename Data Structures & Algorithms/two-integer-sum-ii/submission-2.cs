public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        int right = nums.Length-1;
        while(left < right) {
            int currentSum = nums[left] + nums[right];
            if(currentSum == target)
                return new int[] {left+1,right+1};
            else if(currentSum < target)
                left++;
            else
                right--;
        }
        return Array.Empty<int>();
    }
}

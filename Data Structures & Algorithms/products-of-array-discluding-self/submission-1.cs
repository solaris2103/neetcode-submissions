public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var result = new int[n];
        result[0] = 1;
        for(var i = 1; i < n; i++) {
            result[i] = result[i-1] * nums[i-1];
        }
        int laterResult = 1;
        for(var i = n-1; i >= 0; i--){
            result[i] *= laterResult;
            laterResult *= nums[i];
        }
        return result;
        // for(var i = 0; i < n; i++) {
        //     result[i] = nums.Where((item,index) => index != i).ToArray().Aggregate((acct,val) => acct * val);
        // }
        // return result;
    }
}

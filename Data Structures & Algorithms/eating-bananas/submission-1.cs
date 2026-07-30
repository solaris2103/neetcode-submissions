public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1;
        int high = piles.Max();
        int result = high;
        while(low <= high){
            int mid = low + (high-low)/2;
            if(CanEatAll(piles,h,mid)){
                result = mid;
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return result;
    }
    private bool CanEatAll(int[] piles, int h, int t) {
        long totalHours = 0;
        foreach(var p in piles) {
            totalHours += (p+t-1)/t;
        }
        return totalHours <= h;
    }
}

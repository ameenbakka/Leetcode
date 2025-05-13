public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int ans = 0;
        int[] cnt = new int[101];
        foreach (int x in nums) {
            ans += cnt[x]++;
        }
        return ans;
    }
}

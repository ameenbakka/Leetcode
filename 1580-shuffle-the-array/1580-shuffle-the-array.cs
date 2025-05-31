public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        if (nums.Length != 2 * n) // Handling edge cases
            return new int[0];  // Return empty array for invalid input

        int[] res = new int[nums.Length];
        int j = 0;

        for (int i = 0; i < n; i++) {
            res[j++] = nums[i];
            res[j++] = nums[i + n];
        }
        
        return res;
    }
}

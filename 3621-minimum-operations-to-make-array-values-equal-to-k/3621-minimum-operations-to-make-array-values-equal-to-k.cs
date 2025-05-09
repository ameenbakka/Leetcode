public class Solution {
    public int MinOperations(int[] nums, int k) {
        bool[] seen= new bool[101];
        int operations=0;
        foreach (int num in nums){
            if (num<k) return -1;
            if (num > k && !seen[num])
            {
                seen[num]=true;
                operations++;
            }
        }
        return operations;
    }
}
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] res = nums1.Concat(nums2).ToArray();
        Array.Sort(res);
        int len =res.Length;
        if(len%2==0)
        return (res[len/2-1]+res[len/2])/2.0; 
        else 
        return (res[len/2]);
    }
}
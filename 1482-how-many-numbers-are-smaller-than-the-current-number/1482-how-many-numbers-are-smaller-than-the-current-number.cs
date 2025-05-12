public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        List<int> list= new List<int>();
       for(int i=0;i<nums.Length;i++)
        {
             int a=0;
            for(int j=0;j<nums.Length;j++)
            {
                if (nums[i]>nums[j])
                {
                    a++;
                }
               
            }
             list.Add(a);
        }
        int[] res= list.ToArray();
        return res;
    }
}
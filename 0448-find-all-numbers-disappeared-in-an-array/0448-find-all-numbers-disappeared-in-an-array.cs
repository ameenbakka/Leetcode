public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> list= new List<int>();
        var ulist= nums.Distinct().ToList();
        
        for (int i=1;i<=nums.Length;i++)
        {
              if(ulist.Contains(i)==false)
              {
                list.Add(i);
              }
        }
        return list;
    }
}
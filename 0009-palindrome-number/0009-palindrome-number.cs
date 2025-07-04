public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
         return false;
        int temp= x;
        int reverse=0;
        while(x>0)
        {
            int digit=x%10;
            reverse=reverse*10+digit;
            x/=10;
        }
        return reverse==temp;
    }
}
public class Solution {
    public string ClearDigits(string s) {
                Stack<char> stack = new Stack<char>();

        foreach (char ch in s)
        {
            if (char.IsDigit(ch))
            {
                // Remove closest non-digit character from stack
                while (stack.Count > 0 && char.IsDigit(stack.Peek()))
                {
                    stack.Pop();
                }

                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(ch);
            }
        }

        // Convert stack to string
        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }



}
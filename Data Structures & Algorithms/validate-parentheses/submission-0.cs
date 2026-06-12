public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        if(s.Length == 0)
            return false;

        for(int i = 0; i< s.Length;i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                stack.Push(s[i]);
            else if(s[i] == '}'){
               if (stack.Count == 0 || stack.Pop() != '{') return false;
            }
           else if(s[i] == ']') {
                if (stack.Count == 0 || stack.Pop() != '[') return false;
            }
            else if(s[i] == ')') {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
            }       
        }
        return stack.Count == 0;
    }
}

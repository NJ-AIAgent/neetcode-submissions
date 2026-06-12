public class Solution {
    public int EvalRPN(string[] tokens) {

        var stack = new Stack<int>();
        foreach(var token in tokens){
             if (int.TryParse(token, out int num))
                stack.Push(num);
             else {
                int n1 = stack.Pop();
                int n2 = stack.Pop();
                string s = token;
                if(token.Equals("+")) 
                    stack.Push( n1 + n2);
                else if(token.Equals("-")) 
                    stack.Push(n2 - n1);
                else if(token.Equals("*")) stack.Push(n1 * n2);
                else if(token.Equals("/")) stack.Push(n2 / n1);
             }
               
        }
        return stack.Pop();
        
    }
}

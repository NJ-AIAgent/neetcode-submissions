public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var s in strs){
            var encodedStr = s.Replace("#","##");
            sb.Append(encodedStr).Append("#:");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var decodedStr = new List<string>();

        var chars = s.ToCharArray();
        var sb = new StringBuilder();
        int i = 0;
        while(i<s.Length){
            if(s[i] == '#' && s[i+1] == ':'){              
                decodedStr.Add(sb.ToString());
                sb.Clear();
                i = i+2;
            }
            else if(s[i] == '#' && s[i+1] == '#')
            {        
                sb.Append('#');      
                i = i+2;
            }
            else{
                sb.Append(s[i]);
                i++;
            }
        }

        return decodedStr;

   }
}

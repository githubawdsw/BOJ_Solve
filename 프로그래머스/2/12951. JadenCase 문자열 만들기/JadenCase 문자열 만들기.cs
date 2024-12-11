using System.Text;
public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder();
        char[] arr = s.ToCharArray();
        if(arr[0] >= 'a' && arr[0] <= 'z')
            arr[0] = (char)(arr[0] - 'a' + 'A');
        
        for(int i = 1; i < s.Length; i++){
            if(arr[i - 1] == ' ')
                arr[i] = char.ToUpper(arr[i]);
            else
                arr[i] = char.ToLower(arr[i]);
        }
        sb.Append(new string(arr));
        
        return sb.ToString();
    }
}
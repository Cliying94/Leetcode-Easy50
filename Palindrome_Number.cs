//9. Palindrome Number

public class Solution {
    public bool IsPalindrome(int x) {
        char[] split_x =  x.ToString().ToCharArray();
        int i = 0;
        for(i = 0;i < split_x.Length/2;i++){
            if(split_x[i] == split_x[split_x.Length-1-i]){
                continue;
            }
            else{
                return false;
            }        
        }

        return true;
    }
}

/*Runtime: 85 ms, faster than 26.86% of C# online submissions for Palindrome Number.
Memory Usage: 28.4 MB, less than 61.93% of C# online submissions for Palindrome Number.*/


//link: https://leetcode.com/problems/repeated-substring-pattern/description
//my solution: https://leetcode.com/problems/repeated-substring-pattern/solutions/6090519/simple-c-solution-break-the-string-into-smaller-parts-repeat-the-pattern-and-check

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n = s.Length;
        for (int i = 1; i <= n / 2; i++) {
            if (n % i == 0) {
                string substring = s.Substring(0, i);

                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int j = 0; j < n / i; j++) {
                    builder.Append(substring);
                    Console.WriteLine($"substring = {substring}, builder =  {builder.ToString()}");
                }

                if (builder.ToString() == s) 
                    return true;
            }
        }
        return false;
    }
}

/*
Approach: 
Create substring from input string with length where input.Length % substring.Length == 0.
Create new string using String.Builder.Append by repeating the substring from above to reach the input string length.
Compare new string and input string.
If same, then return true, else false.

Example 1:
Input "abcabcabcabc"
Output :
substring = a, builder =  a
substring = a, builder =  aa
substring = a, builder =  aaa
substring = a, builder =  aaaa
substring = a, builder =  aaaaa
substring = a, builder =  aaaaaa
substring = a, builder =  aaaaaaa
substring = a, builder =  aaaaaaaa
substring = a, builder =  aaaaaaaaa
substring = a, builder =  aaaaaaaaaa
substring = a, builder =  aaaaaaaaaaa
substring = a, builder =  aaaaaaaaaaaa
substring = a, builder =  aaaaaaaaaaaaa
substring = a, builder =  aaaaaaaaaaaaaa
substring = a, builder =  aaaaaaaaaaaaaaa
substring = abc, builder =  abc
substring = abc, builder =  abcabc
substring = abc, builder =  abcabcabc
substring = abc, builder =  abcabcabcabc
substring = abc, builder =  abcabcabcabcabc
abcabcabcabcabc is True

Example 2:
Input "strst"
Output:
substring = s, builder =  s
substring = s, builder =  ss
substring = s, builder =  sss
substring = s, builder =  ssss
substring = s, builder =  sssss
strst is False
*/

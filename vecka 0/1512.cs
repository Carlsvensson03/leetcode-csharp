namespace leetcode.P1512;
public class Solution 
{
    public int NumIdenticalPairs(int[] nums) 
    {
        int count = 0; // börja 0
        for(int i = 0; i < nums.Length; i ++) // börja på index 0, kör så länge i e mindre en längden, ++ nästa i listan
        {
            for(int j = i + 1; j < nums.Length; j++) // j = i + 1 börja ett steg efter
            {
                if (nums[i] == nums[j]) // ifall de e samma
                {
                    count++;
                }
            }
        }
        return count;
    }
}
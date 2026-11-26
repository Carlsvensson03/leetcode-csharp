namespace leetcode.P1365;
public class Solution 
{
    public int[] SmallerNumbersThanCurrent(int[] nums) //Bra metod när array e liten
    {
        int[] result = new int[nums.Length]; //tom array med samma längd

        for (int i = 0; i < nums.Length; i++) //gå igenom varje tal
        {
            int count = 0;

            foreach (int num in nums) // jämför med det just valda talet mot de andra
            {
                if (num < nums[i])
                {
                    count++;
                }
            }

            result[i] = count;
        }

        return result;
    }
        
    
}
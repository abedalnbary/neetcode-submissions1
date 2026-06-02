                                                   
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>(); // value -> index

        for (int i = 0; i < nums.Length; i++)
        {
            int nm1 = nums[i];
            int nm2 = target - nm1;

            // If we've already seen nm2, we found the pair
            if (dict.ContainsKey(nm2))
            {
                return new int[] { dict[nm2], i };
            }

            // Store current number if not already stored
            if (!dict.ContainsKey(nm1))
            {
                dict[nm1] = i;
            }
        }

        return Array.Empty<int>();
    }
}
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];

        // prefix
        res[0] = 1;
        for (int i = 1; i < nums.Length; i++) {
            res[i] = res[i - 1] * nums[i - 1];
        }

        // suffix
        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            res[i] *= suffix;
            suffix *= nums[i];
        }

        return res;
    }
}
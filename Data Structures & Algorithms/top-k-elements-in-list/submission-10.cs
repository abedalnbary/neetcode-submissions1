public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>(nums.Length);
        foreach (var num in nums) {
            if (count.TryGetValue(num, out int c)) count[num] = c + 1;
            else count[num] = 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var kv in count) {
            int f = kv.Value;
            buckets[f] ??= new List<int>();
            buckets[f].Add(kv.Key);
        }

        int[] result = new int[k];
        int idx = 0;

        for (int f = buckets.Length - 1; f >= 1 && idx < k; f--) {
            var list = buckets[f];
            if (list == null) continue;

            for (int i = 0; i < list.Count && idx < k; i++) {
                result[idx++] = list[i];
            }
        }

        return result;
    }
}
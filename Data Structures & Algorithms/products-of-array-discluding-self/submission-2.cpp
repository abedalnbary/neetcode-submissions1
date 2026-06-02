#include <vector>
using namespace std;

class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int n = (int)nums.size();
        vector<int> res(n);

        // prefix products in res
        int prefix = 1;
        for (int i = 0; i < n; ++i) {
            res[i] = prefix;
            prefix *= nums[i];
        }

        // multiply by suffix products
        int suffix = 1;
        for (int i = n - 1; i >= 0; --i) {
            res[i] *= suffix;
            suffix *= nums[i];
        }

        return res;
    }
};
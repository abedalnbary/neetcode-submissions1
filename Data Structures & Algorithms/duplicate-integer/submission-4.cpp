class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
         unordered_set<int> unique(nums.begin(), nums.end()); 
         if (unique.size() != nums.size() )
          return true;
        return false;
    }
};
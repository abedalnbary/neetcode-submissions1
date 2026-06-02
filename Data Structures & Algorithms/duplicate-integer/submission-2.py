class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
       num1=set(nums)
       if len(nums) != len(num1):
         return True

       return False
class Solution:
    def twoSum(self, nums, target): #answer.twoSum will call a list and target int, using self to pass data which does not need to be param
        for i,num in enumerate(nums): #iterate passes with i and each value is num in nums
            if (target-num) in nums: #if (desired number-current value) is in list 
                if nums.index(target-num)!=i: # and if (desired number-current value) index != passes number
                    return [i,nums.index(target-num)] #[return passes number, index of desired number-current value)
answer = Solution()

print(answer.twoSum([2, 7, 11, 15],9))
# <<< [0,1] 
# 2 and 7 sum is target of 9

print(answer.twoSum([1,2,4,7,7],14)) # passes will be more than searched index if same two numbers are added
#<<< [4,3]
# 7 and 7 sum is target of 14

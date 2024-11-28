//link: https://leetcode.com/problems/move-zeroes/description
//my solution: https://leetcode.com/problems/move-zeroes/solutions/6091210/simple-double-looping-solution

public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i = nums.Length - 1; i >= 0; i--){
            if(nums[i] == 0){
                for(int j = i; j < nums.Length - 1; j++){
                    nums[j] = nums[j+1];
                    nums[j+1] = 0;
                }
            }
        }
    }
}

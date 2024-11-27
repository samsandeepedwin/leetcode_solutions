//link: https://leetcode.com/problems/running-sum-of-1d-array/

public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] runningSums = new int[nums.Length];
        runningSums[0] = nums[0];
        for(int i = 1;i<nums.Length;i++)
        {
            runningSums[i] = runningSums[i-1] + nums[i];
        }
        return runningSums;
    }
}

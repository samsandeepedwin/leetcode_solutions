//Link: https://leetcode.com/problems/richest-customer-wealth/description/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int richestTotal = 0;

        for(int i = 0; i < accounts.Length; i++){
            int currentTotal = 0;

            for(int j = 0; j < accounts[i].Length; j++ ){
                currentTotal += accounts[i][j];
            } 

            if(currentTotal > richestTotal){
                richestTotal = currentTotal;
            }
        }

        return richestTotal;
    }
}

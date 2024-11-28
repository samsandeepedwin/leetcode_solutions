//link: https://leetcode.com/problems/move-zeroes/description/

public class Solution {
    public int[] PlusOne(int[] digits) {
        int carryOver = 0;

        int counter = digits.Length - 1;

        while(counter >= 0){
            if(carryOver > 0){
                digits[counter] += carryOver;
            }else{
                digits[counter] ++;
            }
            if(digits[counter] >= 10){
                carryOver = 1;

                digits[counter] = 0;

                Console.WriteLine(counter);

                if(counter == 0){
                if(carryOver > 0){
                    int [] newArray = new int [digits.Length + 1];
                        newArray[0] = 1;

                    for(int i = 0; i < digits.Length; i++){
                        newArray[i+1] = digits[i];
                    }

                    return newArray;
                }
            }

                counter--;

            }
            else{
                break;
            }
            
        }
        return digits;
    }
}

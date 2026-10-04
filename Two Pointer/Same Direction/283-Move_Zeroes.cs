//given an array move all zeroes to the end 



public class Solution {
    public void MoveZeroes(int[] nums) {

        int slow=0;
        for(int fast=0;fast < nums.Count();fast++)
        {
            if(nums[fast] != 0)
            {
                int temp = nums[fast];
                nums[fast] = nums[slow];
                nums[slow] = temp;
                slow = slow + 1;
            }
        }

        nums.ToArray();
    }
}



// //Step 1 - requirementss

// // 1—> clarify requirements
//     --so will the array be empty or prefilled with values?
//     --will the elements be ordered or unordered? 
//     -- will the array comprilse of negative numbers?

// // 2—> clarify the edge cases —> areas where program could error out or go wrong
//     --

// // 3—> clarify use cases—> 
//     --what should we return the saem array with zeroes moved to end or a bool
//     --should we modify the original array in-place or create a new one?

// // Step 2 : code the brute force

// for( o to n )
// which will look for numbers whaich are not zero 
// and append the nums to result 

// then another for loop which will fill the resut fof th poisitn with zero

// time completcity for this would be NxM
// space complexity would be O(n) for the result array



// // Step 4: coding the optimized solution


// slow and a fast pointer 

// slow =0 which will move when we encouter non zero
// and then replace and increment th ewlow pointer



// time complexity would be O(n) and space complexity would be O(1) since we are not using any extra space

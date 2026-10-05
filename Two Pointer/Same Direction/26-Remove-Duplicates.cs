

// given an array num sorted in non decreasing order remove duplicaes
// in place such that elements appears only once.






public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Count();
        int slow = 0;
        for(int fast = 1; fast < n;fast++){
            if(nums[slow] != nums[fast]){
                slow = slow + 1;
                nums[slow] = nums[fast];
                
            }
        }
        return slow + 1;
    } 
}






// //Step 1 - requirementss

// // 1—> clarify requirements


// // 2—> clarify the edge cases —> areas where program could error out or go wrong
//     --

// // 3—> clarify use cases—> 

// // Step 2 : code the brute force





// // Step 4: coding the optimized solution

















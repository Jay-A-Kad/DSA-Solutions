
// You are given an array of integers nums and an integer target, return indices of the two numbers 
// such that they add up to target.





public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int,int>();
        for(int i=0; i < nums.Count();i++){
            int complement = target - nums[i];
            if(seen.ContainsKey(complement)){
                return new int[] { seen[complement], i};
            }

            seen[nums[i]] = i;
        }

         return new int[] {};
    }
}



// //Step 1 - requirementss

// // 1—> clarify requirements
   // --will the array be empty or prefilled with values? : prefilled
    // -=--will the elements be ordered or unordered? : unordered

// // 2—> clarify the edge cases —> areas where program could error out or go wrong
//     -- will there be duplicate values in the array? : yes
//     -- will there be negative values in the array? : no

// // 3—> clarify use cases—> 
//     -- what should we return if there is no solution? : return empty array

// // Step 2 : code the brute force

// we would have a nested for loop 
// which would check each element wit rest of th elements in the array and compute a runnig sum

// time complexity for this would be O(n^2)
// space complexity would be O(1) for the result array

// // Step 4: coding the optimized solution

// create a dictionary ta store complement target - current i 
// if the next elemment is same as complement then return the index of the complement and the current index
if not then save the current element and its index in the dictionary;


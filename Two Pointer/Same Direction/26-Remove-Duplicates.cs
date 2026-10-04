

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






















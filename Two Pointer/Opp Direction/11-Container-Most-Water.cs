//You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints 
// of the ith line are (i, 0) and (i, height[i]).

//Find two lines that together with the x-axis form a container, such that the container contains the most water.

//example: Input: height = [1,8,6,2,5,4,8,3,7]
//Output: 49



 public class Solution {
    public int MaxArea(int[] height) {
        int left=0;
        int right = height.Count() - 1;
        int maxArea = 0;
        while(left < right)
        {
            int width = right - left;

            int heights = Math.Min(height[left], height[right]);

            maxArea = Math.Max(maxArea, width * heights);

            if(height[left] < height[right]){
                left++;
            }else{
                right--;
            }
        }
        return maxArea;
    }
}





// //Step 1 - requirementss

// // 1—> clarify requirements


// // 2—> clarify the edge cases —> areas where program could error out or go wrong
//     --

// // 3—> clarify use cases—> 

// // Step 2 : code the brute force





// // Step 4: coding the optimized solution





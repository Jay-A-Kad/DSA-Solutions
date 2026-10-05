
//Find the largest sum among all subarrays of length k. Input: [1, 2, 3, 7, 4, 1], k = 3 → Output: 14 ([3, 7, 4]).




 static int SubarraySumFixed(int[] nums, int k)
{
    int n = nums.Count();
    int windowSum = 0;
    for(int i=0;i< k; i++)
    {
        windowSum += nums[i];
    }


    int maxSum = windowSum;

    for(int i=k;i < n; i++)
    {
        windowSum += nums[i] - nums[i-k];
        maxSum = Math.Max(maxSum, windowSum);
    }
    return maxSum;
}



// space complexity for this would be O(1) and time complexity would be O(n)






// // //Step 1 - requirementss


// // // 1—> clarify requirements
//     -- will the elemnts in array be ordered or unordered?  : unrodered
//     -- will the array be empty or prefilled with values? : prefilled with values
//     -- will the array comprise of negative numbers? : yes

// // // 2—> clarify the edge cases —> areas where program could error out or go wrong
// //     --will there be case wthere k is greater than array length? : yes, in that case we will return 0


// // // 3—> clarify use cases—> 
    


// // // Step 2 : code the brute force
// a nested for loop which will iterate through array 
// and antoehr for loop inside it that will iterate through the next k elements and sum them up

// time complexity for this would be O(n*k) and space complexity would be O(1)




// // // Step 4: coding the optimized solution



// window sum approach
// where we will keep track of the sum of first k elements
// and then a for loop from the k elemnts till the end 
// which will add the next element and subtract the first elements 



// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all 
// non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

//example
// Input: s = "A man, a plan, a canal: Panama"
// Output: true



public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            while(left < right && !char.IsLetterOrDigit(s[left])) left++;

            while(left < right && !char.IsLetterOrDigit(s[right])) right--;



            //check char
            if(char.ToLower(s[left]) != char.ToLower(s[right])){
                return false;
            }


            left++;
            right--;
        }
        return true;
        
    }
}








// //Step 1 - requirementss

// // 1—> clarify requirements
    // -- will the array be empty or prefilled with values?

// // 2—> clarify the edge cases —> areas where program could error out or go wrong
//     -- will the string be empty or prefilled with values?

// // 3—> clarify use cases—> 
    // -- what would be return type if the string is empty?

// // Step 2 : code the brute force


// we will have a for loop to remove all the non alphanumeric characters and convert the string to lower case
// then we will have a for loop to check if the string is palindrome or not

// time complexity for this would be O(n)
// space complexity would be O(n) for the result string


// // Step 4: coding the optimized solution

// left 0 right n-1

// while left < right 

// if the left its a non alphanumeric character then we will increment the left pointer 
// if the right its a non alphanumeric character then we will decrement the right pointer

// if(lower left != lower right ) return false 



// left++ right --


// return true


// time complexity for this would be O(n)
// space complexity would be O(1) for the result string



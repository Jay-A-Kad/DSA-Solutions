//Given two strings s and p, return an array of all the start indices of p's anagrams in s. 
//You may return the answer in any order.





// //Input: s = "cbaebabacd", p = "abc"

 var result = new List<int>();
    if (check.Length > original.Length) return result;

    int[] checkCount = new int[26];
    int[] windowCount = new int[26];
    foreach (char c in check)
        checkCount[c - 'a']++;

    for (int i = 0; i < original.Length; i++)
    {
        windowCount[original[i] - 'a']++;

        if (i >= check.Length)
            windowCount[original[i - check.Length] - 'a']--;

        if (i >= check.Length - 1 && windowCount.SequenceEqual(checkCount))
            result.Add(i - check.Length + 1);
    }

    return result;


// //Output: [0,6]


// // //Step 1 - requirementss

// // // 1—> clarify requirements
//     -- will the strings be emptry for both s and p?
//     -- will the strings be case sensitive?
//     --will the string contain special characters or only alphabets?

// // // 2—> clarify the edge cases —> areas where program could error out or go wrong
// //     --what if the length of p is greater than s? : in that case we will return an empty array


// // // 3—> clarify use cases—> 
//     --if the string is not anagram then we will return an empty array?
//     --should we return the indices in sorted order or any order? : any order
// // // Step 2 : code the brute force






// // // Step 4: coding the optimized solution




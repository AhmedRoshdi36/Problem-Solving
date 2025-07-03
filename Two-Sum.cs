// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         // Dictionary<int,int> Dic=new Dictionary<int,int>();
//         for(var i = 0 ; i<nums.Length ; i++ )
//         {  
//             for(var j = 1 ; j<nums.Length ; j++ )
//                 {
//                     if(i==j) continue;
//                     if(nums[i]+nums[j]==target)
                    
//                       return new int[]{i,j};
                    
//                 }
           
//         }
//         return new int[]{};
        
//     }
// }
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create an array of (value, originalIndex) pairs
        var numWithIndices = nums
            .Select((value, index) => new { Value = value, Index = index })
            .OrderBy(x => x.Value)
            .ToArray();

        int L = 0;
        int R = numWithIndices.Length - 1;

        while (L < R) {
            int sum = numWithIndices[L].Value + numWithIndices[R].Value;
            if (sum == target) {
                // Return the original indices
                return new int[] { numWithIndices[L].Index, numWithIndices[R].Index };
            }
            else if (sum < target) {
                L++;
            }
            else {
                R--;
            }
        }

        return new int[] {}; // No solution found
    }
}

// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         // Dictionary<int,int> Dic=new Dictionary<int,int>();
//         Array.Sort(nums);
//         int L=0;
//         int R=nums.Length-1; 
//         while(L <= R)
//         {
//             if(nums[L] + nums[R] == target )
//             {
//                 return new int[]{L,R};
//             }
//             else if(nums[L]+nums[R] < target)
//             {
//                 L++;
//             }
//              else if(nums[L]+ nums[R] > target)
//             {
//                 R--;
//             }
//         }
//    //     for(var i = 0 ; i<nums.Length ; i++ )
//       //  {          }
//         return new int[]{};
        
//     }
// }
// //  for(var j = 1 ; j<nums.Length ; j++ )
// //                 {
// //                     if(i==j) continue;
// //                     if(nums[i]+nums[j]==target)
                    
// //                       return new int[]{i,j};
                    
// //                 }
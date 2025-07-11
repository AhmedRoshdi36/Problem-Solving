
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numWithIndices = nums
            .Select((value, index) => new { Value = value, Index = index })
            .OrderBy(x => x.Value)
            .ToArray();

        int L = 0;
        int R = numWithIndices.Length - 1;

        while (L < R) {
            int sum = numWithIndices[L].Value + numWithIndices[R].Value;
            if (sum == target) {
                return new int[] { numWithIndices[L].Index, numWithIndices[R].Index };
            }
            else if (sum < target) {
                L++;
            }
            else {
                R--;
            }
        }

        return new int[] {}; 
    }
}

     

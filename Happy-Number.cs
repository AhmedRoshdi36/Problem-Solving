public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = GetSumOfSquares(n);

        while (fast != 1 && slow != fast) {
            slow = GetSumOfSquares(slow);
            fast = GetSumOfSquares(GetSumOfSquares(fast));
        }

        return fast == 1;
    }

    private int GetSumOfSquares(int n) {
        int sum = 0;
        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}

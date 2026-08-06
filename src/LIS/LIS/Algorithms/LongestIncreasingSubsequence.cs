namespace LIS.Algorithms;

public static class LongestIncreasingSubsequence
{
    // This method finds the longest increasing subsequence in a given string of space-separated integers.s
    // It returns the longest increasing subsequence as a space-separated string.
    // The method handles edge cases such as empty input, single element input, and all decreasing or increasing sequences.
    public static string Find(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return "";

        // Split the input string into an array of integers, removing any empty entries
        int[] nums = [.. s.Split(null as char[], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)];

        if (nums.Length == 0) 
            return "";

        // Initialize the best and current subsequences with the first element of nums
        List<int> best = [nums[0]];
        List<int> current = [nums[0]];

        for (int i = 1; i < nums.Length; i++)
        {
            // If the current number is greater than the last number in the current subsequence, add it to the current subsequence
            if (nums[i] > current[^1])
            {
                current.Add(nums[i]);
            }
            else
            {
                if (current.Count > best.Count)
                    best = current;
                current = [nums[i]];
            }
        }

        // After the loop, check if the last current subsequence is the best one
        if (current.Count > best.Count)
            best = current;

        // Return the longest increasing subsequence as a space-separated string
        return string.Join(" ", best);
    }
}

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

        int[] nums = [.. s.Split(null as char[], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)];

        if (nums.Length == 0) return "";

        List<int> best = [nums[0]];
        List<int> current = [nums[0]];

        for (int i = 1; i < nums.Length; i++)
        {
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
        if (current.Count > best.Count)
            best = current;

        return string.Join(" ", best);
    }
}

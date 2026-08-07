namespace LIS.Algorithms;

public static class LongestIncreasingSubsequence
{
    public static string Find(string input)
    {
        int[] nums = ParseNumbers(input);

        if (nums.Length == 0)
            return "";

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
    private static int[] ParseNumbers(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return [];

        return input
            .Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries)
            .Select(token =>
            {
                if (!int.TryParse(token, out int value))
                    throw new ArgumentException(
                        $"'{token}' is not a valid integer.",
                        nameof(input));

                return value;
            })
            .ToArray();
    }
}

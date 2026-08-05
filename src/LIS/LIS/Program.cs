using LIS.Algorithms;

if (args.Length == 0)
{
    Console.WriteLine("Usage:");
    Console.WriteLine("  dotnet run 10 9 2 5 3 7 101 18");
    return;
}

try
{
    string input = string.Join(" ", args);
    var result = LongestIncreasingSubsequence.Find(input);

    Console.WriteLine($"Input      :  {input}");
    Console.WriteLine($"LIS Length : {result.Length}");
    Console.WriteLine($"LIS        :  result.Sequence]");
}
catch (FormatException)
{
    Console.WriteLine("Error: All arguments must be valid integers.");
}
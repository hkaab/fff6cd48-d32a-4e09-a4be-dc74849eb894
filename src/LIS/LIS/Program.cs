using LIS.Algorithms;
using System.Diagnostics;

if (args.Length == 0)
{
    Console.WriteLine("Usage:");
    Console.WriteLine("  dotnet run 10 9 2 5 3 7 101 18");
    return;
}

try
{
    string input = string.Join(" ", args);

    var stopwatch = Stopwatch.StartNew();

    var result = LongestIncreasingSubsequence.Find(input);

    stopwatch.Stop();

    Console.WriteLine($"Input      :  {input}");
    Console.WriteLine($"LIS Length :  {result.Split(" ").Length}");
    Console.WriteLine($"LIS        :  {result}");
    Console.WriteLine($"Execution  :  {stopwatch.Elapsed.TotalMilliseconds:F4} ms");

}
catch (FormatException)
{
    Console.WriteLine("Error: All arguments must be valid integers.");
}
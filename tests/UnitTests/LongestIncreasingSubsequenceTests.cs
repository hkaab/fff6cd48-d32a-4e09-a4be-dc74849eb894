using LIS.Algorithms;
using System.Linq;
namespace UnitTests
{
    public class LongestIncreasingSubsequenceTests
    {
        [Theory]
        [InlineData("6 1 5 9 2", "1 5 9")]
        [InlineData("6 2 4 6 1 5 9 2", "2 4 6")]
        public void TestLISWithMultipleCases(string nums,string expected)
        {
            var result = LongestIncreasingSubsequence.Find(nums);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLISWithEmptyInput()
        {
            var result = LongestIncreasingSubsequence.Find("");
            Assert.Equal(string.Empty, result);
        }
        [Fact]
        public void TestLISWithSingleElement()
        {
            var result = LongestIncreasingSubsequence.Find("42");
            Assert.Equal("42", result);
        }
        [Fact]
        public void TestLISWithAllDecreasing()
        {
            var result = LongestIncreasingSubsequence.Find("5 4 3 2 1");
            Assert.Equal("5", result);
        }
        [Fact]
        public void TestLISWithAllIncreasing()
        {
            var result = LongestIncreasingSubsequence.Find("1 2 3 4 5");
            Assert.Equal("1 2 3 4 5", result);
        }
        [Fact]
        public void TestLISWithNegativeNumbers()
        {
            var result = LongestIncreasingSubsequence.Find("-1 -2 -3 -4 -5");
            Assert.Equal("-1", result);
        }
        [Fact]
        public void TestISWithLargeInput1()
        {
            string input = File.ReadAllText(Path.Combine("input","longinput1.txt"));
            string expected = "1710 2461 9288 10195 10431 12485";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput2()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput2.txt"));
            string expected = "10298 10897 12291 15037 18446 23435 25333 27266";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput3()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput3.txt"));
            string expected = "3862 16353 22813 28735";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput4()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput4.txt"));
            string expected = "11084 11970 24975 30922";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput5()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput5.txt"));
            string expected = "3808 3908 10386 19306";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput6()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput6.txt"));
            string expected = "125 1841 5882 18464 28317 31497";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput7()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput7.txt"));
            string expected = "9139 17687 25106 26202 27592 30937";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestISWithLargeInput8()
        {
            string input = File.ReadAllText(Path.Combine("input", "longinput8.txt"));
            string expected = "918 1089 5133 7725 18035 24605 26716 27095";
            var result = LongestIncreasingSubsequence.Find(input);
            Assert.Equal(expected, result);
        }
    }
}

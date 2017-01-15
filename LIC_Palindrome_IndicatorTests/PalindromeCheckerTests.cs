using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LIC_Palindrome_Indicator.Tests
{
    [TestClass()]
    public class PalindromeCheckerTests
    {
        [TestMethod()]
        public void IsPalindromeTest_Anna()
        {
            var input = "anna";

            var checker = new PalindromeChecker(input);

            var result = checker.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPalindromeTest_Aaaaaaaa()
        {
            var input = "abcdcba";

            var checker = new PalindromeChecker(input);

            var result = checker.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPalindromeTest_Aaaaaaaab()
        {
            var input = "aaaaaaaab";

            var checker = new PalindromeChecker(input);

            var result = checker.IsPalindrome();

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsAnagramOfPalindromeTest_Aaaaaaaab()
        {
            var input = "aaaaaaaab";

            var checker = new PalindromeChecker(input);

            var result = checker.IsAnagram();

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsAnagramOfPalindromeTest_Caaaaaaaab()
        {
            var input = "caaaaaaaab";

            var checker = new PalindromeChecker(input);

            var result = checker.IsAnagram();

            Assert.IsFalse(result);
        }

        //Tests from Doc
        //"anna" will return true.
        //"aaaaaaaa" will return true.
        //"aaaaaaaab" will return true.
        //"caaaaaaaab" will return false.
        //"donotbobtonod" will return true.
        //"owefhijpfwai" will return false.
        //"igdedgide" will return true.


        [TestMethod()]
        public void IsAnagramOrPalindrome_Tests()
        {
            var resultString = string.Empty;
            
            Assert.IsTrue(new PalindromeChecker("anna").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "a palindrome");
            resultString = string.Empty;

            Assert.IsTrue(new PalindromeChecker("aaaaaaaa").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "a palindrome");
            resultString = string.Empty;

            Assert.IsTrue(new PalindromeChecker("aaaaaaaab").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "an anagram of a palindrome");
            resultString = string.Empty;

            Assert.IsFalse(new PalindromeChecker("caaaaaaaab").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "neither");
            resultString = string.Empty;

            Assert.IsTrue(new PalindromeChecker("donotbobtonod").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "a palindrome");
            resultString = string.Empty;

            Assert.IsFalse(new PalindromeChecker("owefhijpfwai").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "neither");
            resultString = string.Empty;

            Assert.IsTrue(new PalindromeChecker("igdedgide").IsAnagramOrPalindrome(out resultString));
            Assert.IsTrue(resultString == "an anagram of a palindrome");
            resultString = string.Empty;
        }
    }
}
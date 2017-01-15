using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LIC_Palindrome_Indicator.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void IsOddTest()
        {
            var result = Tools.IsOdd(3);

            Assert.IsTrue(result);

            result = Tools.IsOdd(10);

            Assert.IsFalse(result);
        }
    }
}
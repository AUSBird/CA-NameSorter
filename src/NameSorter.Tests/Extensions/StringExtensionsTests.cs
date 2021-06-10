using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.App.Extensions;

namespace NameSorter.Tests.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void InvertWords()
        {
            const string input = "Tasman Miles Leach";
            const string expected = "Leach Miles Tasman";
            var actual = input.InvertByDelimiter();
            Assert.AreEqual(expected, actual);
        }
    }
}
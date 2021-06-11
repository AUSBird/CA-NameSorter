using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.App;

namespace NameSorter.Tests
{
    [TestClass]
    public class NameEntityTests
    {
        [TestMethod]
        public void ConstructorFirstNamesNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var nameEntry = new NameEntry("Test", null);
            });
            
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var nameEntry = new NameEntry("Test", new List<string>());
            });
        }

        [TestMethod]
        public void ConstructorFirstNamesMaximum()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var nameEntry = new NameEntry("Test", new List<string>() {"Test1", "Test2", "Test3", "Test4"});
            });
        }

        [TestMethod]
        public void ConstructorFirstNamesMinimum()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var nameEntry = new NameEntry("Test", new List<string>() {});
            });
        }

        [TestMethod]
        public void ConstructorLastNameNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var nameEntry = new NameEntry(null, new List<string>() {"Test"});
            });
        }

        [TestMethod]
        public void TestToString()
        {
            var nameEntry = new NameEntry("Leach", new List<string>() {"Tasman", "Miles"});
            Assert.AreEqual("Tasman Miles Leach", nameEntry.ToString());
        }
    }
}
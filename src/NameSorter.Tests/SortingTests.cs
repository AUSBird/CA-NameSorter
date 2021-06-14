using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.App;

namespace NameSorter.Tests
{
    [TestClass]
    public class SortingTests
    {
        NameEntry name1 = new NameEntry("Jones", new Collection<string>() {"Alex"});
        NameEntry name2 = new NameEntry("Leach", new Collection<string>() {"Braden"});
        NameEntry name3 = new NameEntry("Leach", new Collection<string>() {"Tasman", "Miles"});
        NameEntry name4 = new NameEntry("Leah", new Collection<string>() {"Tasman"});

        [TestMethod]
        public void Sorting()
        {
            const string expected = "Alex Jones,Braden Leach,Tasman Miles Leach,Tasman Leah";
            
            var list = new List<NameEntry>() {name1, name2, name3, name4};
            var sorter = new NameSorter.App.NameSorter();

            sorter.Sort(list, new NameCompare());
            StringBuilder actual = new StringBuilder();
            foreach (var name in list)
                actual.Append($"{name},");
            Assert.AreEqual(expected, actual.ToString().Trim(' ', ','));
        }
        
        [TestMethod]
        public void InvertedSorting()
        {
            var list = new List<NameEntry>() {name1, name2, name3, name4};
            var sorter = new NameSorter.App.NameSorter();

            const string expected = "Tasman Leah,Tasman Miles Leach,Braden Leach,Alex Jones";

            sorter.Sort(list, new InvertedNameCompare());
            StringBuilder actual = new StringBuilder();
            foreach (var name in list)
                actual.Append($"{name},");
            Assert.AreEqual(expected, actual.ToString().Trim(' ', ','));
        }
    }
}
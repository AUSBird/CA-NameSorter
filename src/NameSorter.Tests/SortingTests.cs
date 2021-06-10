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
        [TestMethod]
        public void Sorting()
        {
            var name1 = new NameEntry("Jones", new Collection<string>() {"Alex"});
            var name2 = new NameEntry("Leach", new Collection<string>() {"Braden"});
            var name3 = new NameEntry("Leach", new Collection<string>() {"Tasman", "Miles"});
            var name4 = new NameEntry("Leah", new Collection<string>() {"Tasman"});
            var list = new List<NameEntry>() {name1, name2, name3, name4};
            var sorter = new NameSorter.App.NameSorter();

            const string expected = "Alex Jones,Braden Leach,Tasman Miles Leach,Tasman Leah";

            sorter.Sort(list);
            StringBuilder actual = new StringBuilder();
            foreach (var name in list)
                actual.Append($"{name},");
            Assert.AreEqual(expected, actual.ToString().Trim(' ', ','));
        }
    }
}
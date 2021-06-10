using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NameSorter.App.Interfaces;

namespace NameSorter.App
{
    public class NameListFile<TEntry> : INameListFile
        where TEntry : class, INameEntry, new()
    {
        public IList<INameEntry> Load(string filePath)
        {
            var path = Path.GetFullPath(filePath);
            var readLines = File.ReadAllLines(path);
            var nameList = new List<INameEntry>();
            foreach (string line in readLines)
            {
                string lastName = line[line.LastIndexOf(' ')..].Trim();
                string firstNames = line[..line.LastIndexOf(' ')].Trim();
                var firstNamesList = firstNames.Split(' ').ToList();
                nameList.Add(new TEntry() {FirstNames = firstNamesList, LastName = lastName});
            }

            return nameList;
        }

        public void Save(string filePath, IList<INameEntry> nameList)
        {
            
        }
    }
}
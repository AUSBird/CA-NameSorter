using System.Collections;
using System.Collections.Generic;

namespace NameSorter.App.Interfaces
{
    public interface INameListFile
    {
        public IList<INameEntry> Load(string filePath);
        public void Save(string filePath, IList<INameEntry> nameList);
    }
}
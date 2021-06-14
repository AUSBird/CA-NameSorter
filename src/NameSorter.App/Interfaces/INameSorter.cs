using System.Collections.Generic;

namespace NameSorter.App.Interfaces
{
    public interface INameSorter
    {
        public void Sort<TName>(IList<TName> nameList, ICompare comparer)
            where TName : class, INameEntry;
    }
}
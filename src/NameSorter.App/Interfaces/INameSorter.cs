using System.Collections.Generic;

namespace NameSorter.App.Interfaces
{
    public interface INameSorter
    {
        public void Sort<TName>(IList<TName> nameList)
            where TName : class, INameEntry;
    }
}
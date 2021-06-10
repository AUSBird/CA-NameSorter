using System.Collections.Generic;

namespace NameSorter.App.Interfaces
{
    public interface INameEntry
    {
        string LastName { get; init; }
        IList<string> FirstNames { get; init; }
    }
}
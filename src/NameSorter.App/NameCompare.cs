using System;
using NameSorter.App.Extensions;
using NameSorter.App.Interfaces;

namespace NameSorter.App
{
    public class NameCompare : ICompare
    {
        public bool CheckSwap(INameEntry currentName, INameEntry compareName) =>
            String.Compare(currentName.ToString().InvertByDelimiter(), compareName.ToString().InvertByDelimiter(),
                StringComparison.Ordinal) > 0;
    }
}
using System;
using NameSorter.App.Interfaces;

namespace NameSorter.App
{
    public class NameCompare : ICompare
    {
        public bool CheckSwap(INameEntry currentName, INameEntry compareName) =>
            String.Compare(currentName.ToString(), compareName.ToString(), StringComparison.Ordinal) > 0;
    }
}
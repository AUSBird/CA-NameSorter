using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NameSorter.App.Extensions;
using NameSorter.App.Interfaces;

namespace NameSorter.App
{
    public class NameSorter : INameSorter
    {
        public void Sort<TName>(IList<TName> nameList, ICompare compare)
        where TName : class, INameEntry
        {
            for (var i = 0; i <= nameList.Count - 1; i++)
            {
                TName current = nameList[i];
                var currentName = current.ToString().InvertByDelimiter();
                for (var seek = i + 1; seek <= nameList.Count - 1; seek++)
                {
                    var compareName = nameList[seek].ToString().InvertByDelimiter();
                    if (compare.CheckSwap(current, nameList[seek]))
                    {
                        current = nameList[seek];
                        currentName = compareName;
                    }
                }

                nameList.Remove(current);
                nameList.Insert(i, current);
            }
        }
    }
}
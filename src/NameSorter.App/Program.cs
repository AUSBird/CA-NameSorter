using System;
using System.Collections.Generic;

namespace NameSorter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameListFile = new NameListFileManager<NameEntry>();
            var nameList = nameListFile.Load(args[0]);

            var nameSorter = new NameSorter();
            nameSorter.Sort(nameList);
            
            foreach (var name in nameList)
            {
                Console.WriteLine(name.ToString());
            }
            nameListFile.Save("sorted-names-list.txt", nameList);
        }
    }
}
using System;
using System.Collections.Generic;
using CommandLine;

namespace NameSorter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(Run);
        }

        private static void Run(Options options)
        {
            var nameListFile = new NameListFileManager<NameEntry>();
            var nameList = nameListFile.Load(options.InFile);

            if (!options.Invert)
            {
                var nameSorter = new NameSorter();
                nameSorter.Sort(nameList);
            }
            else
            {
                var nameSorter = new InvertedNameSorter();
                nameSorter.Sort(nameList);
            }

            foreach (var name in nameList)
            {
                Console.WriteLine(name.ToString());
            }
            nameListFile.Save("sorted-names-list.txt", nameList);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NameSorter.App.Interfaces;

namespace NameSorter.App
{
    public class NameEntry : INameEntry
    {
        public string LastName { get; init; }
        public IList<string> FirstNames { get; init; }

        public NameEntry()
        {
            LastName = String.Empty;
            FirstNames = new List<string>();
        }

        public NameEntry(string lastName, IList<string> firstNames)
        {
            if (String.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException(nameof(lastName), "Last Name cant be null");
            if (firstNames == null)
                throw new ArgumentNullException(nameof(firstNames),
                    "First Names list must not be null and must have one entry");

            if (firstNames.Count is > 3 or 0)
                throw new ArgumentException("First Names list must not have more than three entries but at least one",
                    nameof(firstNames));

            LastName = lastName;
            FirstNames = firstNames.ToList();
        }

        public override string ToString()
        {
            var firstNamesStringBuilder = new StringBuilder();
            foreach (var name in FirstNames)
                firstNamesStringBuilder.Append($"{name} ");

            var firstNames = firstNamesStringBuilder.ToString().Trim();
            return $"{firstNames} {LastName}";
        }
    }
}
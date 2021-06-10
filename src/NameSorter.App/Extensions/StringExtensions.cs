using System.Linq;
using System.Text;

namespace NameSorter.App.Extensions
{
    public static class StringExtensions
    {
        public static string InvertByDelimiter(this string words, char splitter = ' ')
        {
            var splitName = words.Split(splitter);
            var reverseNameList = splitName.Reverse();
            StringBuilder builder = new StringBuilder();
            foreach (var nameItem in reverseNameList)
                builder.Append($"{nameItem}{splitter}");
            return builder.ToString().Trim();
        }
    }
}
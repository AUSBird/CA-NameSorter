using CommandLine;

namespace NameSorter.App
{
    public class Options
    {
        [Option('i')] public bool Invert { get; set; }
        [Option('f')] public string InFile { get; set; }
    }
}
namespace NameSorter.App.Interfaces
{
    public interface ICompare
    {
        bool CheckSwap(INameEntry currentName, INameEntry compareName);
    }
}
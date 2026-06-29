namespace NimRedV2.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        void Execute(string[] args);
    }
}
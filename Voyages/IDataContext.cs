namespace Voyages
{
    public interface IDataContext
    {
        IEnumerable<Voyage> Voyages { get; }
    }
}

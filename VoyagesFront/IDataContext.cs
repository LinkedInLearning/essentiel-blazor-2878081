namespace VoyagesFront
{
    public interface IDataContext
    {
        IEnumerable<Voyage> Voyages { get; }
    }
}

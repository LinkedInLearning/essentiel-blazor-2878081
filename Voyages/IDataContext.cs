namespace Voyages
{
    public interface IDataContext
    {
        IEnumerable<Voyage> Voyages { get; set; }
        IReadOnlyDictionary<Guid, Séjour>? GetSéjours(Guid uid);
        Guid AjouterSéjour(Guid uid, Séjour séjour);
    }
}

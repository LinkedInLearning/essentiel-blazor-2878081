namespace Voyages
{
    public class SejourDto
    {
        public SejourDto(Séjour s)
        {
            Nom = s.Nom;
            NbPassagers = s.NbPassagers;
            Depart = s.Départ;
            Retour = s.Retour;
        }
        public SejourDto(Guid id, Séjour s) : this(s)
        {
            Id = id;
        }
        public Séjour GetSéjour()
        {
            var s = new Séjour(Depart);

            s.Retour = Retour;
            s.NbPassagers = NbPassagers;
            s.Nom = Nom ?? "";
            return s;
        }
        public static IEnumerable<SejourDto> GetSejourDtos(IReadOnlyDictionary<Guid, Séjour> séjours) =>
            séjours.Select(kv => new SejourDto(kv.Key, kv.Value));

        public SejourDto() { }
        public Guid? Id { get; set; } = null;
        public string? Nom { get; set; }
        public uint NbPassagers { get; set; }
        public DateTime Depart { get; set; }
        public DateTime Retour { get; set; }
    }
}
namespace Voyages
{
    public class Séjour
    {
        private DateTime départ, retour;

        public Séjour(DateTime départ)
        {
            this.départ = départ;
            this.retour = départ + TimeSpan.FromDays(7);
        }
        public string Nom { get; set; } = "";
        public string Prénom => Nom.Split(" ")[0];
        public uint NbPassagers { get; set; } = 1;
        public DateTime Départ
        {
            get => départ;
            set
            {
                retour = value + Durée;
                départ = value;
            }
        }
        public DateTime Retour
        {
            get => retour;
            set
            {
                if (value <= Départ)
                {
                    départ = value - Durée;
                }
                retour = value;
            }
        }
        public TimeSpan Durée => Retour - Départ;
    }
}

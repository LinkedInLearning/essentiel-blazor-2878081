using System.Collections.Generic;
using System.Linq;

namespace Voyages
{
    public class VoyageDto
    {
        public VoyageDto(Voyage v)
        {
            Id = v.Id;
            Image = v.Image;
            Style = v.Style;
            Titre = v.Titre;
            Pays = v.Pays;
            Note = v.Note;
            Description = v.Description;
        }

        public Voyage GetVoyage() => new Voyage(Id, Image, Style, Titre, Pays, Note, Description);

        public static IEnumerable<VoyageDto> GetVoyageDtos(IEnumerable<Voyage> voyages) =>
            voyages.Select(v => new VoyageDto(v));

        public static IEnumerable<Voyage> GetVoyages(IEnumerable<VoyageDto> voyageDtos) =>
            voyageDtos.Select(dto => dto.GetVoyage());

        public VoyageDto() { }
        public string Id { get; set; }
        public string Image { get; set; }
        public string Style { get; set; }
        public string Titre { get; set; }
        public string Pays { get; set; }
        public double Note { get; set; }
        public string Description { get; set; }
    }
}
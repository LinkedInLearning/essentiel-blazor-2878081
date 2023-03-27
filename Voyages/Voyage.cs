﻿namespace Voyages
{
    public class Voyage
    {
        public Voyage(string id, string image, string style, string titre, string pays, double note, string description)
        {
            Id = id;
            Image = image;
            Style = style;
            Titre = titre;
            Pays = pays;
            Note = note;
            Description = description;
        }
        public string Id { get; }
        public string Image { get; }
        public string Style { get; }
        public string Titre { get; }
        public string Pays { get; }
        public double Note { get; }
        public string Description { get; }
    }
}

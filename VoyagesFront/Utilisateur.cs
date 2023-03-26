using System.ComponentModel.DataAnnotations;

namespace VoyagesFront
{
    public class Utilisateur
    {
        public const string InfoLogin = "Le login est un texte compris entre 5 et 50 caractères sans espace contenant des chiffres, lettres, _ ou -";
        public const string InfoNom = "Le nom est obligatoire et sa longueur est comprise entre 2 et 50 caractères.";
        public const string InfoMotDePasse = "Un mot de passe entre 8 et 20 caractères est requis";

        [Required(ErrorMessage = InfoNom)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = InfoNom)]
        public required string Nom { get; set; }

        [MaxLength(50, ErrorMessage = "Le prénom ne peut excéder 50 caractères.")]
        public required string Prénom { get; set; }

        [Required(ErrorMessage = InfoLogin)]
        [RegularExpression("[-_A-Za-z0-9]{5,50}", ErrorMessage = InfoLogin)]
        public required string Login { get; set; }

        [Required(ErrorMessage = InfoMotDePasse)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = InfoMotDePasse)]
        [DataType(DataType.Password)]
        public required string MotDePasse { get; set; }

        [Required(ErrorMessage = "Veuillez confirmer votre mot de passe")]
        [Compare(nameof(MotDePasse), ErrorMessage = "La confirmation du mot de passe diffère du mot de passe saisi.")]
        public required string ConfirmationMotDePasse { get; set; }

        [Required(ErrorMessage = "Vous devez renseigner votre date de naissance.")]
        [DataType(DataType.Date)]
        public DateTime? DateDeNaissance { get; set; }

        public bool LettreDInformation { get; set; } = false;

        [EmailAddress(ErrorMessage = "Adresse email non valide.")]
        public required string Email { get; set; }

        public string Pays { get; set; } = "France";
    }
}
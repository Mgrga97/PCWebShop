using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO za unos i izmjenu korisnika.
    /// </summary>
    /// <param name="Ime">Ime korisnika. Obavezno polje.</param>
    /// <param name="Prezime">Prezime korisnika. Obavezno polje.</param>
    /// <param name="Email">Email korisnika. Obavezno polje. Mora biti u ispravnom formatu.</param>
    /// <param name="Lozinka">Lozinka korisnika.</param>
    public record KorisnikDTOInsertUpdate(

        [Required(ErrorMessage = "Ime obavezno")]
        string Ime,
        [Required(ErrorMessage = "Prezime obavezno")]
        string Prezime,
        [Required(ErrorMessage = "Email obavezno")]
        [EmailAddress(ErrorMessage ="Email nije dobrog formata")]
        string? Email,
        string? Lozinka
        
        
        
        );
    
}

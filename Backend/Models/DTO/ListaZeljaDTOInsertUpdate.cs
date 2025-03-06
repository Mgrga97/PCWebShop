using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO za unos i izmjenu liste želja.
    /// </summary>
    /// <param name="Naziv">Naziv liste želja.</param>
    /// <param name="KorisnikSifra">Šifra korisnika kojem lista želja pripada. Obavezno polje.</param>
    /// <param name="Placanje">Način plaćanja.</param>
    public record ListaZeljaDTOInsertUpdate(

        
        string Naziv,
        [Required(ErrorMessage = "Korisnik obavezno")]
        int KorisnikSifra,
        string Placanje


        );
    
}

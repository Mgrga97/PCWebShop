using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DTO
{
    public record ListaZeljaDTOInsertUpdate(

        
        string Naziv,
        [Required(ErrorMessage = "Korisnik obavezno")]
        int Korisnik,
        string Placanje


        );
    
}

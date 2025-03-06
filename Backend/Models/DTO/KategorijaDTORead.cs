using Microsoft.Identity.Client;

namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO objekt za čitanje podataka o kategoriji.
    /// </summary>
    /// <param name="Sifra">Šifra kategorije.</param>
    /// <param name="Naziv">Naziv kategorije.</param>
    public record KategorijaDTORead(

        int Sifra,
        string Naziv

        );
    
}

namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO objekt za čitanje podataka o korisniku.
    /// </summary>
    /// <param name="Sifra">Šifra korisnika.</param>
    /// <param name="Ime">Ime korisnika.</param>
    /// <param name="Prezime">Prezime korisnika.</param>
    /// <param name="Email">Email korisnika.</param>
    /// <param name="Lozinka">Lozinka korisnika.</param>
    public record KorisnikDTORead(

         int Sifra,
        string Ime,
        string Prezime,
        string Email,
        string? Lozinka
        
        
        );
    
}

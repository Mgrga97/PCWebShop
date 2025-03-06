namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO objekt za čitanje podataka o listi želja.
    /// </summary>
    /// <param name="Sifra">Šifra liste želja.</param>
    /// <param name="Naziv">Naziv liste želja.</param>
    /// <param name="KorisnikImePrezime">Ime i prezime korisnika kojem lista želja pripada.</param>
    /// <param name="Placanje">Način plaćanja.</param>
    public record ListaZeljaDTORead(
        
        int Sifra,
        string Naziv,
        string KorisnikImePrezime,
        string Placanje


       
        );
    
}

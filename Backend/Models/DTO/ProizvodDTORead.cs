namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO objekt za čitanje podataka o proizvodu.
    /// </summary>
    /// <param name="Sifra">Šifra proizvoda.</param>
    /// <param name="Naziv">Naziv proizvoda.</param>
    /// <param name="Cijena">Cijena proizvoda.</param>
    /// <param name="KategorijaNaziv">Naziv kategorije kojoj proizvod pripada.</param>
    public record ProizvodDTORead(

        int Sifra,
        string Naziv,
        decimal? Cijena,
        string KategorijaNaziv




        );
    
}

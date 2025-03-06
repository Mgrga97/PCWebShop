using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO za unos i izmjenu proizvoda.
    /// </summary>
    /// <param name="Naziv">Naziv proizvoda. Obavezno polje.</param>
    /// <param name="KategorijaSifra">Šifra kategorije kojoj proizvod pripada.</param>
    /// <param name="Cijena">Cijena proizvoda.</param>
    public record ProizvodDTOInsertUpdate(
    
        [Required(ErrorMessage = "Naziv obavezno")]
        string Naziv,
        [Range(0, 10000, ErrorMessage = "Vrijednost {0} mora biti između {1} i {2}")]
        [Required(ErrorMessage = "kategorija obavezno")]
        int? KategorijaSifra,
        decimal? Cijena

    );
}

using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DTO
{
    /// <summary>
    /// DTO za unos i izmjenu kategorije.
    /// </summary>
    /// <param name="Naziv">Naziv kategorije (obavezno).</param>
    public record KategorijaDTOInsertUpdate(
        [Required(ErrorMessage = "Naziv obavezno")]
        string? Naziv




        );
    


    
}

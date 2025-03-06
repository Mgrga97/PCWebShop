using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Backend.Models
{
    /// <summary>
    /// Klasa koja predstavlja listu želja.
    /// </summary>
    public class ListaZelja:Entitet
    {
        /// <summary>
        /// Naziv liste želja.
        /// </summary>
        public string Naziv { get; set; } = "";
        /// <summary>
        /// Korisnik koji je kreirao listu želja.
        /// </summary>
        [ForeignKey("korisnik")]
        public required Korisnik Korisnik { get; set; }
        /// <summary>
        /// Način plaćanja.
        /// </summary>
        public string Placanje { get; set; } = "";
        /// <summary>
        /// Proizvodi koji se nalaze na listi želja.
        /// </summary>
        public ICollection<Proizvod>? Proizvodi { get; } = [];

    }
}

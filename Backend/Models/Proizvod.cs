using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    /// <summary>
    /// Klasa koja predstavlja proizvod.
    /// </summary>
    public class Proizvod:Entitet
    {
        /// <summary>
        /// Naziv proizvoda.
        /// </summary>
        public string Naziv { get; set; } = "";
        /// <summary>
        /// Cijena proizvoda.
        /// </summary>
        public decimal? Cijena { get; set; }
        /// <summary>
        /// Kategorija kojoj proizvod pripada.
        /// </summary>
        [ForeignKey("kategorija")]
        public required Kategorija Kategorija { get; set; }

        /// <summary>
        /// Lista želja koja sadrži ovaj proizvod.
        /// </summary>
        public ICollection<ListaZelja>? ListeZelja { get; } = [];

    }
}

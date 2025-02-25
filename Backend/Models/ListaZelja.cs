using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Backend.Models
{
    public class ListaZelja:Entitet
    {
        public string Naziv { get; set; } = "";

        [ForeignKey("korisnik")]
        public required Korisnik Korisnik { get; set; }

        public string Placanje { get; set; } = "";

        public ICollection<Proizvod>? Proizvodi { get; } = [];

    }
}

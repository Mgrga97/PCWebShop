namespace Backend.Models
{
    public class Korisnik : Entitet
    {
        public string ime { get; set; } = "";

        public string prezime { get; set; } = "";

        public string? email { get; set; } 

        public string? lozinka { get; set; }

        public ICollection<ListaZelja>? ListeZelja { get; } = [];
    }
}

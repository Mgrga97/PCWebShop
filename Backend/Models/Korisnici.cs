namespace Backend.Models
{
    public class Korisnici : Entitet
    {
        public string ime { get; set; } = "";

        public string prezime { get; set; } = "";

        public string email { get; set; }

        public string lozinka { get; set; }
    }
}

namespace Backend.Models
{
    /// <summary>
    /// Klasa koja predstavlja korisnika.
    /// </summary>
    public class Korisnik : Entitet
    {
        /// <summary>
        /// Ime korisnika.
        /// </summary>
        public string Ime { get; set; } = "";
        /// <summary>
        /// Prezime korisnika.
        /// </summary>
        public string Prezime { get; set; } = "";
        /// <summary>
        /// Email korisnika.
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Lozinka korisnika.
        /// </summary>
        public string? Lozinka { get; set; }

    }
}

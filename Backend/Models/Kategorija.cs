namespace Backend.Models
{
    public class Kategorija:Entitet
    {

        public string Naziv { get; set; } = "";


        public ICollection<Proizvod>? Proizvodi { get; } = [];
        

    }
}

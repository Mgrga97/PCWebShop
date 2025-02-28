using AutoMapper;
using Backend.Models;
using Backend.Models.DTO;
using System.Text.RegularExpressions;


namespace Backend.Mapping
{
    public class PcwebshopMappingProfile:Profile
    {
        public PcwebshopMappingProfile()
        {
            // kreiramo mapiranja: izvor, odredište
            CreateMap<Kategorija, KategorijaDTORead>();
            CreateMap<KategorijaDTOInsertUpdate, Kategorija>();
            CreateMap<Kategorija, KategorijaDTOInsertUpdate>();

            CreateMap<Korisnik, KorisnikDTORead>();
            CreateMap<KorisnikDTOInsertUpdate, Korisnik>();

            CreateMap<ListaZelja, ListaZeljaDTORead>()
               .ForCtorParam(
                   "KorisnikImePrezime",
                   opt => opt.MapFrom(src => src.Korisnik.Ime + " " + src.Korisnik.Prezime)
               );


            CreateMap<Proizvod, ProizvodDTORead>()
               .ForCtorParam(
                   "KategorijaNaziv",
                   opt => opt.MapFrom(src => src.Kategorija.Naziv)
               );

            CreateMap<ProizvodDTOInsertUpdate, Proizvod>();
            CreateMap<Proizvod, ProizvodDTOInsertUpdate>();



        }



    }
}

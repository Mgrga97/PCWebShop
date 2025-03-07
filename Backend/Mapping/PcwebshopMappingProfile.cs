using AutoMapper;
using Backend.Models;
using Backend.Models.DTO;
using System.Text.RegularExpressions;


namespace Backend.Mapping
{
    /// <summary>
    /// Klasa koja predstavlja mapiranje između entiteta i DTO objekata.
    /// </summary>
    public class PcwebshopMappingProfile:Profile
    {
        /// <summary>
        /// Konstruktor u kojem se definiraju mapiranja.
        /// </summary>
        public PcwebshopMappingProfile()
        {
            // kreiramo mapiranja: izvor, odredište
            CreateMap<Kategorija, KategorijaDTORead>();
            CreateMap<KategorijaDTOInsertUpdate, Kategorija>();
            CreateMap<Kategorija, KategorijaDTOInsertUpdate>();

            CreateMap<Korisnik, KorisnikDTORead>();
            CreateMap<KorisnikDTOInsertUpdate, Korisnik>();

           


            CreateMap<Proizvod, ProizvodDTORead>()
               .ForCtorParam(
                   "KategorijaNaziv",
                   opt => opt.MapFrom(src => src.Kategorija.Naziv)
               );

            CreateMap<ProizvodDTOInsertUpdate, Proizvod>();
            CreateMap<Proizvod, ProizvodDTOInsertUpdate>().ForMember(
                opt=> opt.KategorijaSifra,
                src=> src.MapFrom(src => src.Kategorija.Sifra)
                );


            CreateMap<ListaZeljaDTOInsertUpdate, ListaZelja>();

            CreateMap<ListaZelja, ListaZeljaDTORead>()
              .ForCtorParam(
                  "KorisnikImePrezime",
                  opt => opt.MapFrom(src => src.Korisnik.Ime + " " + src.Korisnik.Prezime)
              );
            CreateMap<ListaZelja, ListaZeljaDTOInsertUpdate>();

        }



    }
}

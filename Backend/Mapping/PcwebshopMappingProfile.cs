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

            CreateMap<Korisnik, KorisnikDTORead>();
            CreateMap<KorisnikDTOInsertUpdate, Korisnik>();

            CreateMap<Proizvod, KategorijaDTORead>()
              .ForCtorParam(
                  "ProizvodNaziv",
                  opt => opt.MapFrom(src => src.Proizvod.Naziv)
              );
            CreateMap<Proizvod, KategorijaDTOInsertUpdate>().ForMember(
                    dest => dest.ProizvodSifra,
                    opt => opt.MapFrom(src => src.Proizvod.Sifra)
                );
            CreateMap<KategorijaDTOInsertUpdate, Kategorija>();

        }



    }
}

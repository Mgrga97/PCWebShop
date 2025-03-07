<a name='assembly'></a>
# Backend

## Contents

- [Entitet](#T-Backend-Models-Entitet 'Backend.Models.Entitet')
  - [Sifra](#P-Backend-Models-Entitet-Sifra 'Backend.Models.Entitet.Sifra')
- [Kategorija](#T-Backend-Models-Kategorija 'Backend.Models.Kategorija')
  - [Naziv](#P-Backend-Models-Kategorija-Naziv 'Backend.Models.Kategorija.Naziv')
- [KategorijaController](#T-Backend-Controllers-KategorijaController 'Backend.Controllers.KategorijaController')
  - [#ctor(context,mapper)](#M-Backend-Controllers-KategorijaController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper- 'Backend.Controllers.KategorijaController.#ctor(Backend.Data.PcwebshopContext,AutoMapper.IMapper)')
  - [Delete(sifra)](#M-Backend-Controllers-KategorijaController-Delete-System-Int32- 'Backend.Controllers.KategorijaController.Delete(System.Int32)')
  - [Get()](#M-Backend-Controllers-KategorijaController-Get 'Backend.Controllers.KategorijaController.Get')
  - [GetBySifra(sifra)](#M-Backend-Controllers-KategorijaController-GetBySifra-System-Int32- 'Backend.Controllers.KategorijaController.GetBySifra(System.Int32)')
  - [Post(dto)](#M-Backend-Controllers-KategorijaController-Post-Backend-Models-DTO-KategorijaDTOInsertUpdate- 'Backend.Controllers.KategorijaController.Post(Backend.Models.DTO.KategorijaDTOInsertUpdate)')
  - [Put(sifra,dto)](#M-Backend-Controllers-KategorijaController-Put-System-Int32,Backend-Models-DTO-KategorijaDTOInsertUpdate- 'Backend.Controllers.KategorijaController.Put(System.Int32,Backend.Models.DTO.KategorijaDTOInsertUpdate)')
- [KategorijaDTOInsertUpdate](#T-Backend-Models-DTO-KategorijaDTOInsertUpdate 'Backend.Models.DTO.KategorijaDTOInsertUpdate')
  - [#ctor(Naziv)](#M-Backend-Models-DTO-KategorijaDTOInsertUpdate-#ctor-System-String- 'Backend.Models.DTO.KategorijaDTOInsertUpdate.#ctor(System.String)')
  - [Naziv](#P-Backend-Models-DTO-KategorijaDTOInsertUpdate-Naziv 'Backend.Models.DTO.KategorijaDTOInsertUpdate.Naziv')
- [KategorijaDTORead](#T-Backend-Models-DTO-KategorijaDTORead 'Backend.Models.DTO.KategorijaDTORead')
  - [#ctor(Sifra,Naziv)](#M-Backend-Models-DTO-KategorijaDTORead-#ctor-System-Int32,System-String- 'Backend.Models.DTO.KategorijaDTORead.#ctor(System.Int32,System.String)')
  - [Naziv](#P-Backend-Models-DTO-KategorijaDTORead-Naziv 'Backend.Models.DTO.KategorijaDTORead.Naziv')
  - [Sifra](#P-Backend-Models-DTO-KategorijaDTORead-Sifra 'Backend.Models.DTO.KategorijaDTORead.Sifra')
- [Korisnik](#T-Backend-Models-Korisnik 'Backend.Models.Korisnik')
  - [Email](#P-Backend-Models-Korisnik-Email 'Backend.Models.Korisnik.Email')
  - [Ime](#P-Backend-Models-Korisnik-Ime 'Backend.Models.Korisnik.Ime')
  - [Lozinka](#P-Backend-Models-Korisnik-Lozinka 'Backend.Models.Korisnik.Lozinka')
  - [Prezime](#P-Backend-Models-Korisnik-Prezime 'Backend.Models.Korisnik.Prezime')
- [KorisnikController](#T-Backend-Controllers-KorisnikController 'Backend.Controllers.KorisnikController')
  - [#ctor(context,mapper)](#M-Backend-Controllers-KorisnikController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper- 'Backend.Controllers.KorisnikController.#ctor(Backend.Data.PcwebshopContext,AutoMapper.IMapper)')
  - [Delete(sifra)](#M-Backend-Controllers-KorisnikController-Delete-System-Int32- 'Backend.Controllers.KorisnikController.Delete(System.Int32)')
  - [Get()](#M-Backend-Controllers-KorisnikController-Get 'Backend.Controllers.KorisnikController.Get')
  - [GetBySifra(sifra)](#M-Backend-Controllers-KorisnikController-GetBySifra-System-Int32- 'Backend.Controllers.KorisnikController.GetBySifra(System.Int32)')
  - [Post(dto)](#M-Backend-Controllers-KorisnikController-Post-Backend-Models-DTO-KorisnikDTOInsertUpdate- 'Backend.Controllers.KorisnikController.Post(Backend.Models.DTO.KorisnikDTOInsertUpdate)')
  - [Put(sifra,dto)](#M-Backend-Controllers-KorisnikController-Put-System-Int32,Backend-Models-DTO-KorisnikDTOInsertUpdate- 'Backend.Controllers.KorisnikController.Put(System.Int32,Backend.Models.DTO.KorisnikDTOInsertUpdate)')
- [KorisnikDTOInsertUpdate](#T-Backend-Models-DTO-KorisnikDTOInsertUpdate 'Backend.Models.DTO.KorisnikDTOInsertUpdate')
  - [#ctor(Ime,Prezime,Email,Lozinka)](#M-Backend-Models-DTO-KorisnikDTOInsertUpdate-#ctor-System-String,System-String,System-String,System-String- 'Backend.Models.DTO.KorisnikDTOInsertUpdate.#ctor(System.String,System.String,System.String,System.String)')
  - [Email](#P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Email 'Backend.Models.DTO.KorisnikDTOInsertUpdate.Email')
  - [Ime](#P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Ime 'Backend.Models.DTO.KorisnikDTOInsertUpdate.Ime')
  - [Lozinka](#P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Lozinka 'Backend.Models.DTO.KorisnikDTOInsertUpdate.Lozinka')
  - [Prezime](#P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Prezime 'Backend.Models.DTO.KorisnikDTOInsertUpdate.Prezime')
- [KorisnikDTORead](#T-Backend-Models-DTO-KorisnikDTORead 'Backend.Models.DTO.KorisnikDTORead')
  - [#ctor(Sifra,Ime,Prezime,Email,Lozinka)](#M-Backend-Models-DTO-KorisnikDTORead-#ctor-System-Int32,System-String,System-String,System-String,System-String- 'Backend.Models.DTO.KorisnikDTORead.#ctor(System.Int32,System.String,System.String,System.String,System.String)')
  - [Email](#P-Backend-Models-DTO-KorisnikDTORead-Email 'Backend.Models.DTO.KorisnikDTORead.Email')
  - [Ime](#P-Backend-Models-DTO-KorisnikDTORead-Ime 'Backend.Models.DTO.KorisnikDTORead.Ime')
  - [Lozinka](#P-Backend-Models-DTO-KorisnikDTORead-Lozinka 'Backend.Models.DTO.KorisnikDTORead.Lozinka')
  - [Prezime](#P-Backend-Models-DTO-KorisnikDTORead-Prezime 'Backend.Models.DTO.KorisnikDTORead.Prezime')
  - [Sifra](#P-Backend-Models-DTO-KorisnikDTORead-Sifra 'Backend.Models.DTO.KorisnikDTORead.Sifra')
- [ListaZelja](#T-Backend-Models-ListaZelja 'Backend.Models.ListaZelja')
  - [Korisnik](#P-Backend-Models-ListaZelja-Korisnik 'Backend.Models.ListaZelja.Korisnik')
  - [Naziv](#P-Backend-Models-ListaZelja-Naziv 'Backend.Models.ListaZelja.Naziv')
  - [Placanje](#P-Backend-Models-ListaZelja-Placanje 'Backend.Models.ListaZelja.Placanje')
  - [Proizvodi](#P-Backend-Models-ListaZelja-Proizvodi 'Backend.Models.ListaZelja.Proizvodi')
- [ListaZeljaController](#T-Backend-Controllers-ListaZeljaController 'Backend.Controllers.ListaZeljaController')
  - [Delete(sifra)](#M-Backend-Controllers-ListaZeljaController-Delete-System-Int32- 'Backend.Controllers.ListaZeljaController.Delete(System.Int32)')
  - [Get()](#M-Backend-Controllers-ListaZeljaController-Get 'Backend.Controllers.ListaZeljaController.Get')
  - [GetBySifra(sifra)](#M-Backend-Controllers-ListaZeljaController-GetBySifra-System-Int32- 'Backend.Controllers.ListaZeljaController.GetBySifra(System.Int32)')
  - [Post(dto)](#M-Backend-Controllers-ListaZeljaController-Post-Backend-Models-DTO-ListaZeljaDTOInsertUpdate- 'Backend.Controllers.ListaZeljaController.Post(Backend.Models.DTO.ListaZeljaDTOInsertUpdate)')
  - [Put(sifra,dto)](#M-Backend-Controllers-ListaZeljaController-Put-System-Int32,Backend-Models-DTO-ListaZeljaDTOInsertUpdate- 'Backend.Controllers.ListaZeljaController.Put(System.Int32,Backend.Models.DTO.ListaZeljaDTOInsertUpdate)')
- [ListaZeljaDTOInsertUpdate](#T-Backend-Models-DTO-ListaZeljaDTOInsertUpdate 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate')
  - [#ctor(Naziv,KorisnikSifra,Placanje)](#M-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-#ctor-System-String,System-Int32,System-String- 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate.#ctor(System.String,System.Int32,System.String)')
  - [KorisnikSifra](#P-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-KorisnikSifra 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate.KorisnikSifra')
  - [Naziv](#P-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-Naziv 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate.Naziv')
  - [Placanje](#P-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-Placanje 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate.Placanje')
- [ListaZeljaDTORead](#T-Backend-Models-DTO-ListaZeljaDTORead 'Backend.Models.DTO.ListaZeljaDTORead')
  - [#ctor(Sifra,Naziv,KorisnikImePrezime,Placanje)](#M-Backend-Models-DTO-ListaZeljaDTORead-#ctor-System-Int32,System-String,System-String,System-String- 'Backend.Models.DTO.ListaZeljaDTORead.#ctor(System.Int32,System.String,System.String,System.String)')
  - [KorisnikImePrezime](#P-Backend-Models-DTO-ListaZeljaDTORead-KorisnikImePrezime 'Backend.Models.DTO.ListaZeljaDTORead.KorisnikImePrezime')
  - [Naziv](#P-Backend-Models-DTO-ListaZeljaDTORead-Naziv 'Backend.Models.DTO.ListaZeljaDTORead.Naziv')
  - [Placanje](#P-Backend-Models-DTO-ListaZeljaDTORead-Placanje 'Backend.Models.DTO.ListaZeljaDTORead.Placanje')
  - [Sifra](#P-Backend-Models-DTO-ListaZeljaDTORead-Sifra 'Backend.Models.DTO.ListaZeljaDTORead.Sifra')
- [PcwebshopContext](#T-Backend-Data-PcwebshopContext 'Backend.Data.PcwebshopContext')
  - [#ctor(opcije)](#M-Backend-Data-PcwebshopContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Backend-Data-PcwebshopContext}- 'Backend.Data.PcwebshopContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Backend.Data.PcwebshopContext})')
  - [Kategorije](#P-Backend-Data-PcwebshopContext-Kategorije 'Backend.Data.PcwebshopContext.Kategorije')
  - [Korisnici](#P-Backend-Data-PcwebshopContext-Korisnici 'Backend.Data.PcwebshopContext.Korisnici')
  - [ListeZelja](#P-Backend-Data-PcwebshopContext-ListeZelja 'Backend.Data.PcwebshopContext.ListeZelja')
  - [Proizvodi](#P-Backend-Data-PcwebshopContext-Proizvodi 'Backend.Data.PcwebshopContext.Proizvodi')
  - [OnModelCreating(modelBuilder)](#M-Backend-Data-PcwebshopContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'Backend.Data.PcwebshopContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
- [PcwebshopController](#T-Backend-Controllers-PcwebshopController 'Backend.Controllers.PcwebshopController')
  - [#ctor(context,mapper)](#M-Backend-Controllers-PcwebshopController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper- 'Backend.Controllers.PcwebshopController.#ctor(Backend.Data.PcwebshopContext,AutoMapper.IMapper)')
  - [_context](#F-Backend-Controllers-PcwebshopController-_context 'Backend.Controllers.PcwebshopController._context')
- [PcwebshopMappingProfile](#T-Backend-Mapping-PcwebshopMappingProfile 'Backend.Mapping.PcwebshopMappingProfile')
  - [#ctor()](#M-Backend-Mapping-PcwebshopMappingProfile-#ctor 'Backend.Mapping.PcwebshopMappingProfile.#ctor')
- [Proizvod](#T-Backend-Models-Proizvod 'Backend.Models.Proizvod')
  - [Cijena](#P-Backend-Models-Proizvod-Cijena 'Backend.Models.Proizvod.Cijena')
  - [Kategorija](#P-Backend-Models-Proizvod-Kategorija 'Backend.Models.Proizvod.Kategorija')
  - [ListeZelja](#P-Backend-Models-Proizvod-ListeZelja 'Backend.Models.Proizvod.ListeZelja')
  - [Naziv](#P-Backend-Models-Proizvod-Naziv 'Backend.Models.Proizvod.Naziv')
- [ProizvodController](#T-Backend-Controllers-ProizvodController 'Backend.Controllers.ProizvodController')
  - [#ctor(context,mapper)](#M-Backend-Controllers-ProizvodController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper- 'Backend.Controllers.ProizvodController.#ctor(Backend.Data.PcwebshopContext,AutoMapper.IMapper)')
  - [Delete(sifra)](#M-Backend-Controllers-ProizvodController-Delete-System-Int32- 'Backend.Controllers.ProizvodController.Delete(System.Int32)')
  - [Get()](#M-Backend-Controllers-ProizvodController-Get 'Backend.Controllers.ProizvodController.Get')
  - [GetBySifra(sifra)](#M-Backend-Controllers-ProizvodController-GetBySifra-System-Int32- 'Backend.Controllers.ProizvodController.GetBySifra(System.Int32)')
  - [Post(dto)](#M-Backend-Controllers-ProizvodController-Post-Backend-Models-DTO-ProizvodDTOInsertUpdate- 'Backend.Controllers.ProizvodController.Post(Backend.Models.DTO.ProizvodDTOInsertUpdate)')
  - [Put(sifra,dto)](#M-Backend-Controllers-ProizvodController-Put-System-Int32,Backend-Models-DTO-ProizvodDTOInsertUpdate- 'Backend.Controllers.ProizvodController.Put(System.Int32,Backend.Models.DTO.ProizvodDTOInsertUpdate)')
- [ProizvodDTOInsertUpdate](#T-Backend-Models-DTO-ProizvodDTOInsertUpdate 'Backend.Models.DTO.ProizvodDTOInsertUpdate')
  - [#ctor(Naziv,KategorijaSifra,Cijena)](#M-Backend-Models-DTO-ProizvodDTOInsertUpdate-#ctor-System-String,System-Nullable{System-Int32},System-Nullable{System-Decimal}- 'Backend.Models.DTO.ProizvodDTOInsertUpdate.#ctor(System.String,System.Nullable{System.Int32},System.Nullable{System.Decimal})')
  - [Cijena](#P-Backend-Models-DTO-ProizvodDTOInsertUpdate-Cijena 'Backend.Models.DTO.ProizvodDTOInsertUpdate.Cijena')
  - [KategorijaSifra](#P-Backend-Models-DTO-ProizvodDTOInsertUpdate-KategorijaSifra 'Backend.Models.DTO.ProizvodDTOInsertUpdate.KategorijaSifra')
  - [Naziv](#P-Backend-Models-DTO-ProizvodDTOInsertUpdate-Naziv 'Backend.Models.DTO.ProizvodDTOInsertUpdate.Naziv')
- [ProizvodDTORead](#T-Backend-Models-DTO-ProizvodDTORead 'Backend.Models.DTO.ProizvodDTORead')
  - [#ctor(Sifra,Naziv,Cijena,KategorijaNaziv)](#M-Backend-Models-DTO-ProizvodDTORead-#ctor-System-Int32,System-String,System-Nullable{System-Decimal},System-String- 'Backend.Models.DTO.ProizvodDTORead.#ctor(System.Int32,System.String,System.Nullable{System.Decimal},System.String)')
  - [Cijena](#P-Backend-Models-DTO-ProizvodDTORead-Cijena 'Backend.Models.DTO.ProizvodDTORead.Cijena')
  - [KategorijaNaziv](#P-Backend-Models-DTO-ProizvodDTORead-KategorijaNaziv 'Backend.Models.DTO.ProizvodDTORead.KategorijaNaziv')
  - [Naziv](#P-Backend-Models-DTO-ProizvodDTORead-Naziv 'Backend.Models.DTO.ProizvodDTORead.Naziv')
  - [Sifra](#P-Backend-Models-DTO-ProizvodDTORead-Sifra 'Backend.Models.DTO.ProizvodDTORead.Sifra')

<a name='T-Backend-Models-Entitet'></a>
## Entitet `type`

##### Namespace

Backend.Models

##### Summary

Apstraktna  klasa koja predstavlja entitet s jedinstvenim identifikatorom.

<a name='P-Backend-Models-Entitet-Sifra'></a>
### Sifra `property`

##### Summary

Jedinstveni identifikator entiteta.

<a name='T-Backend-Models-Kategorija'></a>
## Kategorija `type`

##### Namespace

Backend.Models

##### Summary

Klasa koja predstavlja kategoriju.

<a name='P-Backend-Models-Kategorija-Naziv'></a>
### Naziv `property`

##### Summary

Naziv kategorije.

<a name='T-Backend-Controllers-KategorijaController'></a>
## KategorijaController `type`

##### Namespace

Backend.Controllers

##### Summary

Kontroler za rad sa kategorijama.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [T:Backend.Controllers.KategorijaController](#T-T-Backend-Controllers-KategorijaController 'T:Backend.Controllers.KategorijaController') | kontekst baze podataka. |

<a name='M-Backend-Controllers-KategorijaController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper-'></a>
### #ctor(context,mapper) `constructor`

##### Summary

Kontroler za rad sa kategorijama.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Backend.Data.PcwebshopContext](#T-Backend-Data-PcwebshopContext 'Backend.Data.PcwebshopContext') | kontekst baze podataka. |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | mapper za mapiranje objekta. |

<a name='M-Backend-Controllers-KategorijaController-Delete-System-Int32-'></a>
### Delete(sifra) `method`

##### Summary

Metoda za brisanje kategorije.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra kategorije. |

<a name='M-Backend-Controllers-KategorijaController-Get'></a>
### Get() `method`

##### Summary

Metoda za dohvat svih kategorija

##### Returns

Daje listu kategorija.

##### Parameters

This method has no parameters.

<a name='M-Backend-Controllers-KategorijaController-GetBySifra-System-Int32-'></a>
### GetBySifra(sifra) `method`

##### Summary

Metoda za dohvat kategorije po šifri.

##### Returns

Kategorija.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra kategorije. |

<a name='M-Backend-Controllers-KategorijaController-Post-Backend-Models-DTO-KategorijaDTOInsertUpdate-'></a>
### Post(dto) `method`

##### Summary

Metoda za dodavanje kategorije.

##### Returns

Status kreiranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [Backend.Models.DTO.KategorijaDTOInsertUpdate](#T-Backend-Models-DTO-KategorijaDTOInsertUpdate 'Backend.Models.DTO.KategorijaDTOInsertUpdate') | Podaci o kategoriji. |

<a name='M-Backend-Controllers-KategorijaController-Put-System-Int32,Backend-Models-DTO-KategorijaDTOInsertUpdate-'></a>
### Put(sifra,dto) `method`

##### Summary

Metoda za promjenu kategorije

##### Returns

Status promjene podataka.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra kategorije. |
| dto | [Backend.Models.DTO.KategorijaDTOInsertUpdate](#T-Backend-Models-DTO-KategorijaDTOInsertUpdate 'Backend.Models.DTO.KategorijaDTOInsertUpdate') | Naziv kategorije. |

<a name='T-Backend-Models-DTO-KategorijaDTOInsertUpdate'></a>
## KategorijaDTOInsertUpdate `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO za unos i izmjenu kategorije.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Naziv | [T:Backend.Models.DTO.KategorijaDTOInsertUpdate](#T-T-Backend-Models-DTO-KategorijaDTOInsertUpdate 'T:Backend.Models.DTO.KategorijaDTOInsertUpdate') | Naziv kategorije (obavezno). |

<a name='M-Backend-Models-DTO-KategorijaDTOInsertUpdate-#ctor-System-String-'></a>
### #ctor(Naziv) `constructor`

##### Summary

DTO za unos i izmjenu kategorije.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Naziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv kategorije (obavezno). |

<a name='P-Backend-Models-DTO-KategorijaDTOInsertUpdate-Naziv'></a>
### Naziv `property`

##### Summary

Naziv kategorije (obavezno).

<a name='T-Backend-Models-DTO-KategorijaDTORead'></a>
## KategorijaDTORead `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO objekt za čitanje podataka o kategoriji.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [T:Backend.Models.DTO.KategorijaDTORead](#T-T-Backend-Models-DTO-KategorijaDTORead 'T:Backend.Models.DTO.KategorijaDTORead') | Šifra kategorije. |

<a name='M-Backend-Models-DTO-KategorijaDTORead-#ctor-System-Int32,System-String-'></a>
### #ctor(Sifra,Naziv) `constructor`

##### Summary

DTO objekt za čitanje podataka o kategoriji.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra kategorije. |
| Naziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv kategorije. |

<a name='P-Backend-Models-DTO-KategorijaDTORead-Naziv'></a>
### Naziv `property`

##### Summary

Naziv kategorije.

<a name='P-Backend-Models-DTO-KategorijaDTORead-Sifra'></a>
### Sifra `property`

##### Summary

Šifra kategorije.

<a name='T-Backend-Models-Korisnik'></a>
## Korisnik `type`

##### Namespace

Backend.Models

##### Summary

Klasa koja predstavlja korisnika.

<a name='P-Backend-Models-Korisnik-Email'></a>
### Email `property`

##### Summary

Email korisnika.

<a name='P-Backend-Models-Korisnik-Ime'></a>
### Ime `property`

##### Summary

Ime korisnika.

<a name='P-Backend-Models-Korisnik-Lozinka'></a>
### Lozinka `property`

##### Summary

Lozinka korisnika.

<a name='P-Backend-Models-Korisnik-Prezime'></a>
### Prezime `property`

##### Summary

Prezime korisnika.

<a name='T-Backend-Controllers-KorisnikController'></a>
## KorisnikController `type`

##### Namespace

Backend.Controllers

##### Summary

Kontroler za rad sa korisnicima

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [T:Backend.Controllers.KorisnikController](#T-T-Backend-Controllers-KorisnikController 'T:Backend.Controllers.KorisnikController') | Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka |

<a name='M-Backend-Controllers-KorisnikController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper-'></a>
### #ctor(context,mapper) `constructor`

##### Summary

Kontroler za rad sa korisnicima

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Backend.Data.PcwebshopContext](#T-Backend-Data-PcwebshopContext 'Backend.Data.PcwebshopContext') | Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | Instanca IMapper sučelja koja se koristi za mapiranje objekta |

<a name='M-Backend-Controllers-KorisnikController-Delete-System-Int32-'></a>
### Delete(sifra) `method`

##### Summary

Briše korisnika po šifri.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra korisnika. |

<a name='M-Backend-Controllers-KorisnikController-Get'></a>
### Get() `method`

##### Summary

Metoda za dohvat svih korisnika.

##### Returns

Listu DTO objekata korisnika.

##### Parameters

This method has no parameters.

<a name='M-Backend-Controllers-KorisnikController-GetBySifra-System-Int32-'></a>
### GetBySifra(sifra) `method`

##### Summary

Metoda za dohvat korisnika po šifri.

##### Returns

DTO objekt korisnika.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra korisnika. |

<a name='M-Backend-Controllers-KorisnikController-Post-Backend-Models-DTO-KorisnikDTOInsertUpdate-'></a>
### Post(dto) `method`

##### Summary

Dodaje novog korisnika.

##### Returns

Status kreiranja i DTO objekt novog korisnika.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [Backend.Models.DTO.KorisnikDTOInsertUpdate](#T-Backend-Models-DTO-KorisnikDTOInsertUpdate 'Backend.Models.DTO.KorisnikDTOInsertUpdate') | DTO objekt korisnik koji se stvara ili ažurira. |

<a name='M-Backend-Controllers-KorisnikController-Put-System-Int32,Backend-Models-DTO-KorisnikDTOInsertUpdate-'></a>
### Put(sifra,dto) `method`

##### Summary

Metoda za promjenu korisnika.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra korisnika. |
| dto | [Backend.Models.DTO.KorisnikDTOInsertUpdate](#T-Backend-Models-DTO-KorisnikDTOInsertUpdate 'Backend.Models.DTO.KorisnikDTOInsertUpdate') | DTO objekt za unos ili ažuriranje korisnika. |

<a name='T-Backend-Models-DTO-KorisnikDTOInsertUpdate'></a>
## KorisnikDTOInsertUpdate `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO za unos i izmjenu korisnika.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Ime | [T:Backend.Models.DTO.KorisnikDTOInsertUpdate](#T-T-Backend-Models-DTO-KorisnikDTOInsertUpdate 'T:Backend.Models.DTO.KorisnikDTOInsertUpdate') | Ime korisnika. Obavezno polje. |

<a name='M-Backend-Models-DTO-KorisnikDTOInsertUpdate-#ctor-System-String,System-String,System-String,System-String-'></a>
### #ctor(Ime,Prezime,Email,Lozinka) `constructor`

##### Summary

DTO za unos i izmjenu korisnika.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Ime | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ime korisnika. Obavezno polje. |
| Prezime | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Prezime korisnika. Obavezno polje. |
| Email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Email korisnika. Obavezno polje. Mora biti u ispravnom formatu. |
| Lozinka | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Lozinka korisnika. |

<a name='P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Email'></a>
### Email `property`

##### Summary

Email korisnika. Obavezno polje. Mora biti u ispravnom formatu.

<a name='P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Ime'></a>
### Ime `property`

##### Summary

Ime korisnika. Obavezno polje.

<a name='P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Lozinka'></a>
### Lozinka `property`

##### Summary

Lozinka korisnika.

<a name='P-Backend-Models-DTO-KorisnikDTOInsertUpdate-Prezime'></a>
### Prezime `property`

##### Summary

Prezime korisnika. Obavezno polje.

<a name='T-Backend-Models-DTO-KorisnikDTORead'></a>
## KorisnikDTORead `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO objekt za čitanje podataka o korisniku.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [T:Backend.Models.DTO.KorisnikDTORead](#T-T-Backend-Models-DTO-KorisnikDTORead 'T:Backend.Models.DTO.KorisnikDTORead') | Šifra korisnika. |

<a name='M-Backend-Models-DTO-KorisnikDTORead-#ctor-System-Int32,System-String,System-String,System-String,System-String-'></a>
### #ctor(Sifra,Ime,Prezime,Email,Lozinka) `constructor`

##### Summary

DTO objekt za čitanje podataka o korisniku.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra korisnika. |
| Ime | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ime korisnika. |
| Prezime | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Prezime korisnika. |
| Email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Email korisnika. |
| Lozinka | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Lozinka korisnika. |

<a name='P-Backend-Models-DTO-KorisnikDTORead-Email'></a>
### Email `property`

##### Summary

Email korisnika.

<a name='P-Backend-Models-DTO-KorisnikDTORead-Ime'></a>
### Ime `property`

##### Summary

Ime korisnika.

<a name='P-Backend-Models-DTO-KorisnikDTORead-Lozinka'></a>
### Lozinka `property`

##### Summary

Lozinka korisnika.

<a name='P-Backend-Models-DTO-KorisnikDTORead-Prezime'></a>
### Prezime `property`

##### Summary

Prezime korisnika.

<a name='P-Backend-Models-DTO-KorisnikDTORead-Sifra'></a>
### Sifra `property`

##### Summary

Šifra korisnika.

<a name='T-Backend-Models-ListaZelja'></a>
## ListaZelja `type`

##### Namespace

Backend.Models

##### Summary

Klasa koja predstavlja listu želja.

<a name='P-Backend-Models-ListaZelja-Korisnik'></a>
### Korisnik `property`

##### Summary

Korisnik koji je kreirao listu želja.

<a name='P-Backend-Models-ListaZelja-Naziv'></a>
### Naziv `property`

##### Summary

Naziv liste želja.

<a name='P-Backend-Models-ListaZelja-Placanje'></a>
### Placanje `property`

##### Summary

Način plaćanja.

<a name='P-Backend-Models-ListaZelja-Proizvodi'></a>
### Proizvodi `property`

##### Summary

Proizvodi koji se nalaze na listi želja.

<a name='T-Backend-Controllers-ListaZeljaController'></a>
## ListaZeljaController `type`

##### Namespace

Backend.Controllers

<a name='M-Backend-Controllers-ListaZeljaController-Delete-System-Int32-'></a>
### Delete(sifra) `method`

##### Summary

Briše listu želja po šifri.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra liste želja. |

<a name='M-Backend-Controllers-ListaZeljaController-Get'></a>
### Get() `method`

##### Summary

Metoda za dohvat svih lista želja.

##### Returns

Listu DTO objekata liste želja.

##### Parameters

This method has no parameters.

<a name='M-Backend-Controllers-ListaZeljaController-GetBySifra-System-Int32-'></a>
### GetBySifra(sifra) `method`

##### Summary

Dohvaća listu želja po šifri.

##### Returns

DTO objekt liste želja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra liste želja. |

<a name='M-Backend-Controllers-ListaZeljaController-Post-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-'></a>
### Post(dto) `method`

##### Summary

Dodaje novu listu želja.

##### Returns

Status kreiranja i DTO objekt nove liste želja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [Backend.Models.DTO.ListaZeljaDTOInsertUpdate](#T-Backend-Models-DTO-ListaZeljaDTOInsertUpdate 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate') | DTO objekt za unos ili ažuriranje liste želja. |

<a name='M-Backend-Controllers-ListaZeljaController-Put-System-Int32,Backend-Models-DTO-ListaZeljaDTOInsertUpdate-'></a>
### Put(sifra,dto) `method`

##### Summary

Ažurira postojeću listu želja po šifri.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra liste želja. |
| dto | [Backend.Models.DTO.ListaZeljaDTOInsertUpdate](#T-Backend-Models-DTO-ListaZeljaDTOInsertUpdate 'Backend.Models.DTO.ListaZeljaDTOInsertUpdate') | DTO objekt za unos ili ažuriranje liste želja. |

<a name='T-Backend-Models-DTO-ListaZeljaDTOInsertUpdate'></a>
## ListaZeljaDTOInsertUpdate `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO za unos i izmjenu liste želja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Naziv | [T:Backend.Models.DTO.ListaZeljaDTOInsertUpdate](#T-T-Backend-Models-DTO-ListaZeljaDTOInsertUpdate 'T:Backend.Models.DTO.ListaZeljaDTOInsertUpdate') | Naziv liste želja. |

<a name='M-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-#ctor-System-String,System-Int32,System-String-'></a>
### #ctor(Naziv,KorisnikSifra,Placanje) `constructor`

##### Summary

DTO za unos i izmjenu liste želja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Naziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv liste želja. |
| KorisnikSifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra korisnika kojem lista želja pripada. Obavezno polje. |
| Placanje | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Način plaćanja. |

<a name='P-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-KorisnikSifra'></a>
### KorisnikSifra `property`

##### Summary

Šifra korisnika kojem lista želja pripada. Obavezno polje.

<a name='P-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-Naziv'></a>
### Naziv `property`

##### Summary

Naziv liste želja.

<a name='P-Backend-Models-DTO-ListaZeljaDTOInsertUpdate-Placanje'></a>
### Placanje `property`

##### Summary

Način plaćanja.

<a name='T-Backend-Models-DTO-ListaZeljaDTORead'></a>
## ListaZeljaDTORead `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO objekt za čitanje podataka o listi želja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [T:Backend.Models.DTO.ListaZeljaDTORead](#T-T-Backend-Models-DTO-ListaZeljaDTORead 'T:Backend.Models.DTO.ListaZeljaDTORead') | Šifra liste želja. |

<a name='M-Backend-Models-DTO-ListaZeljaDTORead-#ctor-System-Int32,System-String,System-String,System-String-'></a>
### #ctor(Sifra,Naziv,KorisnikImePrezime,Placanje) `constructor`

##### Summary

DTO objekt za čitanje podataka o listi želja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra liste želja. |
| Naziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv liste želja. |
| KorisnikImePrezime | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ime i prezime korisnika kojem lista želja pripada. |
| Placanje | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Način plaćanja. |

<a name='P-Backend-Models-DTO-ListaZeljaDTORead-KorisnikImePrezime'></a>
### KorisnikImePrezime `property`

##### Summary

Ime i prezime korisnika kojem lista želja pripada.

<a name='P-Backend-Models-DTO-ListaZeljaDTORead-Naziv'></a>
### Naziv `property`

##### Summary

Naziv liste želja.

<a name='P-Backend-Models-DTO-ListaZeljaDTORead-Placanje'></a>
### Placanje `property`

##### Summary

Način plaćanja.

<a name='P-Backend-Models-DTO-ListaZeljaDTORead-Sifra'></a>
### Sifra `property`

##### Summary

Šifra liste želja.

<a name='T-Backend-Data-PcwebshopContext'></a>
## PcwebshopContext `type`

##### Namespace

Backend.Data

##### Summary

Klasa koja predstavlja kontekst baze podataka za aplikaciju Pcwebshop.

<a name='M-Backend-Data-PcwebshopContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Backend-Data-PcwebshopContext}-'></a>
### #ctor(opcije) `constructor`

##### Summary

Konstruktor klase PcwebshopContext koji prima opcije za konfiguraciju konteksta.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| opcije | [Microsoft.EntityFrameworkCore.DbContextOptions{Backend.Data.PcwebshopContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{Backend-Data-PcwebshopContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{Backend.Data.PcwebshopContext}') | Opcije za konfiguraciju konteksta. |

<a name='P-Backend-Data-PcwebshopContext-Kategorije'></a>
### Kategorije `property`

##### Summary

Skup podataka za entitet Kategorija.

<a name='P-Backend-Data-PcwebshopContext-Korisnici'></a>
### Korisnici `property`

##### Summary

Skup podataka za entitet Korisnik.

<a name='P-Backend-Data-PcwebshopContext-ListeZelja'></a>
### ListeZelja `property`

##### Summary

Skup podataka za entitet ListaZelja.

<a name='P-Backend-Data-PcwebshopContext-Proizvodi'></a>
### Proizvodi `property`

##### Summary

Skup podataka za entitet Proizvod.

<a name='M-Backend-Data-PcwebshopContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating(modelBuilder) `method`

##### Summary

Konfiguracija modela prilikom kreiranja baze podataka.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelBuilder | [Microsoft.EntityFrameworkCore.ModelBuilder](#T-Microsoft-EntityFrameworkCore-ModelBuilder 'Microsoft.EntityFrameworkCore.ModelBuilder') | Graditelj modela. |

<a name='T-Backend-Controllers-PcwebshopController'></a>
## PcwebshopController `type`

##### Namespace

Backend.Controllers

##### Summary

Apsraktna klasa PcwebshopController koja služi kao osnovna klasa za sve kontrolere

<a name='M-Backend-Controllers-PcwebshopController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper-'></a>
### #ctor(context,mapper) `constructor`

##### Summary

Konstruktor klase PcwebshopController

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Backend.Data.PcwebshopContext](#T-Backend-Data-PcwebshopContext 'Backend.Data.PcwebshopContext') | Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka. |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | Instanca IMapper sučelja koja se koristi za mapiranje objekta. |

<a name='F-Backend-Controllers-PcwebshopController-_context'></a>
### _context `constants`

##### Summary

Kontekst baze podataka

<a name='T-Backend-Mapping-PcwebshopMappingProfile'></a>
## PcwebshopMappingProfile `type`

##### Namespace

Backend.Mapping

##### Summary

Klasa koja predstavlja mapiranje između entiteta i DTO objekata.

<a name='M-Backend-Mapping-PcwebshopMappingProfile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Konstruktor u kojem se definiraju mapiranja.

##### Parameters

This constructor has no parameters.

<a name='T-Backend-Models-Proizvod'></a>
## Proizvod `type`

##### Namespace

Backend.Models

##### Summary

Klasa koja predstavlja proizvod.

<a name='P-Backend-Models-Proizvod-Cijena'></a>
### Cijena `property`

##### Summary

Cijena proizvoda.

<a name='P-Backend-Models-Proizvod-Kategorija'></a>
### Kategorija `property`

##### Summary

Kategorija kojoj proizvod pripada.

<a name='P-Backend-Models-Proizvod-ListeZelja'></a>
### ListeZelja `property`

##### Summary

Lista želja koja sadrži ovaj proizvod.

<a name='P-Backend-Models-Proizvod-Naziv'></a>
### Naziv `property`

##### Summary

Naziv proizvoda.

<a name='T-Backend-Controllers-ProizvodController'></a>
## ProizvodController `type`

##### Namespace

Backend.Controllers

##### Summary

Kontroler za rad sa proizvodima.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [T:Backend.Controllers.ProizvodController](#T-T-Backend-Controllers-ProizvodController 'T:Backend.Controllers.ProizvodController') | Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka. |

<a name='M-Backend-Controllers-ProizvodController-#ctor-Backend-Data-PcwebshopContext,AutoMapper-IMapper-'></a>
### #ctor(context,mapper) `constructor`

##### Summary

Kontroler za rad sa proizvodima.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Backend.Data.PcwebshopContext](#T-Backend-Data-PcwebshopContext 'Backend.Data.PcwebshopContext') | Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka. |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | Instanca IMapper sučelja koja se koristi za mapiranje objekta. |

<a name='M-Backend-Controllers-ProizvodController-Delete-System-Int32-'></a>
### Delete(sifra) `method`

##### Summary

Briše proizvod po šifri.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra proizvoda |

<a name='M-Backend-Controllers-ProizvodController-Get'></a>
### Get() `method`

##### Summary

Metoda za dohvat svih proizvoda.

##### Returns

Lista DTO objekata proizvoda.

##### Parameters

This method has no parameters.

<a name='M-Backend-Controllers-ProizvodController-GetBySifra-System-Int32-'></a>
### GetBySifra(sifra) `method`

##### Summary

Dohvaća proizvod po šifri.

##### Returns

DTO objekt proizvoda.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra proizvoda. |

<a name='M-Backend-Controllers-ProizvodController-Post-Backend-Models-DTO-ProizvodDTOInsertUpdate-'></a>
### Post(dto) `method`

##### Summary

Dodaje novi proizvod.

##### Returns

Status kreiranja i DTO objekt novog proizvoda.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [Backend.Models.DTO.ProizvodDTOInsertUpdate](#T-Backend-Models-DTO-ProizvodDTOInsertUpdate 'Backend.Models.DTO.ProizvodDTOInsertUpdate') | DTO objekt za unos ili ažuriranje novog proizvoda. |

<a name='M-Backend-Controllers-ProizvodController-Put-System-Int32,Backend-Models-DTO-ProizvodDTOInsertUpdate-'></a>
### Put(sifra,dto) `method`

##### Summary

Metoda za promjenu proizvoda.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra proizvoda. |
| dto | [Backend.Models.DTO.ProizvodDTOInsertUpdate](#T-Backend-Models-DTO-ProizvodDTOInsertUpdate 'Backend.Models.DTO.ProizvodDTOInsertUpdate') | DTO objekt za unos ili ažuriranje proizvoda |

<a name='T-Backend-Models-DTO-ProizvodDTOInsertUpdate'></a>
## ProizvodDTOInsertUpdate `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO za unos i izmjenu proizvoda.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Naziv | [T:Backend.Models.DTO.ProizvodDTOInsertUpdate](#T-T-Backend-Models-DTO-ProizvodDTOInsertUpdate 'T:Backend.Models.DTO.ProizvodDTOInsertUpdate') | Naziv proizvoda. Obavezno polje. |

<a name='M-Backend-Models-DTO-ProizvodDTOInsertUpdate-#ctor-System-String,System-Nullable{System-Int32},System-Nullable{System-Decimal}-'></a>
### #ctor(Naziv,KategorijaSifra,Cijena) `constructor`

##### Summary

DTO za unos i izmjenu proizvoda.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Naziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv proizvoda. Obavezno polje. |
| KategorijaSifra | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Šifra kategorije kojoj proizvod pripada. |
| Cijena | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | Cijena proizvoda. |

<a name='P-Backend-Models-DTO-ProizvodDTOInsertUpdate-Cijena'></a>
### Cijena `property`

##### Summary

Cijena proizvoda.

<a name='P-Backend-Models-DTO-ProizvodDTOInsertUpdate-KategorijaSifra'></a>
### KategorijaSifra `property`

##### Summary

Šifra kategorije kojoj proizvod pripada.

<a name='P-Backend-Models-DTO-ProizvodDTOInsertUpdate-Naziv'></a>
### Naziv `property`

##### Summary

Naziv proizvoda. Obavezno polje.

<a name='T-Backend-Models-DTO-ProizvodDTORead'></a>
## ProizvodDTORead `type`

##### Namespace

Backend.Models.DTO

##### Summary

DTO objekt za čitanje podataka o proizvodu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [T:Backend.Models.DTO.ProizvodDTORead](#T-T-Backend-Models-DTO-ProizvodDTORead 'T:Backend.Models.DTO.ProizvodDTORead') | Šifra proizvoda. |

<a name='M-Backend-Models-DTO-ProizvodDTORead-#ctor-System-Int32,System-String,System-Nullable{System-Decimal},System-String-'></a>
### #ctor(Sifra,Naziv,Cijena,KategorijaNaziv) `constructor`

##### Summary

DTO objekt za čitanje podataka o proizvodu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Sifra | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Šifra proizvoda. |
| Naziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv proizvoda. |
| Cijena | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | Cijena proizvoda. |
| KategorijaNaziv | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Naziv kategorije kojoj proizvod pripada. |

<a name='P-Backend-Models-DTO-ProizvodDTORead-Cijena'></a>
### Cijena `property`

##### Summary

Cijena proizvoda.

<a name='P-Backend-Models-DTO-ProizvodDTORead-KategorijaNaziv'></a>
### KategorijaNaziv `property`

##### Summary

Naziv kategorije kojoj proizvod pripada.

<a name='P-Backend-Models-DTO-ProizvodDTORead-Naziv'></a>
### Naziv `property`

##### Summary

Naziv proizvoda.

<a name='P-Backend-Models-DTO-ProizvodDTORead-Sifra'></a>
### Sifra `property`

##### Summary

Šifra proizvoda.

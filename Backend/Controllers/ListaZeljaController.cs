using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ListaZeljaController(PcwebshopContext context, IMapper mapper) : PcwebshopController(context, mapper)
    {

        // RUTE
        /// <summary>
        /// Metoda za dohvat svih lista želja.
        /// </summary>
        /// <returns>Listu DTO objekata liste želja.</returns>
        [HttpGet]
        public ActionResult<List<ListaZeljaDTORead>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                return Ok(_mapper.Map<List<ListaZeljaDTORead>>(_context.ListeZelja.Include(lz=>lz.Korisnik)));
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });

            }

        }
        /// <summary>
        /// Dohvaća listu želja po šifri.
        /// </summary>
        /// <param name="sifra">Šifra liste želja.</param>
        /// <returns>DTO objekt liste želja.</returns>
        [HttpGet]
        [Route("{sifra:int}")]
        public ActionResult<ListaZeljaDTORead> GetBySifra(int sifra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            ListaZelja? e;
            try
            {
                e = _context.ListeZelja.Include(lz => lz.Korisnik).FirstOrDefault(lz=>lz.Sifra == sifra);

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Lista želja ne postoji u bazi" });
            }
            return Ok(_mapper.Map<ListaZeljaDTORead>(e));
        }
        /// <summary>
        /// Dodaje novu listu želja.
        /// </summary>
        /// <param name="dto">DTO objekt za unos ili ažuriranje liste želja.</param>
        /// <returns>Status kreiranja i DTO objekt nove liste želja.</returns>
        [HttpPost]
        public IActionResult Post(ListaZeljaDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }

            Korisnik? es;
            try
            {
                es = _context.Korisnici.Find(dto.KorisnikSifra);
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });
            }
            if (es == null)
            {
                return NotFound(new { poruka = "Korisnik ne postoji u bazi" });
            }

            try
            {
                var e = _mapper.Map<ListaZelja>(dto);
                e.Korisnik = es;
                _context.ListeZelja.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<ListaZeljaDTORead>(e));
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }
        /// <summary>
        /// Ažurira postojeću listu želja po šifri.
        /// </summary>
        /// <param name="sifra">Šifra liste želja.</param>
        /// <param name="dto">DTO objekt za unos ili ažuriranje liste želja.</param>
        /// <returns>Status ažuriranja.</returns>
        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, ListaZeljaDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                ListaZelja? e;
                try
                {
                    e = _context.ListeZelja.Find(sifra);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { poruka = ex.Message });
                }


                if (e == null)
                {
                    return NotFound(new { poruka = "Lista želja ne postoji u bazi" });
                }


                Korisnik? es;
                try
                {
                    es = _context.Korisnici.Find(dto.KorisnikSifra);

                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });
                }
                if (es == null)
                {
                    return NotFound(new { poruka = "Korisnik ne postoji u bazi" });
                }

                e = _mapper.Map(dto, e);
                e.Korisnik = es; //

                _context.ListeZelja.Update(e);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno promjenjeno" });

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }
        /// <summary>
        /// Briše listu želja po šifri.
        /// </summary>
        /// <param name="sifra">Šifra liste želja.</param>
        /// <returns>Status brisanja.</returns>
        [HttpDelete]
        [Route("{sifra:int}")]

        public IActionResult Delete(int sifra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                ListaZelja? e;
                try
                {
                    e = _context.ListeZelja.Find(sifra);
                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });
                }

                if (e == null)
                {
                    return NotFound("Lista želja ne postoji u bazi");
                }
                _context.ListeZelja.Remove(e);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno obrisano" });
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }

        }
    }
}

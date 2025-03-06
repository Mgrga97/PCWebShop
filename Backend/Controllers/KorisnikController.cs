using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    /// <summary>
    /// Kontroler za rad sa korisnicima
    /// </summary>
    /// <param name="context">Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka</param>
    /// <param name="mapper">Instanca IMapper sučelja koja se koristi za mapiranje objekta</param>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KorisnikController(PcwebshopContext context, IMapper mapper):PcwebshopController(context,mapper)
    {

        // RUTE
        /// <summary>
        /// Metoda za dohvat svih korisnika.
        /// </summary>
        /// <returns>Listu DTO objekata korisnika.</returns>
        [HttpGet]
        public ActionResult<List<KorisnikDTORead>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                return Ok(_mapper.Map<List<KorisnikDTORead>>(_context.Korisnici));
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });

            }

        }
        /// <summary>
        /// Metoda za dohvat korisnika po šifri.
        /// </summary>
        /// <param name="sifra">Šifra korisnika.</param>
        /// <returns>DTO objekt korisnika.</returns>
        [HttpGet]
        [Route("{sifra:int}")]
        public ActionResult<KorisnikDTORead> GetBySifra(int sifra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            Korisnik? e;
            try
            {
                e = _context.Korisnici.Find(sifra);
                
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Korisnik ne postoji u bazi" });
            }
            return Ok(_mapper.Map<KorisnikDTORead>(e));
        }
        /// <summary>
        /// Dodaje novog korisnika.
        /// </summary>
        /// <param name="dto">DTO objekt korisnik koji se stvara ili ažurira.</param>
        /// <returns>Status kreiranja i DTO objekt novog korisnika.</returns>
        [HttpPost]
        public IActionResult Post(KorisnikDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                var e = _mapper.Map<Korisnik>(dto);
                _context.Korisnici.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<KorisnikDTORead>(e));
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }
        /// <summary>
        /// Metoda za promjenu korisnika.
        /// </summary>
        /// <param name="sifra">Šifra korisnika.</param>
        /// <param name="dto">DTO objekt za unos ili ažuriranje korisnika.</param>
        /// <returns>Status ažuriranja.</returns>
        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, KorisnikDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                Korisnik? e;
                try
                {
                    e = _context.Korisnici.Find(sifra);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { poruka = ex.Message });
                }
                

                if (e == null)
                {
                    return NotFound(new { poruka = "Korisnik ne postoji u bazi" });
                }

                e = _mapper.Map(dto, e);


                _context.Korisnici.Update(e);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno promjenjeno" });

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }
        /// <summary>
        /// Briše korisnika po šifri.
        /// </summary>
        /// <param name="sifra">Šifra korisnika.</param>
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
                Korisnik? e;
                try
                {
                    e = _context.Korisnici.Find(sifra);
                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });
                }
                
                if (e == null)
                {
                    return NotFound("Korisnik ne postoji u bazi");
                }
                _context.Korisnici.Remove(e);
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

using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KorisnikController:ControllerBase
    {
       

        private readonly PcwebshopContext _context;

        public KorisnikController(PcwebshopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Korisnici);
            }
            catch (Exception e)
            {
                return BadRequest(e);

            }

        }

        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {
            try
            {
                var s = _context.Korisnici.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                return Ok(s);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        [HttpPost]
        public IActionResult Post(Korisnik korisnik)
        {
            try
            {
                _context.Korisnici.Add(korisnik);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, korisnik);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, Korisnik korisnik)
        {
            try
            {
                var s = _context.Korisnici.Find(sifra);

                if (s == null)
                {
                    return NotFound();
                }

                // Ručno mapiranje kasnije ide automapper
                s.ime = korisnik.ime;
                s.prezime = korisnik.prezime;
                s.email = korisnik.email;
                s.lozinka = korisnik.lozinka;



                _context.Korisnici.Update(s);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno promjenjeno" });

            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        [HttpDelete]
        [Route("{sifra:int}")]

        public IActionResult Delete(int sifra)
        {
            try
            {
                var s = _context.Korisnici.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                _context.Korisnici.Remove(s);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno obrisano" });
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

    }
}

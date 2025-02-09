using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KategorijeController : ControllerBase
    {

        private readonly PcwebshopContext _context;


        public KategorijeController(PcwebshopContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Kategorije);
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
                var s = _context.Kategorije.Find(sifra);
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
        public IActionResult Post(Kategorije kategorija)
        {
            try
            {
                _context.Kategorije.Add(kategorija);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, kategorija);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, Kategorije kategorija)
        {
            try
            {
                var s = _context.Kategorije.Find(sifra);

                if (s == null)
                {
                    return NotFound();
                }

                // Ručno mapiranje kasnije ide automapper
                s.Naziv = kategorija.Naziv;
                


                _context.Kategorije.Update(s);
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
                var s = _context.Kategorije.Find(sifra);
                if (s == null)
                {
                    return NotFound();
                }
                _context.Kategorije.Remove(s);
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

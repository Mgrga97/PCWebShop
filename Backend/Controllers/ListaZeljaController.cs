using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ListaZeljaController(PcwebshopContext context, IMapper mapper) : PcwebshopController(context, mapper)
    {

        // RUTE

        [HttpGet]
        public ActionResult<List<ListaZeljaDTORead>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                return Ok(_mapper.Map<List<ListaZeljaDTORead>>(_context.Korisnici));
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });

            }

        }

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
            return Ok(_mapper.Map<ListaZeljaDTORead>(e));
        }

        [HttpPost]
        public IActionResult Post(ListaZeljaDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                var e = _mapper.Map<ListaZelja>(dto);
                _context.ListeZelja.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<ListaZeljaDTORead>(e));
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }

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

                e = _mapper.Map(dto, e);


                _context.ListeZelja.Update(e);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno promjenjeno" });

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }

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

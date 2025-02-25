using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KategorijaController(PcwebshopContext context, IMapper mapper) : PcwebshopController(context, mapper)
    {

        

        [HttpGet]
        public ActionResult<List<KategorijaDTORead>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                return Ok(_mapper.Map<List<KategorijaDTORead>>(_context.Kategorije));
            }
            catch (Exception ex)
            {
                return BadRequest(new {poruka=ex.Message});

            }


        }

        [HttpGet]
        [Route("{sifra:int}")]
        public ActionResult<KategorijaDTORead> GetBySifra(int sifra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            Kategorija? e;
            try
            {
                 e = _context.Kategorije.Find(sifra);

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Kategorija ne postoji u bazi" });
            }

            return Ok(_mapper.Map<KategorijaDTORead>(e));
        }


        [HttpPost]
        public IActionResult Post(KategorijaDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                var e = _mapper.Map<Kategorija>(dto);
                _context.Kategorije.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<KategorijaDTORead>(e));
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, KategorijaDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                Kategorija? e;
                try
                {
                    e = _context.Kategorije.Find(sifra);
                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });
                }
                if (e == null)
                {
                    return NotFound(new { poruka = "Kategorija ne postoji u bazi" });
                }
                e = _mapper.Map(dto, e);

                _context.Kategorije.Update(e);
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
                Kategorija? e;
                try
                {
                    e = _context.Kategorije.Find(sifra);
                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });
                }
                
                if (e == null)
                {
                    return NotFound("Kategorija ne postoji u bazi");
                }
                _context.Kategorije.Remove(e);
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

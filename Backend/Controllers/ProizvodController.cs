using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Backend.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProizvodController(PcwebshopContext context, IMapper mapper) : PcwebshopController(context, mapper)
    {





        // RUTE

        [HttpGet]
        public ActionResult<List<ProizvodDTORead>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                return Ok(_mapper.Map<List<ProizvodDTORead>>(_context.Proizvodi.Include(p=>p.Kategorija)));
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });

            }

        }

        [HttpGet]
        [Route("{sifra:int}")]
        public ActionResult<ProizvodDTORead> GetBySifra(int sifra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            Proizvod? e;
            try
            {
                e = _context.Proizvodi.Find(sifra);

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Proizvod ne postoji u bazi" });
            }
            return Ok(_mapper.Map<ProizvodDTORead>(e));
        }

        [HttpPost]
        [Route("{sifra:int}")]
        public IActionResult Post(int sifra, ProizvodDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }


            Proizvod? e;
            try
            {
                e = _context.Proizvodi.Include(g => g.Kategorija).FirstOrDefault(x => x.Sifra == sifra);
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Proizvod ne postoji u bazi" });
            }

            Kategorija? es;
            try
            {
                es = _context.Kategorije.Find(dto.KategorijaSifra);
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });
            }
            if (es == null)
            {
                return NotFound(new { poruka = "Kategorija ne postoji u bazi" });
            }


            try
            {
                e = _mapper.Map(dto, e);
                e.Kategorija = es;
                _context.Proizvodi.Update(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<ProizvodDTORead>(e));
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, ProizvodDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                Proizvod? e;
                try
                {
                    e = _context.Proizvodi.Find(sifra);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { poruka = ex.Message });
                }


                if (e == null)
                {
                    return NotFound(new { poruka = "Proizvod ne postoji u bazi" });
                }

                Kategorija? es;
                try
                {
                    es = _context.Kategorije.Find(dto.KategorijaSifra);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { poruka = ex.Message });
                }
                if (es == null)
                {
                    return NotFound(new { poruka = "Kategorija ne postoji u bazi" });
                }

                // pronadi kategoriju


                e = _mapper.Map(dto, e);
                e.Kategorija = es; // pronadena kategorija

                _context.Proizvodi.Update(e);
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
                Proizvod? e;
                try
                {
                    e = _context.Proizvodi.Find(sifra);
                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });
                }

                if (e == null)
                {
                    return NotFound("Proizvod ne postoji u bazi");
                }
                _context.Proizvodi.Remove(e);
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

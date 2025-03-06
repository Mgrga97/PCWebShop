using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Backend.Controllers
{
    /// <summary>
    /// Kontroler za rad sa kategorijama.
    /// </summary>
    /// <param name="context">kontekst baze podataka.</param>
    /// <param name="mapper">mapper za mapiranje objekta.</param>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KategorijaController(PcwebshopContext context, IMapper mapper) : PcwebshopController(context, mapper)
    {

        /// <summary>
        /// Metoda za dohvat svih kategorija
        /// </summary>
        /// <returns>Daje listu kategorija.</returns>

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
        /// <summary>
        /// Metoda za dohvat kategorije po šifri.
        /// </summary>
        /// <param name="sifra">Šifra kategorije.</param>
        /// <returns>Kategorija.</returns>
        [HttpGet]
        [Route("{sifra:int}")]
        public ActionResult<KategorijaDTOInsertUpdate> GetBySifra(int sifra)
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

            return Ok(_mapper.Map<KategorijaDTOInsertUpdate>(e));
        }

        /// <summary>
        /// Metoda za dodavanje kategorije.
        /// </summary>
        /// <param name="dto">Podaci o kategoriji.</param>
        /// <returns> Status kreiranja.</returns>
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
        /// <summary>
        /// Metoda za promjenu kategorije
        /// </summary>
        /// <param name="sifra">Šifra kategorije.</param>
        /// <param name="dto">Naziv kategorije.</param>
        /// <returns>Status promjene podataka.</returns>
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
        /// <summary>
        /// Metoda za brisanje kategorije.
        /// </summary>
        /// <param name="sifra">Šifra kategorije.</param>
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

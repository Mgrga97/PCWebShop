using AutoMapper;
using Backend.Data;
using Backend.Models;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    /// <summary>
    /// Kontroler za rad sa proizvodima. 
    /// </summary>
    /// <param name="context">Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka.</param>
    /// <param name="mapper">Instanca IMapper sučelja koja se koristi za mapiranje objekta.</param>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProizvodController(PcwebshopContext context, IMapper mapper) : PcwebshopController(context, mapper)
    {





        // RUTE
        /// <summary>
        /// Metoda za dohvat svih proizvoda.
        /// </summary>
        /// <returns>Lista DTO objekata proizvoda.</returns>
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
        /// <summary>
        /// Dohvaća proizvod po šifri.
        /// </summary>
        /// <param name="sifra">Šifra proizvoda.</param>
        /// <returns>DTO objekt proizvoda.</returns>
        [HttpGet]
        [Route("{sifra:int}")]
        public ActionResult<ProizvodDTOInsertUpdate> GetBySifra(int sifra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            Proizvod? e;
            try
            {
                e = _context.Proizvodi.Include(p => p.Kategorija).FirstOrDefault(p => p.Sifra == sifra);

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Proizvod ne postoji u bazi" });
            }
            return Ok(_mapper.Map<ProizvodDTOInsertUpdate>(e));
        }
        /// <summary>
        /// Dodaje novi proizvod.
        /// </summary>
        /// <param name="dto">DTO objekt za unos ili ažuriranje novog proizvoda.</param>
        /// <returns>Status kreiranja i DTO objekt novog proizvoda.</returns>
        [HttpPost]
        public IActionResult Post(ProizvodDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
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
                var e = _mapper.Map<Proizvod>(dto);
                e.Kategorija = es;
                _context.Proizvodi.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<ProizvodDTORead>(e));
            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });
            }
        }
        /// <summary>
        /// Metoda za promjenu proizvoda.
        /// </summary>
        /// <param name="sifra">Šifra proizvoda.</param>
        /// <param name="dto">DTO objekt za unos ili ažuriranje proizvoda</param>
        /// <returns>Status ažuriranja.</returns>
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
        /// <summary>
        /// Briše proizvod po šifri.
        /// </summary>
        /// <param name="sifra">Šifra proizvoda</param>
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

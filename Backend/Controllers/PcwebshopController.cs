using AutoMapper;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    /// <summary>
    /// Apsraktna klasa PcwebshopController koja služi kao osnovna klasa za sve kontrolere
    /// </summary>
    public abstract class PcwebshopController: ControllerBase
    {
        /// <summary>
        /// Kontekst baze podataka
        /// </summary>
        protected readonly PcwebshopContext _context;

        protected readonly IMapper _mapper;


        /// <summary>
        /// Konstruktor klase PcwebshopController
        /// </summary>
        /// <param name="context">Instanca PcwebshopContext klase koja se koristi za pristup bazi podataka.</param>
        /// <param name="mapper">Instanca IMapper sučelja koja se koristi za mapiranje objekta.</param>
        public PcwebshopController(PcwebshopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    }
}

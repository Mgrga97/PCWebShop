using AutoMapper;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public abstract class PcwebshopController: ControllerBase
    {

        protected readonly PcwebshopContext _context;

        protected readonly IMapper _mapper;


        
        public PcwebshopController(PcwebshopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    }
}

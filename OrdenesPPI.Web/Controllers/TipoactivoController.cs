using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Web.Models;

namespace OrdenesPPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoactivoController : ControllerBase
    {
        private readonly ITipoactivoService _TipoactivoService;
        private readonly IMapper _Mapper;

        public TipoactivoController(ITipoactivoService tipoactivoService, IMapper mapper)
        {
            _TipoactivoService = tipoactivoService;
            _Mapper = mapper;
        }

        // GET: api/TipoactivoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoactivoModel>>> Get()
        {
            var tipoactivos =
                        await _TipoactivoService.GetAll();

            var mappedTipoactivos =
                        _Mapper.Map<IEnumerable<Tipoactivo>, IEnumerable<TipoactivoModel>>(tipoactivos);

            return Ok(mappedTipoactivos);
        }

    }
}

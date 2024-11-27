using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Web.Models;
using OrdenesPPI.Core.Entities;

namespace OrdenesPPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivoController : ControllerBase
    {
        private readonly IActivoService _ActivoService;
        private readonly IMapper _Mapper;

        public ActivoController(IActivoService ActivoService, IMapper mapper)
        {
            _ActivoService = ActivoService;
            _Mapper = mapper;
        }

        // GET: api/<ActivoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivoModel>>> Get()
        {
            var activos =
                        await _ActivoService.GetAll();

            var mappedActivos =
                        _Mapper.Map<IEnumerable<Activo>, IEnumerable<ActivoModel>>(activos);

            return Ok(mappedActivos);
        }

        // GET api/<ActivoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivoModel>> Get(int id)
        {
            var activo =
                        await _ActivoService.GetActivoById(id);

            var mappedActivo =
                    _Mapper.Map<Activo, ActivoModel>(activo);

            return Ok(mappedActivo);

        }

    }
}

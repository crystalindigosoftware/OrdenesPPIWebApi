using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Services;
using OrdenesPPI.Web.Models;

namespace OrdenesPPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoService _EstadoService;
        private readonly IMapper _Mapper;

        public EstadoController(IEstadoService EstadoService, IMapper mapper)
        {
            _EstadoService = EstadoService;
            _Mapper = mapper;
        }

        // GET: api/<EstadoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoModel>>> Get()
        {
            var estados =
                        await _EstadoService.GetAll();

            var mappedEstados =
                        _Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoModel>>(estados);

            return Ok(mappedEstados);
        }
    }
}

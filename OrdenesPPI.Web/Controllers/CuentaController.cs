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
    public class CuentaController : ControllerBase
    {
        private readonly ICuentaService _CuentaService;
        private readonly IMapper _Mapper;

        public CuentaController(ICuentaService CuentaService, IMapper mapper)
        {
            _CuentaService = CuentaService;
            _Mapper = mapper;
        }

        // GET: api/<CuentaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuentaModel>>> Get()
        {
            var cuentas =
                        await _CuentaService.GetAll();

            var mappedCuentas =
                        _Mapper.Map<IEnumerable<Cuenta>, IEnumerable<CuentaModel>>(cuentas);

            return Ok(mappedCuentas);
        }

    }
}

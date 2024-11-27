using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Core.DTOs;
using OrdenesPPI.Web.Models;
using OrdenesPPI.Services;
using OrdenesPPI.Core.Views;


namespace OrdenesPPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        //Aplicamos inyeccion de dependencias / AutoMapper Injection
        private readonly IOrdenService _OrdenService;
        private readonly IMapper _Mapper;

        public OrdenController(IOrdenService OrdenService, IMapper mapper)
        {
            _OrdenService = OrdenService;
            _Mapper = mapper;
        }


        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<V_Ordenes>>> GetAllOrdenes()
        {
            var ordenes =
                        await _OrdenService.GetAllOrdenes();

            return Ok(ordenes);
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<IEnumerable<V_Ordenes>>> GetOrdenesById(int Id)
        {
            var ordenes =
                        await _OrdenService.GetOrdenesById(Id);

            return Ok(ordenes);
        }

        [HttpPost]
        public async Task<ActionResult<DTOCreateOrdenResponse>> Post([FromBody] DTOCreateOrdenRequest orden)
        {
            try
            {
                var createdOrden =
                    await _OrdenService.CreateOrden(orden);

                return Ok(createdOrden);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<DTOUpdateOrdenResponse>> UpdateOrden(DTOUpdateOrdenRequest orden)
        {
            try
            {
                var ordenUpdated = await _OrdenService.UpdateOrden(orden);

                return Ok(ordenUpdated);
            }
            catch {
                return StatusCode(500, "Error al intentar modificar el estado de la orden");
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteOrden(int Id)
        {

            try
            {
                await _OrdenService.DeleteOrden(Id);

                var message = new
                {
                    message = $"La orden nro {Id} fue eliminada con éxito"
                };

                return Ok(message);
            }
            catch
            {
                return StatusCode(500, "La orden no pudo ser eliminada o ya fue eliminada previamente");
            }

        }
    }
}

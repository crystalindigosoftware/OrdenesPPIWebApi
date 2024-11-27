using FluentValidation;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.DTOs;
using OrdenesPPI.Core.Views;
using OrdenesPPI.Core.Interfaces;
using OrdenesPPI.Core.Interfaces.Services;
using OrdenesPPI.Services.Validators;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrdenesPPI.Services
{
    public class OrdenService : IOrdenService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrdenService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DTOCreateOrdenResponse> CreateOrden(DTOCreateOrdenRequest newOrden)
        {
            OrdenValidator validator = new();

            Orden orden = new Orden
            {
                CuentaId = newOrden.CuentaId,
                ActivoId = newOrden.ActivoId,
                Operacion = newOrden.Operacion,
                Cantidad = newOrden.Cantidad,
                EstadoId = 0 // agregamos el estado "En Proceso" segun tabla de Estados
            };

            DTOCreateOrdenResponse OrdenResult = new DTOCreateOrdenResponse();

            decimal PrecioUnitario = newOrden.PrecioUnitario;
            decimal Cantidad = orden.Cantidad;
            decimal Monto;
            decimal ValorComision;
            decimal Comisiones;
            decimal Impuestos;

            var validationResult = await validator.ValidateAsync(orden);

            if (PrecioUnitario <= 0) {
                validationResult.Errors.Add(
                    new FluentValidation.Results.ValidationFailure { PropertyName = "Precio Unitario", ErrorMessage = " El precio debe ser mayor a 0" });
            }

            if (validationResult.IsValid && (PrecioUnitario > 0))
            {
                Activo activo = await _unitOfWork.ActivoRepository.GetByIdAsync(orden.ActivoId);

                int TipoActivo = activo.TipoActivoId;

                if (TipoActivo == 1)
                { //Accion

                    //toma el precio del activo de la BBDD
                    decimal PrecioActivo = activo.PrecioUnitario;

                    Monto = PrecioActivo * Cantidad;
                    ValorComision = 0.006m;
                    Comisiones = Monto * ValorComision;
                    Impuestos = Comisiones * 0.21m;

                    orden.Monto = Monto;
                    orden.Comisiones = Comisiones;
                    orden.Impuestos = Impuestos;
                    orden.MontoTotal = Monto - (Comisiones + Impuestos);

                }
                else if (TipoActivo == 2)
                { //Bono
                    Monto = PrecioUnitario * Cantidad;
                    ValorComision = 0.002m;
                    Comisiones = Monto * ValorComision;
                    Impuestos = Comisiones * 0.21m;

                    orden.Monto = Monto;
                    orden.Comisiones = Comisiones;
                    orden.Impuestos = Impuestos;
                    orden.MontoTotal = Monto - (Comisiones + Impuestos);
                }
                else if (TipoActivo == 3)
                { //FCI
                    Monto = PrecioUnitario * Cantidad;
                    orden.Monto = Monto;
                    orden.MontoTotal = Monto;
                }

                await _unitOfWork.OrdenRepository.AddAsync(orden);
                await _unitOfWork.CommitAsync();

                OrdenResult = new DTOCreateOrdenResponse
                {
                    IdOrden = orden.Id,
                    message = "Orden Generada como exito"
                };

            }
            else
            {
                var PropertyName = JsonSerializer.Serialize(validationResult.Errors[0].PropertyName);
                var ErrorMessage = JsonSerializer.Serialize(validationResult.Errors[0].ErrorMessage);

                OrdenResult = new DTOCreateOrdenResponse
                {
                    IdOrden = 0,
                    message = $"ErrorMessage: {ErrorMessage} - PropertyName: {PropertyName}".Replace("'", "\\u027")
                };

                return OrdenResult;
            }

            return OrdenResult;
        }

        public async Task DeleteOrden(int OrdenId)
        {
            Orden orden = await _unitOfWork.OrdenRepository.GetByIdAsync(OrdenId);
            _unitOfWork.OrdenRepository.Remove(orden);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<V_Ordenes>> GetAllOrdenes()
        {

            return await _unitOfWork.OrdenRepository.GetAllOrdenes();
        }

        public async Task<V_Ordenes> GetOrdenesById(int Id)
        {
            return await _unitOfWork.OrdenRepository.GetOrdenesById(Id);
        }

        public async Task<DTOUpdateOrdenResponse> UpdateOrden(DTOUpdateOrdenRequest newOrdenValues)
        {

            int OrdenToBeUpdatedId = newOrdenValues.Id;
            Orden ordenToBeUpdated = await _unitOfWork.OrdenRepository.GetByIdAsync(OrdenToBeUpdatedId);

            DTOUpdateOrdenResponse OrdenResult = new DTOUpdateOrdenResponse();

            if (ordenToBeUpdated == null)
            {
                OrdenResult = new DTOUpdateOrdenResponse
                {
                    IdOrden = OrdenToBeUpdatedId,
                    message = $"La orden nro {OrdenToBeUpdatedId} no existe"
                };

                return OrdenResult;
            }
            else
            {
                ordenToBeUpdated.EstadoId = newOrdenValues.EstadoId; //modifica el estado de la orden

                OrdenValidator validator = new();
                var validationResult = await validator.ValidateAsync(ordenToBeUpdated);

                if (validationResult.IsValid) {
                    await _unitOfWork.OrdenRepository.Update(ordenToBeUpdated);
                    await _unitOfWork.CommitAsync();

                    OrdenResult = new DTOUpdateOrdenResponse
                    {
                        IdOrden = OrdenToBeUpdatedId,
                        message = $"El estado de la orden nro {OrdenToBeUpdatedId} fue cambiado exito"
                    };
                }
                else{
                    var PropertyName = JsonSerializer.Serialize(validationResult.Errors[0].PropertyName);
                    var ErrorMessage = JsonSerializer.Serialize(validationResult.Errors[0].ErrorMessage);

                    OrdenResult = new DTOUpdateOrdenResponse
                    {
                        IdOrden = 0,
                        message = $"ErrorMessage: {ErrorMessage} - PropertyName: {PropertyName}".Replace("\\\"", "")
                    };

                    return OrdenResult;
                }

            

                return OrdenResult;
            }
        }
    }
}

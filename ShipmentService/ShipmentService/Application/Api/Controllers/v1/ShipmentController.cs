using AutoMapper;
using DomainModel.Entities;
using DomainService.Abstract;
using Dto.Request.Shipment;
using Dto.Response.Shipment;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [Route("api/shipment")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentService _shipmentService;
        private readonly IMapper _mapper;

        public ShipmentController(
            IShipmentService shipmentService,
            IMapper mapper)
        {
            this._shipmentService = shipmentService;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ShipmentCreateRequestDto requestDto)
        {
            var shipment = _mapper.Map<Shipment>(requestDto);
            var createdShipment = await _shipmentService.CreateAsync(shipment);
            return Created(string.Empty, _mapper.Map<ShipmentGetByIdResponseDto>(createdShipment));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var shipments = await _shipmentService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ShipmentGetAllResponseDto>>(shipments));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var shipment = await _shipmentService.GetByIdAsync(id);
            return Ok(_mapper.Map<ShipmentGetByIdResponseDto>(shipment));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] ShipmentUpdateRequestDto requestDto)
        {
            var currentShipment = _mapper.Map<Shipment>(requestDto);
            var updatedShipment = await _shipmentService.UpdateAsync(currentShipment);
            return Ok(_mapper.Map<ShipmentGetByIdResponseDto>(updatedShipment));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var shipment = await _shipmentService.GetByIdAsync(id);
            await _shipmentService.DeleteAsync(shipment);
            return Ok();
        }
    }
}

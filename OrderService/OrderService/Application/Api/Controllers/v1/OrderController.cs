using AutoMapper;
using DomainModel.Entities;
using DomainService.Abstract;
using Dto.Request.Order;
using Dto.Response.Order;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(
            IOrderService orderService,
            IMapper mapper)
        {
            this._orderService = orderService;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] OrderCreateRequestDto requestDto)
        {
            var order = _mapper.Map<Order>(requestDto);
            var createdOrder = await _orderService.CreateAsync(order);
            return Created(string.Empty, _mapper.Map<OrderGetByIdResponseDto>(createdOrder));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OrderGetAllResponseDto>>(orders));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var order = await _orderService.GetByIdAsync(id);
            return Ok(_mapper.Map<OrderGetByIdResponseDto>(order));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] OrderUpdateRequestDto requestDto)
        {
            var currentOrder = _mapper.Map<Order>(requestDto);
            var updatedOrder = await _orderService.UpdateAsync(currentOrder);
            return Ok(_mapper.Map<OrderGetByIdResponseDto>(updatedOrder));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var order = await _orderService.GetByIdAsync(id);
            await _orderService.DeleteAsync(order);
            return Ok();
        }
    }
}

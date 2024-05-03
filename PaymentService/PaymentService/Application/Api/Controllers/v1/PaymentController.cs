using AutoMapper;
using DomainModel.Entities;
using DomainService.Abstract;
using Dto.Request.Payment;
using Dto.Response.Payment;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;

        public PaymentController(
            IPaymentService paymentService,
            IMapper mapper)
        {
            this._paymentService = paymentService;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] PaymentCreateRequestDto requestDto)
        {
            var payment = _mapper.Map<Payment>(requestDto);
            var createdPayment = await _paymentService.CreateAsync(payment);
            return Created(string.Empty, _mapper.Map<PaymentGetByIdResponseDto>(createdPayment));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var payments = await _paymentService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<PaymentGetAllResponseDto>>(payments));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var payment = await _paymentService.GetByIdAsync(id);
            return Ok(_mapper.Map<PaymentGetByIdResponseDto>(payment));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] PaymentUpdateRequestDto requestDto)
        {
            var currentPayment = _mapper.Map<Payment>(requestDto);
            var updatedPayment = await _paymentService.UpdateAsync(currentPayment);
            return Ok(_mapper.Map<PaymentGetByIdResponseDto>(updatedPayment));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var payment = await _paymentService.GetByIdAsync(id);
            await _paymentService.DeleteAsync(payment);
            return Ok();
        }
    }
}

using AutoMapper;
using DomainModel.Entities;
using DomainService.Abstract;
using Dto.Request.Product;
using Dto.Response;
using Dto.Response.Product;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(
            IProductService productService,
            IMapper mapper)
        {
            this._productService = productService;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ProductCreateRequestDto requestDto)
        {
            var product = _mapper.Map<Product>(requestDto);
            var createdProduct = await _productService.CreateAsync(product);
            return Created(string.Empty, _mapper.Map<ProductGetByIdResponseDto>(createdProduct));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var products = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductGetAllResponseDto>>(products));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductGetByIdResponseDto>(product));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] ProductUpdateRequestDto requestDto)
        {
            var currentProduct = _mapper.Map<Product>(requestDto);
            var updatedProduct = await _productService.UpdateAsync(currentProduct);
            return Ok(_mapper.Map<ProductGetByIdResponseDto>(updatedProduct));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            await _productService.DeleteAsync(product);
            return Ok();
        }
    }
}

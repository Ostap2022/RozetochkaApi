using Application.Services.Product;
using Application.Services.Product.Dto;
using Microsoft.AspNetCore.Mvc;

namespace RozetochkaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public Guid Create([FromBody] CreateProductDto model)
        {
            return _service.Create(model);
        }

        [HttpGet]
        public ProductDto Get(Guid id)
        {
            return _service.Get(id);
        }

        [HttpPut]
        public void Update([FromBody] ProductDto model)
        {
            _service.Update(model);
        }

        [HttpDelete]
        public void Delete([FromQuery] Guid id)
        {
            _service.Delete(id);
        }
    }
}

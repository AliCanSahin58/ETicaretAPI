using ETicaretAPI.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productServices;

        public ProductsController(IProductService productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
           var products = _productServices.GetProducts();
            return Ok(products);
        }

            
    }
}

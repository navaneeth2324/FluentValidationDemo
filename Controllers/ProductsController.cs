using FluentValidation;
using FluentValidationDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IValidator<Product> _validator;
        public ProductsController(IValidator<Product> validator)
        {
            _validator = validator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var validationResult = await _validator.ValidateAsync(product);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return Ok($"Product '{product.Name}' created.");
        }
    }
}

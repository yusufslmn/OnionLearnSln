using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionLearn.Application.Features.Products.Queries.GetAllProducts;

namespace OnionLearn.Api.Controller;
[Route("api/[controller]/[action]")]
[ApiController]
public class ProductController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var response = await mediator.Send(new GetAllProductsQueryRequest());
        
        return Ok(response);
    }
}
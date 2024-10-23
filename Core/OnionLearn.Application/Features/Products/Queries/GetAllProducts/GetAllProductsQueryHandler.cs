using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionLearn.Application.DTOs;
using OnionLearn.Application.Interfaces.AutoMapper;
using OnionLearn.Application.Interfaces.UnitOfWork;
using OnionLearn.Domain.Entities;

namespace OnionLearn.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler (IUnitOfWork unitOfWork,IMapper mapper): IRequestHandler<GetAllProductsQueryRequest,IList<GetAllProductsQueryResponse>>
{
    
    public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        
        var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x=> x.Include(b => b.Brand));
        List<GetAllProductsQueryResponse> response = [];
        var brand  = mapper.Map<BrandDto, Brand>(new Brand());
        var map = mapper.Map<GetAllProductsQueryResponse, Product>(products);
        foreach (var item in products)
            item.Price -= (item.Price * item.Discount/100);
        return  map;
    }
}
public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
{
    
}

public class GetAllProductsQueryResponse
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public decimal? Discount { get; set; }
    public BrandDto? Brand { get; set; }
    
}
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionLearn.Domain.Entities;

namespace Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        Faker faker = new();
        Product product = new()
        {
            Id = 1,
            Title = faker.Commerce.ProductName(),
            Description = faker.Commerce.ProductDescription(),
            BrandId =1,
            Discount = faker.Random.Decimal(0,10),
            Price = faker.Finance.Amount(10,1000),
            CreatedAtDate = DateTime.Now,
            IsDeleted = false
        };
        Product product2 = new()
        {
            Id = 2,
            Title = faker.Commerce.ProductName(),
            Description = faker.Commerce.ProductDescription(),
            BrandId =3,
            Discount = faker.Random.Decimal(0,10),
            Price = faker.Finance.Amount(10,1000),
            CreatedAtDate = DateTime.Now,
            IsDeleted = false
        };
        builder.HasData(product, product2);
    }
}
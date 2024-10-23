using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionLearn.Domain.Entities;

namespace Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        Category category1 = new()
        {
            Id = 1,
            Name = "Elektronik",
            ParentId = 0,
            IsDeleted = false,
            CreatedAtDate = DateTime.Now
        };
        Category category2 = new()
        {
            Id = 2,
            Name = "Moda",
            ParentId = 1,
            IsDeleted = false,
            CreatedAtDate = DateTime.Now
        };
        Category parent1  = new()
        {
            Id = 3,
            Name = "Bilgisayar",
            ParentId = 1,
            Priorty = 1,
            IsDeleted = false,
            CreatedAtDate = DateTime.Now
        };
        Category parent2  = new()
        {
            Id = 4,
            Name = "Kadın",
            ParentId = 2,
            Priorty = 1,
            IsDeleted = false,
            CreatedAtDate = DateTime.Now
        };

        builder.HasData(category1, category2, parent1, parent2);


    }
}
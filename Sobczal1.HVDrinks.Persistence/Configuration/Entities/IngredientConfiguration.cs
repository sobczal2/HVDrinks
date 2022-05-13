using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sobczal1.HVDrinks.Domain.Ingredients;

namespace Sobczal1.HVDrinks.Persistence.Configuration.Entities;

public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
{
    public void Configure(EntityTypeBuilder<Ingredient> builder)
    {
        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(128);

        builder
            .Property(p => p.Description)
            .HasMaxLength(1000)
            .IsRequired();

        builder
            .Property(p => p.AlcoholContent)
            .IsRequired()
            .HasPrecision(2);

        builder
            .Property(p => p.Unit)
            .IsRequired();

        builder
            .HasData(new List<Ingredient>
            {
                new Ingredient
                {
                    Id = new Guid("14A46FBB-D82C-4570-BC86-5ADF7C3DE44E"),
                    DateCreated = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "SYSTEM",
                    Name = "Mint leaves",
                    Description = "Fresh mint leaves",
                    AlcoholContent = 0,
                    Unit = IngredientUnit.Pieces,
                },
                new Ingredient
                {
                    Id = new Guid("7625A4DE-4DB6-45DB-BE34-480FCE62176A"),
                    DateCreated = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "SYSTEM",
                    Name = "Lime",
                    Description = "Good citrus fruit",
                    AlcoholContent = 0,
                    Unit = IngredientUnit.Pieces,
                },
                new Ingredient
                {
                    Id = new Guid("27033481-37A0-4A27-A8B5-46B9FFF40B46"),
                    DateCreated = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "SYSTEM",
                    Name = "Sugar",
                    Description = "White death",
                    AlcoholContent = 0,
                    Unit = IngredientUnit.Tablespoons,
                },
                new Ingredient
                {
                    Id = new Guid("33529D05-4C02-49CC-8CEE-3E097B75631C"),
                    DateCreated = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "SYSTEM",
                    Name = "Ice cubes",
                    Description = "Frozen water in cubes",
                    AlcoholContent = 0,
                    Unit = IngredientUnit.Pieces,
                },
            });
    }
}
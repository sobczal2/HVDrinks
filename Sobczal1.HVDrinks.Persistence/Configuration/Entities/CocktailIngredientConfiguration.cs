using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Configuration.Entities;

public class CocktailIngredientConfiguration : IEntityTypeConfiguration<CocktailIngredient>
{
    public void Configure(EntityTypeBuilder<CocktailIngredient> builder)
    {
        builder
            .HasOne(p => p.Cocktail)
            .WithMany(p => p.CocktailIngredients)
            .HasForeignKey(p => p.CocktailId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(p => p.Ingredient)
            .WithMany(p => p.CocktailIngredients)
            .HasForeignKey(p => p.IngredientId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(p => p.CocktailId)
            .IsRequired();

        builder
            .Property(p => p.IngredientId)
            .IsRequired();

        builder.HasData(new List<CocktailIngredient>
        {
            new CocktailIngredient
            {
                Id = new Guid("D2B6338F-500F-4033-BC31-13AAAAA92472"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
                IngredientId = new Guid("14A46FBB-D82C-4570-BC86-5ADF7C3DE44E"),
                Amount = 10,
            },
            new CocktailIngredient
            {
                Id = new Guid("22CFC3D8-D2DF-4A04-93D0-CE600E7B6B35"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
                IngredientId = new Guid("7625A4DE-4DB6-45DB-BE34-480FCE62176A"),
                Amount = 0.5,
            },
            new CocktailIngredient
            {
                Id = new Guid("661DBC23-2CD1-4697-8BC6-C1AF72058197"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
                IngredientId = new Guid("27033481-37A0-4A27-A8B5-46B9FFF40B46"),
                Amount = 2,
            },
            new CocktailIngredient
            {
                Id = new Guid("5C497F0F-5AF5-44D4-A1A5-2CE7A964859C"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
                IngredientId = new Guid("33529D05-4C02-49CC-8CEE-3E097B75631C"),
                Amount = 5,
            },
        });
    }
}
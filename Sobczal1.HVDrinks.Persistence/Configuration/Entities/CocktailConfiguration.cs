using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Configuration.Entities;

public class CocktailConfiguration : IEntityTypeConfiguration<Cocktail>
{
    public void Configure(EntityTypeBuilder<Cocktail> builder)
    {
        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(128);
        
        builder
            .Property(p => p.Description)
            .HasMaxLength(5000)
            .IsRequired();

        builder
            .HasData(new List<Cocktail>
            {
                new Cocktail
                {
                    Id = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
                    DateCreated = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "SYSTEM",
                    Name = "Mojito",
                    Popularity = 0,
                    Description =
                        "A mojito is a classic highball drink that originated in Cuba. Not surprisingly, this cocktail uses ingredients indigenous to Cuba, including rum, lime, mint, and sugar. The mixture is topped off with a little club soda to create a thirst-quenching libation. It requires a bit more labor than many mixed drinks, as it involves first muddling fresh mint, lime, and sugar together to release the flavors. But it's well worth it for a refreshing, fizzy, and mildly sweet rum cocktail that remains one of the most popular to this day.",
                    RecipeSteps = new List<CocktailRecipeStep>(),
                    CocktailIngredients = new List<CocktailIngredient>(),
                    CocktailImages = new List<CocktailImage>(),
                }
            });
    }
}
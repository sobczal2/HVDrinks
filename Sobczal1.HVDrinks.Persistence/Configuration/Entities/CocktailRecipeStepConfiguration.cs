using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Configuration.Entities;

public class CocktailRecipeStepConfiguration : IEntityTypeConfiguration<CocktailRecipeStep>
{
    public void Configure(EntityTypeBuilder<CocktailRecipeStep> builder)
    {
        builder
            .Property(p => p.StepNumber)
            .IsRequired();

        builder
            .Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder
            .HasOne(p => p.Cocktail)
            .WithMany(p => p.RecipeSteps)
            .HasForeignKey(p => p.CocktailId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(new List<CocktailRecipeStep>
        {
            new CocktailRecipeStep
            {
                Id = new Guid("4A521831-BF13-41E8-B335-6D3FADA0BD7C"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                StepNumber = 1,
                Description =
                    "Place mint leaves and 1 lime wedge into a sturdy glass. Use a muddler and crush to release mint oils and lime juice.",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
            },
            new CocktailRecipeStep
            {
                Id = new Guid("BB82DA15-FFB8-4A28-AEEB-F310D75A6A7D"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                StepNumber = 2,
                Description =
                    "Add remaining lime wedges and 2 tablespoons sugar, and muddle again to release the lime juice. Do not strain the mixture.",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
            },
            new CocktailRecipeStep
            {
                Id = new Guid("1A46275B-A5E3-4CF8-BE21-E942DF3EB863"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                StepNumber = 3,
                Description =
                    "Fill the glass almost to the top with ice. Pour in rum and fill the glass with club soda.",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
            },
            new CocktailRecipeStep
            {
                Id = new Guid("4D14BCFF-2161-4ACC-93AB-B1E6D5D1FC1A"),
                DateCreated = DateTime.Now,
                CreatedBy = "SYSTEM",
                LastModifiedDate = DateTime.Now,
                LastModifiedBy = "SYSTEM",
                StepNumber = 4,
                Description = "Stir, taste, and add more sugar if desired.",
                CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC"),
            }
        });
    }
}
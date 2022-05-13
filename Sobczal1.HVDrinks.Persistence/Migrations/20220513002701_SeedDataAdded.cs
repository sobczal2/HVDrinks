using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sobczal1.HVDrinks.Persistence.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recipe",
                table: "Cocktails");

            migrationBuilder.CreateTable(
                name: "CocktailRecipeStep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CocktailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailRecipeStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CocktailRecipeStep_Cocktails_CocktailId",
                        column: x => x.CocktailId,
                        principalTable: "Cocktails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(1636), "A mojito is a classic highball drink that originated in Cuba. Not surprisingly, this cocktail uses ingredients indigenous to Cuba, including rum, lime, mint, and sugar. The mixture is topped off with a little club soda to create a thirst-quenching libation. It requires a bit more labor than many mixed drinks, as it involves first muddling fresh mint, lime, and sugar together to release the flavors. But it's well worth it for a refreshing, fizzy, and mildly sweet rum cocktail that remains one of the most popular to this day.", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(1672), "Mojito" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "AlcoholContent", "CreatedBy", "DateCreated", "Description", "LastModifiedBy", "LastModifiedDate", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("14a46fbb-d82c-4570-bc86-5adf7c3de44e"), 0.0, "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6714), "Fresh mint leaves", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6719), "Mint leaves", 1 },
                    { new Guid("27033481-37a0-4a27-a8b5-46b9fff40b46"), 0.0, "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6729), "White death", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6730), "Sugar", 2 },
                    { new Guid("33529d05-4c02-49cc-8cee-3e097b75631c"), 0.0, "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6733), "Frozen water in cubes", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6735), "Ice cubes", 1 },
                    { new Guid("7625a4de-4db6-45db-be34-480fce62176a"), 0.0, "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6724), "Good citrus fruit", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6726), "Lime", 1 }
                });

            migrationBuilder.InsertData(
                table: "CocktailImages",
                columns: new[] { "Id", "Alt", "CocktailId", "CreatedBy", "DateCreated", "LastModifiedBy", "LastModifiedDate", "Url" },
                values: new object[] { new Guid("7b25695e-ff81-4e41-b8ec-7977559985b7"), "Stock image of a smart dishwasher", new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(2974), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(2984), "somerandomurl1" });

            migrationBuilder.InsertData(
                table: "CocktailIngredients",
                columns: new[] { "Id", "Amount", "CocktailId", "CreatedBy", "DateCreated", "IngredientId", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("22cfc3d8-d2df-4a04-93d0-ce600e7b6b35"), 0.5, new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5085), new Guid("7625a4de-4db6-45db-be34-480fce62176a"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5087) },
                    { new Guid("5c497f0f-5af5-44d4-a1a5-2ce7a964859c"), 5.0, new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5096), new Guid("33529d05-4c02-49cc-8cee-3e097b75631c"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5097) },
                    { new Guid("661dbc23-2cd1-4697-8bc6-c1af72058197"), 2.0, new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5091), new Guid("27033481-37a0-4a27-a8b5-46b9fff40b46"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5092) },
                    { new Guid("d2b6338f-500f-4033-bc31-13aaaaa92472"), 10.0, new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5067), new Guid("14a46fbb-d82c-4570-bc86-5adf7c3de44e"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5077) }
                });

            migrationBuilder.InsertData(
                table: "CocktailRecipeStep",
                columns: new[] { "Id", "CocktailId", "CreatedBy", "DateCreated", "Description", "LastModifiedBy", "LastModifiedDate", "StepNumber" },
                values: new object[,]
                {
                    { new Guid("1a46275b-a5e3-4cf8-be21-e942df3eb863"), new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6265), "Fill the glass almost to the top with ice. Pour in rum and fill the glass with club soda.", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6266), 3 },
                    { new Guid("4a521831-bf13-41e8-b335-6d3fada0bd7c"), new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6242), "Place mint leaves and 1 lime wedge into a sturdy glass. Use a muddler and crush to release mint oils and lime juice.", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6252), 1 },
                    { new Guid("4d14bcff-2161-4acc-93ab-b1e6d5d1fc1a"), new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6270), "Stir, taste, and add more sugar if desired.", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6271), 4 },
                    { new Guid("bb82da15-ffb8-4a28-aeeb-f310d75a6a7d"), new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"), "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6259), "Add remaining lime wedges and 2 tablespoons sugar, and muddle again to release the lime juice. Do not strain the mixture.", "SYSTEM", new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6260), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailRecipeStep_CocktailId",
                table: "CocktailRecipeStep",
                column: "CocktailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailRecipeStep");

            migrationBuilder.DeleteData(
                table: "CocktailImages",
                keyColumn: "Id",
                keyValue: new Guid("7b25695e-ff81-4e41-b8ec-7977559985b7"));

            migrationBuilder.DeleteData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("22cfc3d8-d2df-4a04-93d0-ce600e7b6b35"));

            migrationBuilder.DeleteData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("5c497f0f-5af5-44d4-a1a5-2ce7a964859c"));

            migrationBuilder.DeleteData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("661dbc23-2cd1-4697-8bc6-c1af72058197"));

            migrationBuilder.DeleteData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("d2b6338f-500f-4033-bc31-13aaaaa92472"));

            migrationBuilder.DeleteData(
                table: "Cocktails",
                keyColumn: "Id",
                keyValue: new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("14a46fbb-d82c-4570-bc86-5adf7c3de44e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("27033481-37a0-4a27-a8b5-46b9fff40b46"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("33529d05-4c02-49cc-8cee-3e097b75631c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7625a4de-4db6-45db-be34-480fce62176a"));

            migrationBuilder.AddColumn<string>(
                name: "Recipe",
                table: "Cocktails",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");
        }
    }
}

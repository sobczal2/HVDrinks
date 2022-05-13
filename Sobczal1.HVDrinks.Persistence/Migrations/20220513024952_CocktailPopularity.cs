using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sobczal1.HVDrinks.Persistence.Migrations
{
    public partial class CocktailPopularity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Popularity",
                table: "Cocktails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CocktailImages",
                keyColumn: "Id",
                keyValue: new Guid("7b25695e-ff81-4e41-b8ec-7977559985b7"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(3258), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("22cfc3d8-d2df-4a04-93d0-ce600e7b6b35"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("5c497f0f-5af5-44d4-a1a5-2ce7a964859c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5285), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("661dbc23-2cd1-4697-8bc6-c1af72058197"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5279), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("d2b6338f-500f-4033-bc31-13aaaaa92472"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("1a46275b-a5e3-4cf8-be21-e942df3eb863"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6431), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("4a521831-bf13-41e8-b335-6d3fada0bd7c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("4d14bcff-2161-4acc-93ab-b1e6d5d1fc1a"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("bb82da15-ffb8-4a28-aeeb-f310d75a6a7d"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "Id",
                keyValue: new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(2039), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("14a46fbb-d82c-4570-bc86-5adf7c3de44e"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6894), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("27033481-37a0-4a27-a8b5-46b9fff40b46"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6912), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("33529d05-4c02-49cc-8cee-3e097b75631c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7625a4de-4db6-45db-be34-480fce62176a"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6907), new DateTime(2022, 5, 13, 4, 49, 51, 898, DateTimeKind.Local).AddTicks(6908) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "Cocktails");

            migrationBuilder.UpdateData(
                table: "CocktailImages",
                keyColumn: "Id",
                keyValue: new Guid("7b25695e-ff81-4e41-b8ec-7977559985b7"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("22cfc3d8-d2df-4a04-93d0-ce600e7b6b35"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("5c497f0f-5af5-44d4-a1a5-2ce7a964859c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3369), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("661dbc23-2cd1-4697-8bc6-c1af72058197"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3364), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("d2b6338f-500f-4033-bc31-13aaaaa92472"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3342), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("1a46275b-a5e3-4cf8-be21-e942df3eb863"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4402), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("4a521831-bf13-41e8-b335-6d3fada0bd7c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("4d14bcff-2161-4acc-93ab-b1e6d5d1fc1a"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4407), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("bb82da15-ffb8-4a28-aeeb-f310d75a6a7d"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4397), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "Id",
                keyValue: new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(75), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("14a46fbb-d82c-4570-bc86-5adf7c3de44e"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4906), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("27033481-37a0-4a27-a8b5-46b9fff40b46"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("33529d05-4c02-49cc-8cee-3e097b75631c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7625a4de-4db6-45db-be34-480fce62176a"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4918), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(4919) });
        }
    }
}

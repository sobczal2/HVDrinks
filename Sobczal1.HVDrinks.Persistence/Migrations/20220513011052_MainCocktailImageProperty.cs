﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sobczal1.HVDrinks.Persistence.Migrations
{
    public partial class MainCocktailImageProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Main",
                table: "CocktailImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CocktailImages",
                keyColumn: "Id",
                keyValue: new Guid("7b25695e-ff81-4e41-b8ec-7977559985b7"),
                columns: new[] { "DateCreated", "LastModifiedDate", "Main" },
                values: new object[] { new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 5, 13, 3, 10, 51, 899, DateTimeKind.Local).AddTicks(1317), true });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Main",
                table: "CocktailImages");

            migrationBuilder.UpdateData(
                table: "CocktailImages",
                keyColumn: "Id",
                keyValue: new Guid("7b25695e-ff81-4e41-b8ec-7977559985b7"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(2974), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("22cfc3d8-d2df-4a04-93d0-ce600e7b6b35"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5085), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("5c497f0f-5af5-44d4-a1a5-2ce7a964859c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("661dbc23-2cd1-4697-8bc6-c1af72058197"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5091), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "CocktailIngredients",
                keyColumn: "Id",
                keyValue: new Guid("d2b6338f-500f-4033-bc31-13aaaaa92472"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5067), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("1a46275b-a5e3-4cf8-be21-e942df3eb863"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6265), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("4a521831-bf13-41e8-b335-6d3fada0bd7c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6242), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("4d14bcff-2161-4acc-93ab-b1e6d5d1fc1a"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "CocktailRecipeStep",
                keyColumn: "Id",
                keyValue: new Guid("bb82da15-ffb8-4a28-aeeb-f310d75a6a7d"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6259), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Cocktails",
                keyColumn: "Id",
                keyValue: new Guid("cdcf7ae2-a928-453e-8373-34ed6c1b9ddc"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("14a46fbb-d82c-4570-bc86-5adf7c3de44e"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("27033481-37a0-4a27-a8b5-46b9fff40b46"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6729), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("33529d05-4c02-49cc-8cee-3e097b75631c"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7625a4de-4db6-45db-be34-480fce62176a"),
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 5, 13, 2, 27, 0, 782, DateTimeKind.Local).AddTicks(6726) });
        }
    }
}

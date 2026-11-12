using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StroyBuildings.Api.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "Id", "Description", "IconUrl", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("02fc083e-10cd-475e-8f7a-ff883cf742bb"), "Уборка помещений после строительных и ремонтных работ.", null, "Клининг после ремонта", "klining-posle-remonta" },
                    { new Guid("4846f7d9-6934-4204-858a-e51b7dd487e8"), "Виды услуг которые не вошли в основные категории", null, "Другое", "drugoe" },
                    { new Guid("6b036b85-ab8e-4876-897b-2cda7ae32fb0"), "Установка и ремонт смесителей, труб, унитазов, ванн и бойлеров.", null, "Сантехника", "santehnika" },
                    { new Guid("6f6a15cf-dc58-4ffd-9e9b-619bf1445bad"), "Монтаж проводки, розеток, выключателей, освещения и электрощитов.", null, "Электрика", "elektrika" },
                    { new Guid("bb6b1e2a-5ae8-4082-b814-bfbb333bab74"), "Штукатурка, покраска, поклейка обоев, укладка плитки и ламината.", null, "Отделка", "otdelka" },
                    { new Guid("bef1bccc-811f-47bf-b698-0c990a2fb298"), "Установка, регулировка и ремонт окон, межкомнатных и входных дверей.", null, "Окна и двери", "okna-i-dveri" },
                    { new Guid("ff75c14b-5dda-4efe-99bf-9c2d41aa56ae"), "Сборка и установка шкафов, кроватей, кухонь и другой мебели.", null, "Сборка мебели", "sborka-mebeli" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("02fc083e-10cd-475e-8f7a-ff883cf742bb"));

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4846f7d9-6934-4204-858a-e51b7dd487e8"));

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b036b85-ab8e-4876-897b-2cda7ae32fb0"));

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f6a15cf-dc58-4ffd-9e9b-619bf1445bad"));

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb6b1e2a-5ae8-4082-b814-bfbb333bab74"));

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bef1bccc-811f-47bf-b698-0c990a2fb298"));

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff75c14b-5dda-4efe-99bf-9c2d41aa56ae"));
        }
    }
}

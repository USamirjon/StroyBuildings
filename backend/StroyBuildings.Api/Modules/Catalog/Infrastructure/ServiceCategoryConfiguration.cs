using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StroyBuildings.Api.Modules.Catalog.Domain;

namespace StroyBuildings.Api.Modules.Catalog.Infrastructure;

public class ServiceCategoryConfiguration : IEntityTypeConfiguration<ServiceCategory>
{
    public void Configure(EntityTypeBuilder<ServiceCategory> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Slug).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.IconUrl).HasMaxLength(500);
        builder.HasIndex(x => x.Slug).IsUnique();
        builder.HasData(
            new ServiceCategory
            {
                Id = new Guid("6b036b85-ab8e-4876-897b-2cda7ae32fb0"),
                Name = "Сантехника",
                Slug = "santehnika",
                Description = "Установка и ремонт смесителей, труб, унитазов, ванн и бойлеров."
            },
            new ServiceCategory
            {
                Id = new Guid("6f6a15cf-dc58-4ffd-9e9b-619bf1445bad"),
                Name = "Электрика",
                Slug = "elektrika",
                Description = "Монтаж проводки, розеток, выключателей, освещения и электрощитов."
            },
            new ServiceCategory
            {
                Id = new Guid("bb6b1e2a-5ae8-4082-b814-bfbb333bab74"),
                Name = "Отделка",
                Slug = "otdelka",
                Description = "Штукатурка, покраска, поклейка обоев, укладка плитки и ламината."
            },
            new ServiceCategory
            {
                Id = new Guid("ff75c14b-5dda-4efe-99bf-9c2d41aa56ae"),
                Name = "Сборка мебели",
                Slug = "sborka-mebeli",
                Description = "Сборка и установка шкафов, кроватей, кухонь и другой мебели."
            },
            new ServiceCategory
            {
                Id = new Guid("bef1bccc-811f-47bf-b698-0c990a2fb298"),
                Name = "Окна и двери",
                Slug = "okna-i-dveri",
                Description = "Установка, регулировка и ремонт окон, межкомнатных и входных дверей."
            },
            new ServiceCategory
            {
                Id = new Guid("02fc083e-10cd-475e-8f7a-ff883cf742bb"),
                Name = "Клининг после ремонта",
                Slug = "klining-posle-remonta",
                Description = "Уборка помещений после строительных и ремонтных работ."
            },
            new ServiceCategory
            {
                Id = new Guid("4846f7d9-6934-4204-858a-e51b7dd487e8"),
                Name = "Другое",
                Slug = "drugoe",
                Description = "Виды услуг которые не вошли в основные категории"
            }
        );
    }
}
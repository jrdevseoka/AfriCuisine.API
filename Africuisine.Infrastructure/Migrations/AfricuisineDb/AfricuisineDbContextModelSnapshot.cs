﻿// <auto-generated />
using System;
using Africuisine.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Africuisine.Infrastructure.Migrations.AfricuisineDb
{
    [DbContext(typeof(AfricuisineDbContext))]
    partial class AfricuisineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Africuisine.Domain.Entities.Ingredients.Ingredient", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.Ingredients.IngredientCategory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("IX_IngredientCategories_Name");

                    b.ToTable("IngredientCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "807ab00b-98a3-45cc-beba-ba21e0a0e6bd",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6133),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6142),
                            Name = "Proteins",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "8683a038-322b-45b3-931c-e741a42988a5",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6208),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6209),
                            Name = "Vegetables And Herbs",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "95e35d51-d1d7-45e8-855f-652136a54870",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6216),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6216),
                            Name = "Fruits",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "8c1f9087-f855-4c5b-8f10-b39f7efb366f",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6229),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6230),
                            Name = "Grains And Starches",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "7273756b-833a-466e-9c58-95fe9cb4698b",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6244),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6244),
                            Name = "Dairy And Dairy Alternatives",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "20856263-12ce-470c-9774-35c956f39456",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6257),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6258),
                            Name = "Condiments And Sauces",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "2e3e93c7-e8c4-4a29-a1ed-e2a766c3258e",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6270),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6270),
                            Name = "Spices And Seasonings",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "82278d8d-d085-4644-8afd-c65ee4a82090",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6287),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6288),
                            Name = "Baking Ingredients",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "11731206-5148-4f41-b7ba-e413afe5a58c",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6298),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6299),
                            Name = "Nuts And Seeds",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "c9fa09de-2ad0-4a73-af8f-75ee048219fe",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6305),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(6306),
                            Name = "Beverages",
                            SeqNo = 0
                        });
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.Ingredients.Measurement", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("IX_Measurements_Name");

                    b.ToTable("Measurements", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "847ee189-564e-480b-85c4-a2c41d709703",
                            Abbreviation = "ml",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7154),
                            Description = "Used for liquids, such as water, milk, and oil",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7157),
                            Name = "Milliliter",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "764d354d-58e6-432f-ba83-51d6356b1dcd",
                            Abbreviation = "l",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7162),
                            Description = "Larger volume measurements, often used for bulk liquids.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7162),
                            Name = "Liters",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "1c5b3ba7-d03b-4a7a-8602-8d981a473a11",
                            Abbreviation = "g",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7167),
                            Description = "Common unit for measuring dry ingredients like flour, sugar, and spices.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7167),
                            Name = "Grams",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "d7bb3a3e-bbf9-4cbe-babd-343b382ed204",
                            Abbreviation = "kg",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7171),
                            Description = "Larger mass measurements, especially for bulk ingredients.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7171),
                            Name = "Kilograms",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "938c3319-73e2-4848-9d39-836dd90bf716",
                            Abbreviation = "tsp.",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7174),
                            Description = "Approximately 5 ml.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7174),
                            Name = "Teaspoon",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "4a432e29-a84f-402d-9c24-9123864ad0ff",
                            Abbreviation = "Tbsp",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7184),
                            Description = "Approximately 15 ml.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7185),
                            Name = "Tablespoon",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "6fe3393f-7970-40ee-858a-217442aa7b36",
                            Abbreviation = "250 ml",
                            Creation = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7188),
                            Description = "Used for both liquid and dry ingredients.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 9, 11, 27, 54, 531, DateTimeKind.Local).AddTicks(7188),
                            Name = "Cup",
                            SeqNo = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

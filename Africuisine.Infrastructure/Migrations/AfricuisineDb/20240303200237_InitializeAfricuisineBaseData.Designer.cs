﻿// <auto-generated />
using System;
using Africuisine.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Africuisine.Infrastructure.Migrations.AfricuisineDb
{
    [DbContext(typeof(AfricuisineDbContext))]
    [Migration("20240303200237_InitializeAfricuisineBaseData")]
    partial class InitializeAfricuisineBaseData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            Id = "3a844963-34ed-4300-9589-00ef2be7e093",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7153),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7163),
                            Name = "Proteins",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "60371825-a9f4-47dc-ad65-0de474a70960",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7234),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7235),
                            Name = "Vegetables And Herbs",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "a215675e-3079-497f-8fb2-fd4cf6931f30",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7242),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7242),
                            Name = "Fruits",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "e5db590a-17b3-45dd-b38d-12d7aa7464bd",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7255),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7256),
                            Name = "Grains And Starches",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "d9bd0148-c913-451a-ba2d-eb017807e5c8",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7281),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7281),
                            Name = "Dairy And Dairy Alternatives",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "2d8724e4-8726-4df9-9239-23d71502ad99",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7295),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7295),
                            Name = "Condiments And Sauces",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "7b7e46e8-98fa-47eb-8818-32f240c02eb4",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7307),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7307),
                            Name = "Spices And Seasonings",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "1348d5a0-4df4-4365-bcb2-ffb3c5177e9b",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7316),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7317),
                            Name = "Baking Ingredients",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "04558d85-00a8-46de-944e-2bb946eb2143",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7328),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7328),
                            Name = "Nuts And Seeds",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "d01312db-1c6f-4b7a-9a89-9304fe246229",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7335),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(7335),
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
                            Id = "215be7ce-6ba5-4eb7-bba0-1c975033ac3a",
                            Abbreviation = "ml",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8224),
                            Description = "Used for liquids, such as water, milk, and oil",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8226),
                            Name = "Milliliter",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "a07300ca-e32f-4581-a836-02a6d088c52e",
                            Abbreviation = "l",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8233),
                            Description = "Larger volume measurements, often used for bulk liquids.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8234),
                            Name = "Liters",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "ea3afeb6-8bf0-4f8f-9624-4f63883fcd27",
                            Abbreviation = "g",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8242),
                            Description = "Common unit for measuring dry ingredients like flour, sugar, and spices.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8243),
                            Name = "Grams",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "613d3d95-a33a-4a70-b42f-17961d26184b",
                            Abbreviation = "kg",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8348),
                            Description = "Larger mass measurements, especially for bulk ingredients.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8348),
                            Name = "Kilograms",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "041d3619-4e2c-470d-ac2c-d0ba3634a838",
                            Abbreviation = "tsp.",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8353),
                            Description = "Approximately 5 ml.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8354),
                            Name = "Teaspoon",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "3815cd54-0663-4540-8da4-3426a204f838",
                            Abbreviation = "Tbsp",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8360),
                            Description = "Approximately 15 ml.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8360),
                            Name = "Tablespoon",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "ac1f0eee-80f9-4503-a821-ef1d1b5ab726",
                            Abbreviation = "250 ml",
                            Creation = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8364),
                            Description = "Used for both liquid and dry ingredients.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 22, 2, 37, 164, DateTimeKind.Local).AddTicks(8364),
                            Name = "Cup",
                            SeqNo = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

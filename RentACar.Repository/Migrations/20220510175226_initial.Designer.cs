// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.Repository;

#nullable disable

namespace RentACar.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220510175226_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentACar.Core.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5008),
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5029),
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5032),
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5033),
                            Name = "Range Rover"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5035),
                            Name = "Opel"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5039),
                            Name = "Fiat"
                        });
                });

            modelBuilder.Entity("RentACar.Core.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModelYear")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Color = "Beyaz",
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5188),
                            FuelType = "Benzin",
                            ImageUrl = "test",
                            LicensePlate = "34ATO3474",
                            ModelYear = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500m,
                            State = true
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            Color = "Siyah",
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5200),
                            FuelType = "Benzin",
                            ImageUrl = "test",
                            LicensePlate = "34ADM3452",
                            ModelYear = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500m,
                            State = true
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            Color = "Kırmızı",
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5206),
                            FuelType = "Benzin",
                            ImageUrl = "test",
                            LicensePlate = "34TR1111",
                            ModelYear = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500m,
                            State = true
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 4,
                            Color = "Mavi",
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5211),
                            FuelType = "Dizel",
                            ImageUrl = "test",
                            LicensePlate = "34İST2222",
                            ModelYear = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500m,
                            State = true
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 5,
                            Color = "Siyah",
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5218),
                            FuelType = "Dizel",
                            ImageUrl = "test",
                            LicensePlate = "34BRT3333",
                            ModelYear = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500m,
                            State = true
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 6,
                            Color = "Beyaz",
                            CreatedDate = new DateTime(2022, 5, 10, 20, 52, 26, 523, DateTimeKind.Local).AddTicks(5225),
                            FuelType = "Benzin",
                            ImageUrl = "test",
                            LicensePlate = "34AS4444",
                            ModelYear = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 500m,
                            State = true
                        });
                });

            modelBuilder.Entity("RentACar.Core.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NationalIdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RentACar.Core.Car", b =>
                {
                    b.HasOne("RentACar.Core.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("RentACar.Core.Brand", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}

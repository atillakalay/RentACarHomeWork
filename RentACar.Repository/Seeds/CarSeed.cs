using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core;

namespace RentACar.Repository.Seeds
{
    public class CarSeed : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(new Car { Id = 1, BrandId = 1, Color = "Beyaz", FuelType = "Benzin", LicensePlate = "34ATO3474", ModelYear = DateTime.Parse("01.01.2018"), Price = 500, State = true, CreatedDate = DateTime.Now, ImageUrl = "test" });
            builder.HasData(new Car { Id = 2, BrandId = 2, Color = "Siyah", FuelType = "Benzin", LicensePlate = "34ADM3452", ModelYear = DateTime.Parse("01.01.2019"), Price = 500, State = true, CreatedDate = DateTime.Now, ImageUrl = "test" });
            builder.HasData(new Car { Id = 3, BrandId = 3, Color = "Kırmızı", FuelType = "Benzin", LicensePlate = "34TR1111", ModelYear = DateTime.Parse("01.01.2019"), Price = 500, State = true, CreatedDate = DateTime.Now, ImageUrl = "test" });
            builder.HasData(new Car { Id = 4, BrandId = 4, Color = "Mavi", FuelType = "Dizel", LicensePlate = "34İST2222", ModelYear = DateTime.Parse("01.01.2019"), Price = 500, State = true, CreatedDate = DateTime.Now, ImageUrl = "test" });
            builder.HasData(new Car { Id = 5, BrandId = 5, Color = "Siyah", FuelType = "Dizel", LicensePlate = "34BRT3333", ModelYear = DateTime.Parse("01.01.2019"), Price = 500, State = true, CreatedDate = DateTime.Now, ImageUrl = "test" });
            builder.HasData(new Car { Id = 6, BrandId = 6, Color = "Beyaz", FuelType = "Benzin", LicensePlate = "34AS4444", ModelYear = DateTime.Parse("01.01.2019"), Price = 500, State = true, CreatedDate = DateTime.Now, ImageUrl = "test" });
        }
    }
}

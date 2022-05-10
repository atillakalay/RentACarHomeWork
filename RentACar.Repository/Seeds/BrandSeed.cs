using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core;

namespace RentACar.Repository.Seeds
{
    public class BrandSeed : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(new Brand { Id = 1, Name = "BMW", CreatedDate = DateTime.Now });
            builder.HasData(new Brand { Id = 2, Name = "Mercedes", CreatedDate = DateTime.Now });
            builder.HasData(new Brand { Id = 3, Name = "Ford", CreatedDate = DateTime.Now });
            builder.HasData(new Brand { Id = 4, Name = "Range Rover", CreatedDate = DateTime.Now });
            builder.HasData(new Brand { Id = 5, Name = "Opel", CreatedDate = DateTime.Now });
            builder.HasData(new Brand { Id = 6, Name = "Fiat", CreatedDate = DateTime.Now });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core;

namespace RentACar.Repository.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Color).IsRequired();
            builder.Property(x => x.FuelType).IsRequired();
            builder.Property(x => x.LicensePlate).IsRequired();
            builder.Property(x => x.ModelYear).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}

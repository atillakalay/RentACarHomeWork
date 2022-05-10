using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core;

namespace RentACar.Repository.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Adress).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.NationalIdentityNumber).IsRequired().HasMaxLength(11);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(13);
        }
    }
}

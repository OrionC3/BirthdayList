using BirthdayList.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BirthdayList.API.Configs
{
    public class GiftConfig : IEntityTypeConfiguration<Gift>
    {
        public void Configure(EntityTypeBuilder<Gift> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(g => g.Description)
                .HasMaxLength(1000);

            builder.Property(g => g.Link)
                .HasMaxLength(1000);
        }
    }
}

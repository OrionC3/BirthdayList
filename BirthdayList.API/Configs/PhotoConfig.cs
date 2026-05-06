using BirthdayList.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BirthdayList.API.Configs
{
    public class PhotoConfig : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Url)
                .IsRequired()
                .HasMaxLength(1000);

            builder.HasOne(p => p.Gift)
                .WithOne(g => g.Photo)
                .HasForeignKey<Photo>(p => p.GiftId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

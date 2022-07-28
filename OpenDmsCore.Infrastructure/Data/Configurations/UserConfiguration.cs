using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Infrastructure.Data.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var entity = builder;
            entity.ToTable("users");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            entity.Property(e => e.CompleteName)
                .IsRequired()
                .HasColumnName("completeName")
                .HasMaxLength(255);

            entity.Property(e => e.Description).HasColumnName("description");

            entity.Property(e => e.UserAccount)
                .IsRequired()
                .HasColumnName("userAccount")
                .HasMaxLength(20);

            entity.Property(e => e.UserPassword)
                .IsRequired()
                .HasColumnName("userPassword")
                .HasMaxLength(80);

            entity.Property(e => e.TeamId)
                .HasColumnName("teamId")
                .HasColumnType("int(11)");

            entity.Property(e => e.EntityId)
                .HasColumnName("entityId")
                .HasColumnType("int(11)");

            entity.Property(e => e.AccessLevel)
                .HasColumnName("accessLevel")
                .HasMaxLength(20);

            entity.Property(e => e.CreatedDate)
                .HasColumnName("createdDate")
                .HasColumnType("date");

            entity.Property(e => e.ExpirationDate)
                .HasColumnName("expirationDate")
                .HasColumnType("date");

            entity.Property(e => e.Disabled).HasColumnName("disabled");
        }
    }
}

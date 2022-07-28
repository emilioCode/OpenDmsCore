using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Infrastructure.Data.Configurations
{
    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            var entity = builder;
            entity.ToTable("entities");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            entity.Property(e => e.EntityName)
                .IsRequired()
                .HasColumnName("entityName")
                .HasMaxLength(50);

            entity.Property(e => e.Disabled).HasColumnName("disabled");
        }
    }
}

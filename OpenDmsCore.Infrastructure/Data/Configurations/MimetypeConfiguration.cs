using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Infrastructure.Data.Configurations
{

    internal class MimetypeConfiguration : IEntityTypeConfiguration<Mimetype>
    {
        public void Configure(EntityTypeBuilder<Mimetype> builder)
        {
            var entity = builder;
            entity.ToTable("mimetypes");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            entity.Property(e => e.Extension)
                .IsRequired()
                .HasColumnName("extension")
                .HasMaxLength(6);

            entity.Property(e => e.KindOfDocument).HasColumnName("kinf_of_document");

            entity.Property(e => e.MimeType)
                .IsRequired()
                .HasColumnName("mime_type")
                .HasMaxLength(100);
        }
    }
}

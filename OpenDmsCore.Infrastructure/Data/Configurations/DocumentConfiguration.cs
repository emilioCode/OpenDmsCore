using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Infrastructure.Data.Configurations
{
    internal class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            var entity = builder; 
            entity.ToTable("documents");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");
           
            entity.Property(e => e.Filename)
                .HasColumnName("filename")
                .HasMaxLength(256);

            entity.Property(e => e.Extension)
                .IsRequired()
                .HasColumnName("extension")
                .HasMaxLength(5);

            entity.Property(e => e.Size).HasColumnName("size");

            entity.Property(e => e.TeamId)
                .HasColumnName("teamId")
                .HasColumnType("int(11)");

            entity.Property(e => e.EntityId)
                .HasColumnName("entityId")
                .HasColumnType("int(11)");

            entity.Property(e => e.InsertionDate)
                .HasColumnName("insertionDate")
                .HasColumnType("date");

            entity.Property(e => e.PathAlternative).HasColumnName("pathAlternative");

            entity.Property(e => e.CommentDetail).HasColumnName("commentDetail");

            entity.Property(e => e.DistinctDetail).HasColumnName("distinctDetail");

            entity.Property(e => e.IdUser)
                .HasColumnName("idUser")
                .HasColumnType("int(11)");

            entity.Property(e => e.Disabled).HasColumnName("disabled");
        }
    }
}

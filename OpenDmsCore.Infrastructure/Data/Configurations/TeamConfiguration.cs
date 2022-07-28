using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Infrastructure.Data.Configurations
{
    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            var entity = builder;
            entity.ToTable("teams");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            entity.Property(e => e.EntityId)
                .HasColumnName("entityId")
                .HasColumnType("int(11)");

            entity.Property(e => e.TeamName)
                .IsRequired()
                .HasColumnName("teamName")
                .HasMaxLength(50);

            entity.Property(e => e.PathRoot)
                .IsRequired()
                .HasColumnName("pathRoot");

            entity.Property(e => e.TelephoneNumber)
                .HasColumnName("telephoneNumber")
                .HasMaxLength(50);

            entity.Property(e => e.HostName)
                .HasColumnName("hostName")
                .HasMaxLength(30);

            entity.Property(e => e.PortNumber)
                .HasColumnName("portNumber")
                .HasColumnType("int(11)");

            entity.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(50);

            entity.Property(e => e.Pass)
                .HasColumnName("pass")
                .HasMaxLength(50);

            entity.Property(e => e.Disabled).HasColumnName("disabled");
        }
    }
}

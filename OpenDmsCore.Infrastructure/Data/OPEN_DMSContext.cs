using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OpenDmsCore.Core.Entities;

namespace OpenDmsCore.Infrastructure.Data
{
    public partial class OPEN_DMSContext : DbContext
    {
        public OPEN_DMSContext()
        {
        }

        public OPEN_DMSContext(DbContextOptions<OPEN_DMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Group> Entities { get; set; }
        public virtual DbSet<Mimetype> Mimetypes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=123456;database=OPEN_DMS");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("documents");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentDetail).HasColumnName("commentDetail");

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.DistinctDetail).HasColumnName("distinctDetail");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entityId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(5);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(256);

                entity.Property(e => e.IdUser)
                    .HasColumnName("idUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertionDate)
                    .HasColumnName("insertionDate")
                    .HasColumnType("date");

                entity.Property(e => e.PathAlternative).HasColumnName("pathAlternative");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.TeamId)
                    .HasColumnName("teamId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("entities");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnName("entityName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mimetype>(entity =>
            {
                entity.ToTable("mimetypes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(6);

                entity.Property(e => e.KinfOfDocument).HasColumnName("kinf_of_document");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasColumnName("mime_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EntityId)
                    .HasColumnName("entityId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HostName)
                    .HasColumnName("hostName")
                    .HasMaxLength(30);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(50);

                entity.Property(e => e.PathRoot)
                    .IsRequired()
                    .HasColumnName("pathRoot");

                entity.Property(e => e.PortNumber)
                    .HasColumnName("portNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasColumnName("teamName")
                    .HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnName("telephoneNumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("accessLevel")
                    .HasMaxLength(20);

                entity.Property(e => e.CompleteName)
                    .IsRequired()
                    .HasColumnName("completeName")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.EntityId)
                    .HasColumnName("entityId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expirationDate")
                    .HasColumnType("date");

                entity.Property(e => e.TeamId)
                    .HasColumnName("teamId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserAccount)
                    .IsRequired()
                    .HasColumnName("userAccount")
                    .HasMaxLength(20);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("userPassword")
                    .HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

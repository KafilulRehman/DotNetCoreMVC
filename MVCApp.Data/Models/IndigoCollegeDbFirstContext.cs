using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVCApp.Data.Models
{
    public partial class IndigoCollegeDbFirstContext : DbContext
    {
        public IndigoCollegeDbFirstContext()
        {
        }

        public IndigoCollegeDbFirstContext(DbContextOptions<IndigoCollegeDbFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProjectConstant> ProjectConstants { get; set; }
        public virtual DbSet<ProjectConstantCode> ProjectConstantCodes { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ProjectConstant>(entity =>
            {
                entity.ToTable("ProjectConstant");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectConstantName).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProjectConstantCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ProjectConstant_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProjectConstantModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ProjectConstant_User1");

                entity.HasOne(d => d.ProjectConstantCode)
                    .WithMany(p => p.ProjectConstants)
                    .HasForeignKey(d => d.ProjectConstantCodeId)
                    .HasConstraintName("FK_ProjectConstant_ProjectConstantCode");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.ProjectConstants)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_ProjectConstant_Subscriber");
            });

            modelBuilder.Entity<ProjectConstantCode>(entity =>
            {
                entity.ToTable("ProjectConstantCode");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectConstantCodeName).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProjectConstantCodeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ProjectConstantCode_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProjectConstantCodeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ProjectConstantCode_User1");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.ProjectConstantCodes)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_ProjectConstantCode_Subscriber");
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.ToTable("Subscriber");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFinalized).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriberAddress).HasMaxLength(155);

                entity.Property(e => e.SubscriberContactNo).HasMaxLength(50);

                entity.Property(e => e.SubscriberDisplayName).HasMaxLength(50);

                entity.Property(e => e.SubscriberEmail).HasMaxLength(50);

                entity.Property(e => e.SubscriberLocation).HasMaxLength(50);

                entity.Property(e => e.SubscriberName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFinalized).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifedDate).HasColumnType("datetime");

                entity.Property(e => e.UserAddress).HasMaxLength(50);

                entity.Property(e => e.UserContactNo).HasMaxLength(50);

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserFirstName).HasMaxLength(50);

                entity.Property(e => e.UserLastName).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_ProjectConstant");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_User_Subscriber");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

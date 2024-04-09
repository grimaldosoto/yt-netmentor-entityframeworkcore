using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cursoEFDatabaseFirst.API.Models;

public partial class CursoEfContext : DbContext
{
    public CursoEfContext()
    {
    }

    public CursoEfContext(DbContextOptions<CursoEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Wokringexperience> Wokringexperiences { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4C47E06259");

            entity.ToTable("User");

            entity.HasIndex(e => e.UserName, "UserName").IsUnique();

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wokringexperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__wokringe__3213E83F3AE1E5AC");

            entity.ToTable("wokringexperience");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Details)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Environment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.User).WithMany(p => p.Wokringexperiences)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__wokringex__UserI__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

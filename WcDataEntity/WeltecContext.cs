using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Wc.DataEntity;

public partial class WeltecContext : DbContext
{
    public WeltecContext()
    {
    }

    public WeltecContext(DbContextOptions<WeltecContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Rolemaster> Rolemasters { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AYUSHGANDHI;Database=weltec;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rolemaster>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("Rolemaster");

            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("UserInfo");

            entity.Property(e => e.Address1).HasMaxLength(50);
            entity.Property(e => e.Address2).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PasswordSalt).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Zipcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.UserInfos)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserInfo_Rolemaster");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

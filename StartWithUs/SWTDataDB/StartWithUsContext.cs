using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StartWithUs.SWTDataDB
{
    public partial class StartWithUsContext : DbContext
    {
        public StartWithUsContext()
        {
        }

        public StartWithUsContext(DbContextOptions<StartWithUsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Enterpreneur> Enterpreneur { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Investor> Investor { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Report> Report { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DAEMON\\SQLEXPRESS; Database=StartWithUs; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.About)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnterpreneurId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tagline)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Enterpreneur)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.EnterpreneurId)
                    .HasConstraintName("FK_Company_Enterpreneur");
            });

            modelBuilder.Entity<Enterpreneur>(entity =>
            {
                entity.Property(e => e.EnterpreneurId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Investor>(entity =>
            {
                entity.Property(e => e.InvestorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pannumber)
                    .IsRequired()
                    .HasColumnName("PANNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasMaxLength(15);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InvestorId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Investor)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.InvestorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Payment");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.ReportId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EnterpreneurId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.InvestorId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaymentId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Company");

                entity.HasOne(d => d.Enterpreneur)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.EnterpreneurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Enterpreneur");

                entity.HasOne(d => d.Investor)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.InvestorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Investor");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Payment");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

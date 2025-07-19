using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PJ_1.Models
{
    public partial class DB_ThuctapContext : DbContext
    {
        public DB_ThuctapContext()
        {
        }

        public DB_ThuctapContext(DbContextOptions<DB_ThuctapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDmDonViTinh> TblDmDonViTinhs { get; set; } = null!;
        public virtual DbSet<TblDmKho> TblDmKhos { get; set; } = null!;
        public virtual DbSet<TblDmKhoUser> TblDmKhoUsers { get; set; } = null!;
        public virtual DbSet<TblDmLoaiSanPham> TblDmLoaiSanPhams { get; set; } = null!;
        public virtual DbSet<TblDmNcc> TblDmNccs { get; set; } = null!;
        public virtual DbSet<TblDmSanPham> TblDmSanPhams { get; set; } = null!;
        public virtual DbSet<TblXnkNhapKho> TblXnkNhapKhos { get; set; } = null!;
        public virtual DbSet<TblXnkNhapKhoRawDatum> TblXnkNhapKhoRawData { get; set; } = null!;
        public virtual DbSet<TblXnkXuatKho> TblXnkXuatKhos { get; set; } = null!;
        public virtual DbSet<TblXnkXuatKhoRawDatum> TblXnkXuatKhoRawData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.76,1433;Initial Catalog=DB_Thuctap;User ID=sa;Password=123123;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDmDonViTinh>(entity =>
            {
                entity.HasKey(e => e.DonViTinhId);

                entity.ToTable("tbl_DM_Don_Vi_Tinh");

                entity.Property(e => e.DonViTinhId).HasColumnName("Don_Vi_Tinh_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Don_Vi_Tinh");
            });

            modelBuilder.Entity<TblDmKho>(entity =>
            {
                entity.HasKey(e => e.KhoId);

                entity.ToTable("tbl_DM_Kho");

                entity.Property(e => e.KhoId).HasColumnName("Kho_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.TenKho)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Kho");
            });

            modelBuilder.Entity<TblDmKhoUser>(entity =>
            {
                entity.HasKey(e => e.KhoUserId)
                    .HasName("PK_tbl_DM_Kho_User_1");

                entity.ToTable("tbl_DM_Kho_User");

                entity.Property(e => e.KhoUserId).HasColumnName("Kho_User_ID");

                entity.Property(e => e.KhoId).HasColumnName("Kho_ID");

                entity.Property(e => e.MaDangNhap)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Dang_Nhap");

                entity.HasOne(d => d.Kho)
                    .WithMany(p => p.TblDmKhoUsers)
                    .HasForeignKey(d => d.KhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DM_Kho_User_tbl_DM_Kho");
            });

            modelBuilder.Entity<TblDmLoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.LoaiSanPhamId);

                entity.ToTable("tbl_DM_Loai_San_Pham");

                entity.Property(e => e.LoaiSanPhamId).HasColumnName("Loai_San_Pham_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.MaLsp)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_LSP");

                entity.Property(e => e.TenLsp)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_LSP");
            });

            modelBuilder.Entity<TblDmNcc>(entity =>
            {
                entity.HasKey(e => e.NccId);

                entity.ToTable("tbl_DM_NCC");

                entity.Property(e => e.NccId).HasColumnName("NCC_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_NCC");

                entity.Property(e => e.TenNcc)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_NCC");
            });

            modelBuilder.Entity<TblDmSanPham>(entity =>
            {
                entity.HasKey(e => e.SanPhamId)
                    .HasName("PK_tbl_DM_San_Pham_1");

                entity.ToTable("tbl_DM_San_Pham");

                entity.Property(e => e.SanPhamId).HasColumnName("San_Pham_ID");

                entity.Property(e => e.DonViTinhId).HasColumnName("Don_Vi_Tinh_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LoaiSanPhamId).HasColumnName("Loai_San_Pham_ID");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_San_Pham");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_San_Pham");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.TblDmSanPhams)
                    .HasForeignKey(d => d.DonViTinhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DM_San_Pham_tbl_DM_Don_Vi_Tinh1");

                entity.HasOne(d => d.LoaiSanPham)
                    .WithMany(p => p.TblDmSanPhams)
                    .HasForeignKey(d => d.LoaiSanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DM_San_Pham_tbl_DM_Loai_San_Pham1");
            });

            modelBuilder.Entity<TblXnkNhapKho>(entity =>
            {
                entity.HasKey(e => e.PhieuNhapKhoId);

                entity.ToTable("tbl_XNK_Nhap_Kho");

                entity.Property(e => e.PhieuNhapKhoId).HasColumnName("Phieu_Nhap_Kho_ID");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.KhoId).HasColumnName("Kho_ID");

                entity.Property(e => e.NccId).HasColumnName("NCC_ID");

                entity.Property(e => e.NgayNhapKho)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Nhap_Kho");

                entity.Property(e => e.SoPhieuNhapKho)
                    .HasMaxLength(20)
                    .HasColumnName("So_Phieu_Nhap_Kho");

                entity.HasOne(d => d.Kho)
                    .WithMany(p => p.TblXnkNhapKhos)
                    .HasForeignKey(d => d.KhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Nhap_Kho_tbl_DM_Kho1");

                entity.HasOne(d => d.Ncc)
                    .WithMany(p => p.TblXnkNhapKhos)
                    .HasForeignKey(d => d.NccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Nhap_Kho_tbl_DM_NCC1");
            });

            modelBuilder.Entity<TblXnkNhapKhoRawDatum>(entity =>
            {
                entity.HasKey(e => e.NhapKhoId);

                entity.ToTable("tbl_XNK_Nhap_Kho_Raw_Data");

                entity.Property(e => e.NhapKhoId).HasColumnName("Nhap_Kho_ID");

                entity.Property(e => e.DonGiaNhap)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Don_Gia_Nhap");

                entity.Property(e => e.PhieuNhapKhoId).HasColumnName("Phieu_Nhap_Kho_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("San_Pham_ID");

                entity.Property(e => e.SlNhap).HasColumnName("SL_Nhap");

                entity.HasOne(d => d.PhieuNhapKho)
                    .WithMany(p => p.TblXnkNhapKhoRawData)
                    .HasForeignKey(d => d.PhieuNhapKhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Nhap_Kho_Raw_Data_tbl_XNK_Nhap_Kho");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.TblXnkNhapKhoRawData)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Nhap_Kho_Raw_Data_tbl_DM_San_Pham1");
            });

            modelBuilder.Entity<TblXnkXuatKho>(entity =>
            {
                entity.HasKey(e => e.PhieuXuatKhoId)
                    .HasName("PK_new_tbl_XNK_Xuat_Kho");

                entity.ToTable("tbl_XNK_Xuat_Kho");

                entity.Property(e => e.PhieuXuatKhoId).HasColumnName("Phieu_Xuat_Kho_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.KhoId).HasColumnName("Kho_ID");

                entity.Property(e => e.NgayXuatKho)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Xuat_Kho");

                entity.Property(e => e.SoPhieuXuatKho)
                    .HasMaxLength(20)
                    .HasColumnName("So_Phieu_Xuat_Kho");

                entity.HasOne(d => d.Kho)
                    .WithMany(p => p.TblXnkXuatKhos)
                    .HasForeignKey(d => d.KhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Xuat_Kho_tbl_DM_Kho1");
            });

            modelBuilder.Entity<TblXnkXuatKhoRawDatum>(entity =>
            {
                entity.HasKey(e => e.XuatKhoId)
                    .HasName("PK_new_tbl_XNK_Xuat_Kho_Raw_Data");

                entity.ToTable("tbl_XNK_Xuat_Kho_Raw_Data");

                entity.Property(e => e.XuatKhoId).HasColumnName("Xuat_Kho_ID");

                entity.Property(e => e.DonGiaXuat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Don_Gia_Xuat");

                entity.Property(e => e.PhieuXuatKhoId).HasColumnName("Phieu_Xuat_Kho_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("San_Pham_ID");

                entity.Property(e => e.SlXuat).HasColumnName("SL_Xuat");

                entity.HasOne(d => d.PhieuXuatKho)
                    .WithMany(p => p.TblXnkXuatKhoRawData)
                    .HasForeignKey(d => d.PhieuXuatKhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Xuat_Kho_Raw_Data_tbl_XNK_Xuat_Kho");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.TblXnkXuatKhoRawData)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_XNK_Xuat_Kho_Raw_Data_tbl_DM_San_Pham1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

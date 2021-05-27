using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API_DangKyMonHoc.Models
{
    public partial class DangKyMonHocContext : DbContext
    {
        public DangKyMonHocContext()
        {
        }

        public DangKyMonHocContext(DbContextOptions<DangKyMonHocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<KhoiKienThuc> KhoiKienThucs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=HUYNHTRUNG1006\\SQLExpress;Database=DangKyMonHoc;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.HasKey(e => e.MaGv)
                    .HasName("PK__GiangVie__7A3E2D7544169D00");

                entity.ToTable("GiangVien");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("maGV");

                entity.Property(e => e.Chucvu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("chucvu");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HocHam)
                    .HasMaxLength(25)
                    .HasColumnName("hocHam");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoa");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Phai).HasColumnName("phai");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sdt")
                    .IsFixedLength(true);

                entity.Property(e => e.TenGv)
                    .HasMaxLength(50)
                    .HasColumnName("tenGV");

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.GiangViens)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("fk_GiangVien_Khoa");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__Khoa__C79B8C2231F192D0");

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoa");

                entity.Property(e => e.TenKhoan)
                    .HasMaxLength(50)
                    .HasColumnName("tenKhoan");
            });

            modelBuilder.Entity<KhoiKienThuc>(entity =>
            {
                entity.HasKey(e => e.MaKhoi)
                    .HasName("PK__KhoiKien__C79B8C2A2E2F8DB1");

                entity.ToTable("KhoiKienThuc");

                entity.Property(e => e.MaKhoi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoi");

                entity.Property(e => e.BatBuoc).HasColumnName("batBuoc");

                entity.Property(e => e.TenChuyenMon)
                    .HasMaxLength(25)
                    .HasColumnName("tenChuyenMon");

                entity.Property(e => e.TenKhoi)
                    .HasMaxLength(25)
                    .HasColumnName("tenKhoi");
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.MaLop)
                    .HasName("PK__Lop__261ECAE36D48EF72");

                entity.ToTable("Lop");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLop");

                entity.Property(e => e.NienKhoa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nienKhoa");

                entity.Property(e => e.SiSo).HasColumnName("siSo");

                entity.Property(e => e.TenLop)
                    .HasMaxLength(20)
                    .HasColumnName("tenLop");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__MonHoc__7A3EDFA679B9431A");

                entity.ToTable("MonHoc");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maMH");

                entity.Property(e => e.HeSoHp).HasColumnName("heSoHP");

                entity.Property(e => e.MaKhoi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoi");

                entity.Property(e => e.Sotc).HasColumnName("sotc");

                entity.Property(e => e.TenMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenMH");

                entity.Property(e => e.ThucHanh).HasColumnName("thucHanh");

                entity.HasOne(d => d.MaKhoiNavigation)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.MaKhoi)
                    .HasConstraintName("fk_MonHoc_KhoiKienThuc");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__7A3EC7D5CAAA6043");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maNV");

                entity.Property(e => e.Chucvu)
                    .HasMaxLength(25)
                    .HasColumnName("chucvu");

                entity.Property(e => e.EmailNv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emailNV");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("matKhau");

                entity.Property(e => e.NgaysinhNv)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinhNV");

                entity.Property(e => e.SdtNv)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sdtNV");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("tenNV");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MsSv)
                    .HasName("PK__SinhVien__763428B5599D090A");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MsSv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("msSV");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cmnd")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Hedaotao)
                    .HasMaxLength(15)
                    .HasColumnName("hedaotao");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoa");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLop");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("matkhau");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Phai).HasColumnName("phai");

                entity.Property(e => e.TenSv)
                    .HasMaxLength(50)
                    .HasColumnName("tenSV");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("fk_SinhVien_Khoa");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.MaLop)
                    .HasConstraintName("fk_SinhVien_Lop");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

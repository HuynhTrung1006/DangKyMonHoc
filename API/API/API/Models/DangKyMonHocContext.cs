using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API.Models
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

        public virtual DbSet<BangDiem> BangDiems { get; set; }
        public virtual DbSet<ChiTietCtdt> ChiTietCtdts { get; set; }
        public virtual DbSet<ChiTietPdk> ChiTietPdks { get; set; }
        public virtual DbSet<ChiTietPhucKhao> ChiTietPhucKhaos { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<ChuongTrinhDaoTao> ChuongTrinhDaoTaos { get; set; }
        public virtual DbSet<CongDangKy> CongDangKies { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<HeDaoTao> HeDaoTaos { get; set; }
        public virtual DbSet<HocKyCtdt> HocKyCtdts { get; set; }
        public virtual DbSet<HocKyDkmh> HocKyDkmhs { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<KhoiKienThuc> KhoiKienThucs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<LopMonHoc> LopMonHocs { get; set; }
        public virtual DbSet<LopMonHocGiangVien> LopMonHocGiangViens { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<MonHocDuocMo> MonHocDuocMos { get; set; }
        public virtual DbSet<NamHocDkmh> NamHocDkmhs { get; set; }
        public virtual DbSet<Nganh> Nganhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NienKhoa> NienKhoas { get; set; }
        public virtual DbSet<NienKhoaCdk> NienKhoaCdks { get; set; }
        public virtual DbSet<PhieuDangKy> PhieuDangKies { get; set; }
        public virtual DbSet<PhucKhao> PhucKhaos { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<ThongTinMonHoc> ThongTinMonHocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
<<<<<<< HEAD
                optionsBuilder.UseSqlServer("Server=LAPTOP-9D8IC3BJ\\SQLEXPRESS;Database=DangKyMonHoc;\nTrusted_Connection=True;");
=======
                optionsBuilder.UseSqlServer("Server=DESKTOP-RNF172K;Database=DangKyMonHoc;Trusted_Connection=True;");
>>>>>>> NhanhHiuHiu
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BangDiem>(entity =>
            {
                entity.ToTable("BangDiem");

                entity.HasIndex(e => e.MaLmh, "UQ__BangDiem__26213EF0A2CDEF00")
                    .IsUnique();

                entity.HasIndex(e => e.MaPdk, "UQ__BangDiem__2719D8437D642D13")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiemCk).HasColumnName("diemCK");

                entity.Property(e => e.DiemGk).HasColumnName("diemGK");

                entity.Property(e => e.DiemQt).HasColumnName("diemQT");

                entity.Property(e => e.DiemTk1).HasColumnName("diemTK1");

                entity.Property(e => e.DiemTk2).HasColumnName("diemTK2");

                entity.Property(e => e.DiemTk3).HasColumnName("diemTK3");

                entity.Property(e => e.Ketqua).HasColumnName("ketqua");

                entity.Property(e => e.MaLmh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLMH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaPdk)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maPDK")
                    .IsFixedLength(true);

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaLmhNavigation)
                    .WithOne(p => p.BangDiem)
                    .HasForeignKey<BangDiem>(d => d.MaLmh)
                    .HasConstraintName("fk_BD_LMH");

                entity.HasOne(d => d.MaPdkNavigation)
                    .WithOne(p => p.BangDiem)
                    .HasForeignKey<BangDiem>(d => d.MaPdk)
                    .HasConstraintName("fk_BD_PDK");
            });

            modelBuilder.Entity<ChiTietCtdt>(entity =>
            {
                entity.ToTable("ChiTietCTDT");

                entity.HasIndex(e => e.MaMh, "UQ__ChiTietC__7A3EDFA777E7996F")
                    .IsUnique();

                entity.HasIndex(e => e.MaCtdt, "UQ__ChiTietC__FD2652EB1AD1DAD4")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaCtdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maCTDT")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maHK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maMH")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaCtdtNavigation)
                    .WithOne(p => p.ChiTietCtdt)
                    .HasForeignKey<ChiTietCtdt>(d => d.MaCtdt)
                    .HasConstraintName("fk_CTCTDT_CTDT");

                entity.HasOne(d => d.MaHkNavigation)
                    .WithMany(p => p.ChiTietCtdts)
                    .HasForeignKey(d => d.MaHk)
                    .HasConstraintName("fk_CTCTDT_HocKy_CTDT");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithOne(p => p.ChiTietCtdt)
                    .HasForeignKey<ChiTietCtdt>(d => d.MaMh)
                    .HasConstraintName("fk_CTCTDT_MonHoc");
            });

            modelBuilder.Entity<ChiTietPdk>(entity =>
            {
                entity.ToTable("ChiTietPDK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maMH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaPdk)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maPDK")
                    .IsFixedLength(true);

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.ChiTietPdks)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("fk_CTPDK_MonHoc");

                entity.HasOne(d => d.MaPdkNavigation)
                    .WithMany(p => p.ChiTietPdks)
                    .HasForeignKey(d => d.MaPdk)
                    .HasConstraintName("fk_CTPDK_PDK");
            });

            modelBuilder.Entity<ChiTietPhucKhao>(entity =>
            {
                entity.HasKey(e => e.IdBd)
                    .HasName("PK__ChiTietP__8B6207EC3A6EAE0B");

                entity.ToTable("ChiTietPhucKhao");

                entity.Property(e => e.IdBd).HasColumnName("ID_BD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaPhucKhao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maPhucKhao")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.ChiTietPhucKhaos)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("fk_CTPK_CTBD");

                entity.HasOne(d => d.MaPhucKhaoNavigation)
                    .WithMany(p => p.ChiTietPhucKhaos)
                    .HasForeignKey(d => d.MaPhucKhao)
                    .HasConstraintName("fk_CTPK_PK");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__6E42BCD93A47AAF1");

                entity.ToTable("ChucVu");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maChucVu")
                    .IsFixedLength(true);

                entity.Property(e => e.TenChucVu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tenChucVu");
            });

            modelBuilder.Entity<ChuongTrinhDaoTao>(entity =>
            {
                entity.HasKey(e => e.MaCtdt)
                    .HasName("PK__ChuongTr__FD2652EA06CC024E");

                entity.ToTable("ChuongTrinhDaoTao");

                entity.Property(e => e.MaCtdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maCTDT")
                    .IsFixedLength(true);

                entity.Property(e => e.MaDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maDT")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNganh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maNganh")
                    .IsFixedLength(true);

                entity.Property(e => e.NienKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nienKhoa")
                    .IsFixedLength(true);

                entity.Property(e => e.TenCtdt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenCTDT");

                entity.Property(e => e.TongSoTinChi).HasColumnName("tongSoTinChi");

                entity.HasOne(d => d.MaDtNavigation)
                    .WithMany(p => p.ChuongTrinhDaoTaos)
                    .HasForeignKey(d => d.MaDt)
                    .HasConstraintName("fk_CTDT_HDT");

                entity.HasOne(d => d.MaNganhNavigation)
                    .WithMany(p => p.ChuongTrinhDaoTaos)
                    .HasForeignKey(d => d.MaNganh)
                    .HasConstraintName("fk_CTDT_Nganh");
            });

            modelBuilder.Entity<CongDangKy>(entity =>
            {
                entity.HasKey(e => e.MaCdk)
                    .HasName("PK__CongDang__2C863B01BF0ECDBE");

                entity.ToTable("CongDangKy");

                entity.Property(e => e.MaCdk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maCDK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHk)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maHK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maNH")
                    .IsFixedLength(true);

                entity.Property(e => e.TenCdk)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("tenCDK");

                entity.Property(e => e.ThoigianBatDau)
                    .HasColumnType("datetime")
                    .HasColumnName("thoigianBatDau");

                entity.Property(e => e.ThoigianKetThuc)
                    .HasColumnType("datetime")
                    .HasColumnName("thoigianKetThuc");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaHkNavigation)
                    .WithMany(p => p.CongDangKies)
                    .HasForeignKey(d => d.MaHk)
                    .HasConstraintName("fk_CDK_HK");

                entity.HasOne(d => d.MaNhNavigation)
                    .WithMany(p => p.CongDangKies)
                    .HasForeignKey(d => d.MaNh)
                    .HasConstraintName("fk_CDK_NH");
            });

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.HasKey(e => e.MaGv)
                    .HasName("PK__GiangVie__7A3E2D75A223C7A6");

                entity.ToTable("GiangVien");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maGV")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hinhanh")
                    .IsFixedLength(true);

                entity.Property(e => e.Hocham)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("hocham");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maChucVu")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoa")
                    .IsFixedLength(true);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("matkhau")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("sdt")
                    .IsFixedLength(true);

                entity.Property(e => e.TenGv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenGV");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.GiangViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("fk_GiangVien_ChucVu");

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.GiangViens)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("fk_GiangVien_Khoa");
            });

            modelBuilder.Entity<HeDaoTao>(entity =>
            {
                entity.HasKey(e => e.MaDt)
                    .HasName("PK__HeDaoTao__7A3EF41385781880");

                entity.ToTable("HeDaoTao");

                entity.Property(e => e.MaDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maDT")
                    .IsFixedLength(true);

                entity.Property(e => e.TenDt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenDT");
            });

            modelBuilder.Entity<HocKyCtdt>(entity =>
            {
                entity.HasKey(e => e.MaHk)
                    .HasName("PK__HocKy_CT__7A3E14899983F457");

                entity.ToTable("HocKy_CTDT");

                entity.Property(e => e.MaHk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maHK")
                    .IsFixedLength(true);

                entity.Property(e => e.TenHk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tenHK");
            });

            modelBuilder.Entity<HocKyDkmh>(entity =>
            {
                entity.HasKey(e => e.MaHk)
                    .HasName("PK__HocKy_DK__7A3E14890E31858F");

                entity.ToTable("HocKy_DKMH");

                entity.Property(e => e.MaHk)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maHK")
                    .IsFixedLength(true);

                entity.Property(e => e.TenHk)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("tenHK");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__Khoa__C79B8C221D375FC0");

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoa")
                    .IsFixedLength(true);

                entity.Property(e => e.TenKhoa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenKhoa");

                entity.Property(e => e.TenVietTat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tenVietTat")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<KhoiKienThuc>(entity =>
            {
                entity.HasKey(e => e.MaKhoi)
                    .HasName("PK__KhoiKien__C79B8C2A19ECD4CD");

                entity.ToTable("KhoiKienThuc");

                entity.Property(e => e.MaKhoi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoi")
                    .IsFixedLength(true);

                entity.Property(e => e.Batbuoc).HasColumnName("batbuoc");

                entity.Property(e => e.TenChuyenMon)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenChuyenMon");

                entity.Property(e => e.TenKhoi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenKhoi");
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.MaLop)
                    .HasName("PK__Lop__261ECAE35952BA92");

                entity.ToTable("Lop");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLop")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNganh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maNganh")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maNK")
                    .IsFixedLength(true);

                entity.Property(e => e.Siso).HasColumnName("siso");

                entity.Property(e => e.TenLop)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tenLop")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaNganhNavigation)
                    .WithMany(p => p.Lops)
                    .HasForeignKey(d => d.MaNganh)
                    .HasConstraintName("fk_Lop_Nganh");

                entity.HasOne(d => d.MaNkNavigation)
                    .WithMany(p => p.Lops)
                    .HasForeignKey(d => d.MaNk)
                    .HasConstraintName("fk_Lop_NienKhoa");
            });

            modelBuilder.Entity<LopMonHoc>(entity =>
            {
                entity.HasKey(e => e.MaLmh)
                    .HasName("PK__Lop_MonH__26213EF1C4CF9916");

                entity.ToTable("Lop_MonHoc");

                entity.Property(e => e.MaLmh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLMH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaCdk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maCDK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maMH")
                    .IsFixedLength(true);

                entity.Property(e => e.Sisi).HasColumnName("sisi");

                entity.Property(e => e.TenLmh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenLMH");

                entity.HasOne(d => d.MaCdkNavigation)
                    .WithMany(p => p.LopMonHocs)
                    .HasForeignKey(d => d.MaCdk)
                    .HasConstraintName("fk_LMH_CDK");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.LopMonHocs)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("fk_LMH_MH");
            });

            modelBuilder.Entity<LopMonHocGiangVien>(entity =>
            {
                entity.ToTable("LopMonHoc_GiangVien");

                entity.HasIndex(e => e.MaLmh, "UQ__LopMonHo__26213EF07AB7C6D4")
                    .IsUnique();

                entity.HasIndex(e => e.MaGv, "UQ__LopMonHo__7A3E2D7426EF00DE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maGV")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLmh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLMH")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaGvNavigation)
                    .WithOne(p => p.LopMonHocGiangVien)
                    .HasForeignKey<LopMonHocGiangVien>(d => d.MaGv)
                    .HasConstraintName("fk_LMHGV_GV");

                entity.HasOne(d => d.MaLmhNavigation)
                    .WithOne(p => p.LopMonHocGiangVien)
                    .HasForeignKey<LopMonHocGiangVien>(d => d.MaLmh)
                    .HasConstraintName("fk_LMHGV_LMH");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__MonHoc__7A3EDFA63CC09F48");

                entity.ToTable("MonHoc");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maMH")
                    .IsFixedLength(true);

                entity.Property(e => e.HesoHp).HasColumnName("hesoHP");

                entity.Property(e => e.MaKhoi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoi")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maSH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTtmh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maTTMH")
                    .IsFixedLength(true);

                entity.Property(e => e.MonTq)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("monTQ")
                    .IsFixedLength(true);

                entity.Property(e => e.Sotinchi).HasColumnName("sotinchi");

                entity.Property(e => e.TenMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenMH");

                entity.Property(e => e.Thuchanh).HasColumnName("thuchanh");

                entity.HasOne(d => d.MaKhoiNavigation)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.MaKhoi)
                    .HasConstraintName("fk_MonHoc_KhoiKienThuc");

                entity.HasOne(d => d.MaTtmhNavigation)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.MaTtmh)
                    .HasConstraintName("fk_MonHoc_TTMonHoc");
            });

            modelBuilder.Entity<MonHocDuocMo>(entity =>
            {
                entity.ToTable("MonHocDuocMo");

                entity.HasIndex(e => e.MaCdk, "UQ__MonHocDu__2C863B00218ECB45")
                    .IsUnique();

                entity.HasIndex(e => e.MaMh, "UQ__MonHocDu__7A3EDFA70A1B60A8")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaCdk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maCDK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maMH")
                    .IsFixedLength(true);

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaCdkNavigation)
                    .WithOne(p => p.MonHocDuocMo)
                    .HasForeignKey<MonHocDuocMo>(d => d.MaCdk)
                    .HasConstraintName("fk_MHDM_CDK");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithOne(p => p.MonHocDuocMo)
                    .HasForeignKey<MonHocDuocMo>(d => d.MaMh)
                    .HasConstraintName("fk_MHDM_MH");
            });

            modelBuilder.Entity<NamHocDkmh>(entity =>
            {
                entity.HasKey(e => e.MaNh)
                    .HasName("PK__NamHoc_D__7A3EC7C7C590C6B3");

                entity.ToTable("NamHoc_DKMH");

                entity.Property(e => e.MaNh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maNH")
                    .IsFixedLength(true);

                entity.Property(e => e.TenNh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("tenNH");
            });

            modelBuilder.Entity<Nganh>(entity =>
            {
                entity.HasKey(e => e.MaNganh)
                    .HasName("PK__Nganh__4E0C0217E9FE5610");

                entity.ToTable("Nganh");

                entity.Property(e => e.MaNganh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maNganh")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maKhoa")
                    .IsFixedLength(true);

                entity.Property(e => e.TenNganh)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("tenNganh");

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.Nganhs)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("fk_Nganh_Khoa");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__7A3EC7D59ADD3447");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maNV")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hinhanh")
                    .IsFixedLength(true);

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maChucVu")
                    .IsFixedLength(true);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("matkhau")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("sdt")
                    .IsFixedLength(true);

                entity.Property(e => e.TenNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenNV");

                entity.Property(e => e.Trangthai).HasColumnName("trangthai");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("fk_NhanVien_ChucVu");
            });

            modelBuilder.Entity<NienKhoa>(entity =>
            {
                entity.HasKey(e => e.MaNk)
                    .HasName("PK__NienKhoa__7A3EC7C25B4D3052");

                entity.ToTable("NienKhoa");

                entity.Property(e => e.MaNk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maNK")
                    .IsFixedLength(true);

                entity.Property(e => e.TenNk)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("tenNK");
            });

            modelBuilder.Entity<NienKhoaCdk>(entity =>
            {
                entity.ToTable("NienKhoa_CDK");

                entity.HasIndex(e => e.MaCdk, "UQ__NienKhoa__2C863B00FCE49876")
                    .IsUnique();

                entity.HasIndex(e => e.MaNk, "UQ__NienKhoa__7A3EC7C3AE2961AA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaCdk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maCDK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maNK")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaCdkNavigation)
                    .WithOne(p => p.NienKhoaCdk)
                    .HasForeignKey<NienKhoaCdk>(d => d.MaCdk)
                    .HasConstraintName("fk_NKCDK_CDK");

                entity.HasOne(d => d.MaNkNavigation)
                    .WithOne(p => p.NienKhoaCdk)
                    .HasForeignKey<NienKhoaCdk>(d => d.MaNk)
                    .HasConstraintName("fk_NKCDK_NK");
            });

            modelBuilder.Entity<PhieuDangKy>(entity =>
            {
                entity.HasKey(e => e.MaPdk)
                    .HasName("PK__PhieuDan__2719D8425008355C");

                entity.ToTable("PhieuDangKy");

                entity.Property(e => e.MaPdk)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maPDK")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maSV")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaychinhsua)
                    .HasColumnType("date")
                    .HasColumnName("ngaychinhsua");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("ngaylap");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.PhieuDangKies)
                    .HasForeignKey(d => d.MaSv)
                    .HasConstraintName("fk_PDK_SV");
            });

            modelBuilder.Entity<PhucKhao>(entity =>
            {
                entity.HasKey(e => e.MaPhucKhao)
                    .HasName("PK__PhucKhao__3487CF8A8D878049");

                entity.ToTable("PhucKhao");

                entity.Property(e => e.MaPhucKhao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maPhucKhao")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maSV")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaykhoitao)
                    .HasColumnType("date")
                    .HasColumnName("ngaykhoitao");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.PhucKhaos)
                    .HasForeignKey(d => d.MaSv)
                    .HasConstraintName("fk_PhucKhao_SinhVien");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SinhVien__7A227A64737080E1");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maSV")
                    .IsFixedLength(true);

                entity.Property(e => e.Cnmd)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cnmd")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hinhanh")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maLop")
                    .IsFixedLength(true);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("matkhau")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Phai).HasColumnName("phai");

                entity.Property(e => e.TenSv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenSV");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.MaLop)
                    .HasConstraintName("fk_SinhVien_Lop");
            });

            modelBuilder.Entity<ThongTinMonHoc>(entity =>
            {
                entity.HasKey(e => e.MaTtmh)
                    .HasName("PK__ThongTin__27FBEBE7F978DA3C");

                entity.ToTable("ThongTinMonHoc");

                entity.Property(e => e.MaTtmh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("maTTMH")
                    .IsFixedLength(true);

                entity.Property(e => e.PhantramCk).HasColumnName("phantramCK");

                entity.Property(e => e.PhantramGk).HasColumnName("phantramGK");

                entity.Property(e => e.PhantramQt).HasColumnName("phantramQT");

                entity.Property(e => e.Sotiet).HasColumnName("sotiet");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

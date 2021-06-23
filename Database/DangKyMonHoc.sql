---------------------Database--------------------------------
-----------Dang Ky Mon Hoc, Chuong Trinh Dao Tao-------------

create table ChucVu(
	maChucVu char(10) primary key,
	tenChucVu nvarchar(20) not null
);
Create table NhanVien(
	maNV char(10) primary key,
	tenNV nvarchar(50) not null,
	email char(30) not null,
	diachi nvarchar(100) not null,
	sdt char(11) not null,
	ngaysinh date not null,
	matkhau char(100) not null,
	trangthai bit not null,
	hinhanh char(100),
	maChucVu char(10),

	CONSTRAINT fk_NhanVien_ChucVu	
	FOREIGN KEY (maChucVu)
	REFERENCES ChucVu (maChucVu)
);
Create Table Khoa(
	maKhoa char(10) primary key,
	tenKhoa nvarchar(50) not null,
	tenVietTat char(10) not null
);
Create table GiangVien(
	maGV char(10) primary key,
	tenGV nvarchar(50) not null,
	email char(30) not null,
	diachi nvarchar(100) not null,
	sdt char(11) not null,
	hocham nvarchar(30) not null,
	ngaysinh date not null,
	matkhau char(100) not null,
	trangthai bit not null,
	hinhanh char(100),
	maChucVu char(10),

	CONSTRAINT fk_GiangVien_ChucVu	
	FOREIGN KEY (maChucVu)
	REFERENCES ChucVu (maChucVu),

	maKhoa char(10),
	CONSTRAINT fk_GiangVien_Khoa
	FOREIGN KEY (maKhoa)
	REFERENCES Khoa(maKhoa)
);
Create table Nganh(
	maNganh char(5) primary key,
	tenNganh nvarchar(30) not null,
	maKhoa char(10),
	CONSTRAINT fk_Nganh_Khoa
	FOREIGN KEY (maKhoa)
	REFERENCES Khoa(maKhoa)
);
Create table HeDaoTao(
	maDT char(10) primary key,
	tenDT nvarchar(50) not null 
);
Create table ChuongTrinhDaoTao(
	maCTDT char(10) primary key,
	tenCTDT nvarchar(100) not null,
	nienKhoa char(10),
	tongSoTinChi int not null,
	maDT char(10),
	CONSTRAINT fk_CTDT_HDT
	FOREIGN KEY (maDT)
	REFERENCES HeDaoTao(maDT),
	maNganh char(5),
	CONSTRAINT fk_CTDT_Nganh	
	FOREIGN KEY (maNganh)
	REFERENCES Nganh(maNganh)
);
Create table HocKy_CTDT(
	maHK char(10) primary key,
	tenHK nvarchar(20) not null
);
Create table KhoiKienThuc(
	maKhoi char(10) primary key,
	tenKhoi nvarchar(100) not null,
	tenChuyenMon nvarchar(100) not null,
	batbuoc bit
);
Create table MonHoc(
	maMH char(10) primary key,
	tenMH nvarchar(50) not null,
	sotinchi tinyint not null,
	hesoHP tinyint not null,
	thuchanh bit not null,
	monTQ char(10),
	maSH char(10),
	maKhoi char(10),
	CONSTRAINT fk_MonHoc_KhoiKienThuc
	FOREIGN KEY (maKhoi)
	REFERENCES KhoiKienThuc(maKhoi)
);
Create table ChiTietCTDT(
	ID int primary key identity(1,1),
	maMH char(10) unique,
	maCTDT char(10) unique,
	maHK char(10),

	CONSTRAINT fk_CTCTDT_MonHoc
	FOREIGN KEY (maMH)
	REFERENCES MonHoc(maMH),

	CONSTRAINT fk_CTCTDT_CTDT
	FOREIGN KEY (maCTDT)
	REFERENCES ChuongTrinhDaoTao(maCTDT),

	CONSTRAINT fk_CTCTDT_HocKy_CTDT	
	FOREIGN KEY (maHK)
	REFERENCES HocKy_CTDT(maHK)
);
Create table NienKhoa(
	maNK char(10) primary key,
	tenNK nvarchar(10) not null
);
Create table Lop(
	maLop char(10) primary key,
	tenLop char(20) not null,
	siso tinyint not null,
	maNganh char(5),
	CONSTRAINT fk_Lop_Nganh
	FOREIGN KEY (maNganh)
	REFERENCES Nganh(maNganh),

	maNK char(10),
	CONSTRAINT fk_Lop_NienKhoa
	FOREIGN KEY (maNK)
	REFERENCES NienKhoa(maNK)
);
Create table SinhVien(
	maSV char(10) primary key,
	tenSV nvarchar(50) not null,
	diachi varchar(100) not null,
	ngaysinh date not null,
	phai bit not null,
	email char(50),
	cnmd char(13) not null,
	hinhanh char(100), 
	matkhau char(100) not null,
	maLop char(10),
	CONSTRAINT fk_SinhVien_Lop
	FOREIGN KEY (maLop)
	REFERENCES Lop(maLop)
);
Create table PhieuDangKy(
	maPDK char(5) primary key,
	ngaylap date not null,
	ngaychinhsua date ,
	maSV char(10),
	CONSTRAINT fk_PDK_SV
	FOREIGN KEY (maSV)
	REFERENCES SinhVien(maSV)
);
Create table ChiTietPDK(
	ID int primary key identity(1,1),
	maMH char(10),
	CONSTRAINT fk_CTPDK_MonHoc
	FOREIGN KEY (maMH)
	REFERENCES MonHoc(maMH),

	maPDK char(5),
	CONSTRAINT fk_CTPDK_PDK
	FOREIGN KEY (maPDK)
	REFERENCES PhieuDangKy(maPDK),

	trangthai bit not null
);
create table HocKy_DKMH(
	maHK char(5) primary key,
	tenHK nvarchar(10) not null,
);
create table NamHoc_DKMH(
	maNH char(5) primary key,
	tenNH nvarchar(10) not null,
);
Create table CongDangKy(
	maCDK char(10) primary key,
	tenCDK nvarchar(30) not null,
	thoigianBatDau dateTime ,
	thoigianKetThuc datetime,
	trangthai bit not null,
	maHK char(5),
	CONSTRAINT fk_CDK_HK
	FOREIGN KEY (maHK)
	REFERENCES HocKy_DKMH(maHK),

	maNH char(5),
	CONSTRAINT fk_CDK_NH
	FOREIGN KEY (maNH)
	REFERENCES NamHoc_DKMH(maNH)
);
Create table MonHocDuocMo(
	ID int primary key identity(1,1),
	soluong int not null,
	trangthai bit not null,
	maCDK char(10) unique,
	CONSTRAINT fk_MHDM_CDK
	FOREIGN KEY (maCDK)
	REFERENCES CongDangKy(maCDK),

	maMH char(10) unique,
	CONSTRAINT fk_MHDM_MH
	FOREIGN KEY (maMH)
	REFERENCES MonHoc(maMH)
);
Create table NienKhoa_CDK(
	ID int primary key identity(1,1),
	maNK char(10) unique,
	CONSTRAINT fk_NKCDK_NK	
	FOREIGN KEY (maNK)
	REFERENCES NienKhoa(maNK),

	maCDK char(10) unique,
	CONSTRAINT fk_NKCDK_CDK
	FOREIGN KEY (maCDK)
	REFERENCES CongDangKy(maCDK)
);
create table Lop_MonHoc(
	maLMH char(10) primary key ,
	tenLMH nvarchar(100) not null,
	sisi int not null,
	maCDK char(10),
	CONSTRAINT fk_LMH_CDK
	FOREIGN KEY (maCDK)
	REFERENCES CongDangKy(maCDK),
	maMH char(10),
	CONSTRAINT fk_LMH_MH	
	FOREIGN KEY (maMH)
	REFERENCES MonHoc(maMH)
);
create table LopMonHoc_GiangVien(
	ID int primary key identity(1,1),
	maLMH char(10) unique,
	CONSTRAINT fk_LMHGV_LMH
	FOREIGN KEY (maLMH)
	REFERENCES Lop_MonHoc(maLMH),
	
	maGV char(10) unique,
	CONSTRAINT fk_LMHGV_GV
	FOREIGN KEY (maGV)
	REFERENCES GiangVien(maGV)
);
Create table BangDiem(
	ID int primary key identity(1,1),
	maLMH char(10)unique,
	CONSTRAINT fk_BD_LMH
	FOREIGN KEY (maLMH)
	REFERENCES Lop_MonHoc(maLMH),

	maPDK char(5) unique,
	CONSTRAINT fk_BD_PDK
	FOREIGN KEY (maPDK)
	REFERENCES PhieuDangKy(maPDK),
	
	trangthai bit not null

);

-------------------Quan Ly Diem----------------------
Create table ThongTinMonHoc(
	maTTMH char(5) primary key,
	phantramGK int, 
	phantramCK int,
	phantramQT int,
	sotiet int
);

alter table MonHoc
	add maTTMH char(5),
	CONSTRAINT fk_MonHoc_TTMonHoc
	FOREIGN KEY (maTTMH)
	REFERENCES PhieuDangKy(maTTMH)
;

alter table BangDiem
	add diemGK float
;
alter table BangDiem
	add diemCK float
;
alter table BangDiem
	add diemQT float
;
alter table BangDiem
	add diemTK1 float
;
alter table BangDiem
	add diemTK2 float
;
alter table BangDiem
	add diemTK3 float
;
alter table BangDiem
	add ketqua bit
;

Create table PhucKhao(
	maPhucKhao char(10) primary key,
	ngaykhoitao date not null,
	maSV char(10),
	CONSTRAINT fk_PhucKhao_SinhVien
	FOREIGN KEY (maSV)
	REFERENCES SinhVien(maSV)
);

create table ChiTietPhucKhao(
	ID_BD int primary key identity(1,1),
	ID int,
	CONSTRAINT fk_CTPK_CTBD
	FOREIGN KEY (ID)
	REFERENCES BangDiem(ID),
	
	maPhucKhao char(10),
	CONSTRAINT fk_CTPK_PK
	FOREIGN KEY (maPhucKhao)
	REFERENCES PhucKhao(maPhucKhao)
);

alter table MonHoc
	add	CONSTRAINT fk_MonHoc_TTMonHoc
	FOREIGN KEY (maTTMH)
	REFERENCES ThongTinMonHoc(maTTMH)
;

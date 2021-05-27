create table KhoiKienThuc(
	maKhoi varchar(10) primary key,
	tenKhoi nvarchar(25),
	tenChuyenMon nvarchar(25),
	batBuoc bit
);

create table MonHoc(
	maMH varchar(10) primary key,
	tenMH nvarchar(50) not null,
	sotc tinyint not null,
	heSoHP tinyint not null,
	thucHanh bit not null,

	maKhoi varchar(10),
	CONSTRAINT fk_MonHoc_KhoiKienThuc
	FOREIGN KEY (maKhoi)
	REFERENCES KhoiKienThuc (maKhoi)
);

create Table NhanVien(
	maNV varchar(10) primary key,
	tenNV nvarchar(50),
	emailNV varchar(30),
	sdtNV varchar(12),
	ngaysinhNV date,
	chucvu nvarchar(25),
	matKhau varchar(20),
	trangthai bit
);

create table Lop(
	maLop varchar(10) primary key,
	tenLop varchar(20), 
	siSo tinyint,
	nienKhoa varchar(20)
);

create table Khoa(
	maKhoa varchar(10) primary key,
	tenKhoan nvarchar(50)
);

create table GiangVien(
	maGV varchar(25) primary key, 
	tenGV nvarchar(50),
	diachi nvarchar(50),
	ngaysinh date,
	hocHam nvarchar(25),
	phai bit,
	sdt char(12),
	email varchar(25),
	chucvu varchar(25),

	maKhoa varchar(10),
	CONSTRAINT fk_GiangVien_Khoa
	FOREIGN KEY (maKhoa)
	REFERENCES Khoa (maKhoa)
);

create table SinhVien(
	msSV varchar(10) primary key,
	tenSV nvarchar(50),
	diachi nvarchar(50),
	ngaysinh date,
	phai bit, 
	email varchar(30),
	cmnd char(15),
	hedaotao nvarchar(15),
	matkhau varchar(20),
	trangthai bit,


	maKhoa varchar(10),
	CONSTRAINT fk_SinhVien_Khoa
	FOREIGN KEY (maKhoa)
	REFERENCES Khoa (maKhoa),

	maLop varchar(10),
	CONSTRAINT fk_SinhVien_Lop
	FOREIGN KEY (maLop)
	REFERENCES Lop (maLop)
);
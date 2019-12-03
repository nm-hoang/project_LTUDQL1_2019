Create database QLThiTracNghiem
use QLThiTracNghiem
Go 
Create table KhoiLop
(
		MaKhoi int not null primary key,
		TenKhoi nvarchar(255) not null
)
Create table GiaoVien
(
	MaGV varchar(255) primary key,
	HoTen nvarchar(255),
	NgaySinh nchar(10) null,
	DienThoai nvarchar(255) null,
)
Create table LopHoc
(
	MaLop nvarchar(255) primary key,
	TenLop nvarchar(255),
)
Create table Admin
(
	ID varchar(255) primary key,
	HoTen nvarchar(255) 
)
Create table TaiKhoan
(
	ID int identity(1,1),
	ID_Account nvarchar(255),
	PassWord nvarchar(255),
	Type nvarchar(255),
	ID_User varchar(255),
	Constraint PK_TaiKhoan primary key(ID,ID_Account),
)
Create table MonHoc
(
	MaMH varchar(255) primary key,
	TenMH nvarchar(255),
	MaKhoi int 
)
Create table HocSinh
(
	MaHS varchar(255) primary key,
	HoTen nvarchar(255),
	NgaySinh nchar(10) null,
	MaLop nvarchar(255) null,
	MaKhoi int null,
	DienThoai nvarchar(255) null
)
Create table DeThi
(
		ID int primary key,
		TenDeThi nvarchar(255),
		MaMH varchar(255),
		MaKhoi int
)
Create table DSHocSinh
(
	MaKiThi varchar(255),
	MaHS varchar(255),
	ID_Account nvarchar(255) null
	Constraint PK_DSHocSinh primary key(MaKiThi,MaHS)
)
Create table CauHoiDongGop
(
	ID int identity(1,1) primary key,
	IDHS varchar(255),
	CauHoi nvarchar(255),
	DapAn_A nvarchar(255),
	DapAn_B nvarchar(255),
	DapAn_C nvarchar(255),
	DapAn_D nvarchar(255),
	KetQua nvarchar(255),
	Khoi int,--CapHoc
	Duyet bit ,
	DoKho nvarchar(255),
	MaMH varchar(255),
)
Create table CauHoi
(
		ID int identity(1,1) primary key,
		CauHoi nvarchar(255),
		DapAn_A nvarchar(255),
		DapAn_B nvarchar(255),
		DapAn_C nvarchar(255),
		DapAn_D nvarchar(255),
		DapAnDung nchar(1),
		Khoi int ,--CapHoc
		DoKho nvarchar(255),
		MaMH varchar(255),
)
Create table KyThiThu
(
	ID varchar(255) primary key,
	NgayThi nchar(10),
	MaDe int,
	SuDung bit ,
)
Create table KyThi
(
	ID varchar(255) primary key,
	NgayThi nchar(10),
	MaDe int,
	SuDung bit default(0)
)
Create table KetQuaThiThu
(
	ID int identity(1,1) primary key,
	MaHS varchar(255),
	SoCauDung nvarchar(255),
	SoCauSai nvarchar(255),
	DiemThi varchar(255),
	NgayThi nchar(10),
	ID_Account nvarchar(255),
	KyThi varchar(255),
)
Create table KetQuaThi
(
	ID int identity(1,1) primary key,
	MaHS varchar(255),
	SoCauDung nvarchar(255),
	SoCauSai nvarchar(255),
	DiemThi nvarchar(255),
	NgayThi nchar(10),
	ID_Account nvarchar(255),
	KyThi varchar(255),
)
Create table DanhSachCauHoi
(
	MaDe int,
	ID_Cauhoi int,
	Constraint PK_DSCH primary key(MaDe,ID_CauHoi)
)
--KHOA NGOAI
--MonHoc(MaKhoi)-KhoiLop(MaKhoi)
Alter table MonHoc add constraint FK_MH_K foreign key(MaKhoi) references KhoiLop(MaKhoi)
--HocSinh(MaKhoi)-KhoiLop(MaKhoi)
Alter table HocSinh add constraint FK_HS_K foreign key(MaKhoi) references KhoiLop(MaKhoi)
--DeThi(MaKhoi)-KhoiLop(MaKhoi)
Alter table DeThi add constraint FK_DT_K foreign key(MaKhoi) references KhoiLop(MaKhoi)
--CauHoiDongGop(Khoi)-KhoiLop(MaKhoi)
Alter table CauHoiDongGop add constraint FK_CHDG_K foreign key(Khoi) references KhoiLop(MaKhoi)
--CauHoi(Khoi)-KhoiLop(MaKhoi)
Alter table CauHoi add constraint FK_CH_K foreign key(Khoi) references KhoiLop(MaKhoi)


--HocSinh(MaLop)-LopHoc(MaLop)
Alter table HocSinh add constraint FK_HS_LH foreign key(MaLop) references LopHoc(MaLop)
--DeThi(MaMH)-MonHoc(MaMH)
Alter table DeThi add constraint FK_DT_MH foreign key(MaMH) references MonHoc(MaMH)
--CauHoiDongGop(MaMH)-MonHoc(MaMH)
Alter table CauHoiDongGop add constraint FK_CHDG_MH foreign key(MaMH) references MonHoc(MaMH)
--CauHoi(MaMH)-MonHoc(MaMH)
Alter table CauHoi add constraint FK_CH_MH foreign key(MaMH) references MonHoc(MaMH)

--DSHocSinh(MaHS)-HocSinh(MaHS)
Alter table DSHocSinh add constraint FK_DSHS_HS foreign key(MaHS) references HocSinh(MaHS)
--CauHoiDongGop(IDHS)-HocSinh(MaHS)
Alter table CauHoiDongGop add constraint FK_CHDG_HS foreign key(IDHS) references HocSinh(MaHS)
--KyThiThu(MaDe)-DeThi(ID)
Alter table KyThiThu add constraint FK_KTT_DT foreign key(MaDe) references DeThi(ID)
--KyThi(MaDe)-DeThi(ID)
Alter table KyThi add constraint FK_KT_DT foreign key(MaDe) references DeThi(ID)
--KetQuaThiThu(KiThi,MaHS)-DanhSachHS(MaKiThi,MaHS)
Alter table KetQuaThiThu add constraint FK_KQTT_DSHS foreign key(KyThi,MaHS) references DSHocSinh(MaKiThi,MaHS)
--KetQuaThi(KiThi,MaHS)-DanhSachHS(MaKiThy,MaHS)
Alter table KetQuaThi add constraint FK_KQT_DSHS foreign key(KyThi,MaHS) references DSHocSinh(MaKiThi,MaHS)
--DanhSachCauHoi(ID)-CauHoi(ID)
Alter table DanhSachCauHoi add constraint FK_DSCH_CH foreign key(ID_Cauhoi) references CauHoi(ID)

--Nocheck all khoa ngoai
DECLARE @sql NVARCHAR(MAX) = N'';

;WITH x AS 
(
  SELECT DISTINCT obj = 
      QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + '.' 
    + QUOTENAME(OBJECT_NAME(parent_object_id)) 
  FROM sys.foreign_keys
)
SELECT @sql += N'ALTER TABLE ' + obj + ' NOCHECK CONSTRAINT ALL;
' FROM x;

EXEC sp_executesql @sql;
--CheckAll KhoaNgoai
DECLARE @sql NVARCHAR(MAX) = N'';

;WITH x AS 
(
  SELECT DISTINCT obj = 
      QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + '.' 
    + QUOTENAME(OBJECT_NAME(parent_object_id)) 
  FROM sys.foreign_keys
)
SELECT @sql += N'ALTER TABLE ' + obj + ' WITH CHECK CHECK CONSTRAINT ALL;
' FROM x;

EXEC sp_executesql @sql;
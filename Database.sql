﻿create database QuanLiThuVien2
use QuanLiThuVien2
set dateformat dmy

CREATE TABLE SACH
(
	MASACH CHAR(10) PRIMARY KEY,
	TENSACH NVARCHAR(30),
	TENTACGIA NVARCHAR(30),
	CALLNUMBER NVARCHAR(20),
	LOAISACH NVARCHAR(20),
	GIATRI MONEY,
	ISBN NVARCHAR(20),
	NHAXUATBAN NVARCHAR(20),
	HIENTRANG NVARCHAR(20),
)
CREATE TABLE DOCGIA
(
	MADOCGIA CHAR(10) PRIMARY KEY,
	HOTEN NVARCHAR(20),
	DIACHI NVARCHAR(30),
	EMAIL NVARCHAR(30),
	CONGVIEC NVARCHAR(20),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(10),
	SODIENTHOAI NVARCHAR(20),
	LOAIDOCGIA NVARCHAR(10), -- thêm cái này vào tài liệu độc tả
)
CREATE TABLE QUYDINH
(
	TIENPHATTRASACH MONEY,
	TUOIMAX INT,
	TUOIMIN INT,
	SONGAYDUOCMUON INT,
	SOSACHDUOCMUON INT,
	KCNAMXUATBAN INT,
	SACHTOIDADUOCMUON INT,
	SONGAYMUONTOIDA INT,
)
CREATE TABLE PHIEUMUON
(
	MAPM CHAR(10) PRIMARY KEY,
	MADOCGIA CHAR(10),
	NGAYMUON DATETIME,
	--sửa tài liệu bỏ NGAYTRA
)
CREATE TABLE CT_PHIEUMUON
(
	MAPM CHAR(10),
	MASACH CHAR(10),
	constraint pk_CTPHIEUMUON primary key(MAPM,MASACH),
)
CREATE TABLE PHIEUTRA
(
	MAPT CHAR(10) PRIMARY KEY,
	MADOCGIA CHAR(10),
	NGAYTRA DATETIME,
	TIENPHATSACH MONEY,
)
CREATE TABLE CT_PHIEUTRA
(
	MAPT CHAR(10),
	MASACH CHAR(10),
	constraint pk_CTPHIEUTRA primary key(MAPT,MASACH),
)
CREATE TABLE THONGKE
(
	MATHONGKE CHAR(10) PRIMARY KEY,
	MASACH CHAR(10),
)
CREATE TABLE NHANVIEN
(
	MANV CHAR(10) PRIMARY KEY,
	TENNV NVARCHAR(20),
	NGAYSINH DATETIME,
	EMAIL NVARCHAR(30),
	GIOITINH NVARCHAR(10),
	SODT NVARCHAR(20),
	TAIKHOAN NVARCHAR(20),
)
CREATE TABLE PHIEUTHANHTOAN
(
	MAPHIEUTHANHTOAN CHAR(10) PRIMARY KEY,
	MADOCGIA CHAR(10),
	MANGUOILAP CHAR(10),
	SOTIENTHANHTOAN MONEY,
	NGAYLAPTHANHTOAN DATETIME,
)
CREATE TABLE PHIEUYEUCAU
(
	MAPHIEUYEUCAU CHAR(10) PRIMARY KEY,
	MADOCGIA CHAR(10),
	MANGUOILAP CHAR(10),
	CHITIETYEUCAU NVARCHAR(40),
	NGAYLAPPHIEUYEUCAU DATETIME,
)
CREATE TABLE PHIEUBIENBANSUCO
(
	MASUCO CHAR(10) PRIMARY KEY,
	MADOCGIA CHAR(10),
	MASACH CHAR(10),
	NGAYLAPBIENBAN DATETIME,
	CHITIETSUCO NVARCHAR(30),
	SOTIENBOITHUONG MONEY,
)
insert into SACH values ('1234','MYLIFE',N'KHÁNH VIỆT','0926828605',N'TRINH THÁM','90000','123125123',N'TUỔI TRẺ',N'CÒN HÀNG')
INSERT INTO DOCGIA VALUES('4321',N'Nguyễn Văn A',N'kí túc xá khu b',N'vietdaica2001@gmail.com','HOCSINH','04/08/2002','Nam','09283021235',N'Sinh viên')
insert into PHIEUMUON values('583212','1234','04/02/2021')
insert into PHIEUTRA values('213212','5321','08/03/2021','5000')
insert into NHANVIEN values('2513',N'Nguyễn Văn B','04/01/2001','vietcool@gmail.com',N'Nữ','20351235212','nhanvien01')
insert into PHIEUTHANHTOAN values('52313','2143','2125','900000','05/06/2020')
insert into PHIEUYEUCAU values('75892','1523','6721',N'Trả lại sách và mượn sách MyDog','01/06/2020')
insert into	PHIEUBIENBANSUCO values('16231','6342','6213','05/06/2020',N'rách bìa sách','50000')
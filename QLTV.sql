CREATE DATABASE QuanLyThuVien
USE QuanLyThuVien

-----------------------------------------Thi?t k? c? s? d? li?u--------------------------------------------------------

--	1. B?ng DocGia
CREATE TABLE DocGia(
	SoThe NCHAR(10) PRIMARY KEY,
	HoTen NVARCHAR(50),
	NgaySinh DATE,
	GioiTinh NCHAR(10),
	DiaChi NVARCHAR(50),
	SDT NCHAR(10))

--	2. B?ng ViPham
 CREATE TABLE ViPham (
     MaVP NCHAR(10) PRIMARY KEY,
     TenVP NVARCHAR(50) ,
     TienVP MONEY,
     GhiChu NVARCHAR(50))

-- 3. B?ng NhanVien
CREATE TABLE NhanVien(
	MaNhanVien NCHAR(10) PRIMARY KEY,
	TenNhanVien NVARCHAR(50),
	NgaySinhNV DATE,
	GioiTinhNV NCHAR(10),
	DiaChiNV NVARCHAR(50),
	SDTNV NCHAR(10))

--	4. B?ng DauSach
CREATE TABLE DauSach(
	MaDauSach NCHAR(10) PRIMARY KEY,
	TenDauSach NVARCHAR(50),
	SoTrang INT,
	GiaBan MONEY,
	SoLuong INT,
	TheLoai NVARCHAR(50),
	NXB NVARCHAR(50),
	TacGia NVARCHAR(50))

--	5. B?ng CuonSach
CREATE TABLE CuonSach(
	MaCuonSach NCHAR(10) PRIMARY KEY,
	TinhTrangCuonSach NVARCHAR(50),
	MaDauSach NCHAR(10) references DauSach(MaDauSach) )

--	6. B?ng PhieuMuonTra
CREATE TABLE PhieuMuonTra(
	MaPhieuMuonTra NCHAR(10)PRIMARY KEY,
	NgayMuon DATE,
	NgayHenTra DATE,
	NgayTra DATE,
	SoThe NCHAR(10) references DocGia(SoThe),
	MaNhanVien NCHAR(10) references NhanVien(MaNhanVien))

--	7. B?ng ChiTietPhieuTra
CREATE TABLE ChiTietPhieuMuonTra(
	MaCuonSach NCHAR(10) REFERENCES CuonSach (MaCuonSach),
	MaPhieuMuonTra NCHAR(10) REFERENCES PhieuMuonTra (MaPhieuMuonTra),
	MaVP NCHAR(10) REFERENCES ViPham (MaVP),
	TinhTrangTra NVARCHAR(50),
	PRIMARY KEY (MaCuonSach, MaPhieuMuonTra))

-- 8. B?ng Login
CREATE TABLE [Login](
	MaNhanVien NCHAR(10) REFERENCES NhanVien(MaNhanVien),
	MatKhau NVARCHAR(50),
	PhanQuyen NVARCHAR(50),
	PRIMARY KEY (MaNhanVien))

--------------------------------------------------Nh?p d? li?u----------------------------------------------------------

-- B?ng DocGia
INSERT INTO DocGia (SoThe, HoTen, NgaySinh, GioiTinh, DiaChi, SDT)
VALUES
('DG1', N'?? H?ng Nh?', '1998-09-20', N'n?', N'H� N?i', '0332968986'),
('DG2', N'Nguy?n Th? Mai Dung', '1998-12-22', N'n?', N'V?nh Ph�c', '0987634265'),
('DG3', N'Ph?m Th? Loan', '1999-03-27', N'n?', N'Ninh B�nh', '0936572947'),
('DG4', N'Tr?n Thu Trang', '2000-02-28', N'n?', N'H?i Ph�ng', '0973264829'),
('DG5', N'Nguy?n V?n ??t', '2001-1-1', 'nam', N'Thanh H�a', '0384656382')

-- B?ng ViPham
INSERT INTO ViPham (MaVP, TenVP, TienVP, GhiChu)
VALUES
('VP0', N'Kh�ng vi ph?m', '', ''),
('VP1', N'Tr? s�ch mu?n 1 th�ng', '20', ''),
('VP2', N'Tr? s�ch mu?n 1 k?', '100', ''),
('VP3', N'Tr? s�ch mu?n t? 1 n?m tr? l�n', '500', ''),
('VP4', N'L�m r�ch s�ch', '50', ''),
('VP5', N'L�m m?t s�ch', '', N'Gi� cu?n s�ch * 5')

-- B?ng NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinhNV, GioiTinhNV, DiaChiNV, SDTNV) 
VALUES
('NV1', N'?�o Th? Hu?', '1998-6-6', N'N?', N'H?i D??ng', '0275284925'),
('NV2', N'Tri?u Th? M? H?nh', '1999-09-25', N'N?', N'Nam ??nh', '0293682942'),
('NV3', N'Ho�ng Th? Chung', '2000-09-28', N'N?', N'Thanh H�a', '0925348263'),
('NV4', N'V? H?i H?u', '2001-09-25', 'Nam', N'H� N?i', '0925429421'),
('NV5', N'Nguy?n V?n Ki�n', '2002-9-9', 'Nam', N'Ph� Th?', '0256292456')

-- B?ng Login
INSERT INTO Login (MaNhanVien, MatKhau, PhanQuyen)
VALUES
('NV1', '12345678', 'admin'),
('NV2', '12345678', 'admin'),
('NV3', '12345678', 'admin'),
('NV4', '12345678', 'super admin'),
('NV5', '12345678', 'super admin')

-- B?ng DauSach
INSERT INTO DauSach (MaDauSach, TenDauSach, SoTrang, GiaBan, SoLuong, TheLoai, NXB,TacGia)
VALUES
('DS1', N'M?ng m�y t�nh', '209', '60', '100', N'C�ng ngh? th�ng tin', N'NXB Gi�o d?c',N'Hoa Ng?c'),
('DS2', N'To�n cao c?p', '304', '80', '200', 'To�n hoc' , N'NXB ?HSP',N'Tr?nh Quanh Th?ng'),
('DS3', N'T�i th?y hoa v�ng tr�n c? xanh', '165', '50', '300', 'V?n h?c', N'NXB SkyBook',N'M?c ??c Hoa'),
('DS4', N'D? M�n phi�u l?u k�', '98', '100', '400', N'V?n h?c', N'NXB Kim ??ng',N'B�i Tr?ng Hi?p'),
('DS5', N'?nh k? thu?t s?', '325', '72', '500', N'C�ng ngh?', N'NXB Th�i H�',N'Nguy?n ??i Quang')

-- B?ng CuonSach
INSERT INTO CuonSach (MaCuonSach, MaDauSach, TinhTrangCuonSach)
VALUES
('CS1', 'DS1', N'C�n s�ch'),
('CS2', 'DS1', N'C�n s�ch'),
('CS3', 'DS2', N'?� m??n'),
('CS4', 'DS3', N'?� m??n'),
('CS5', 'DS3', N'C�n s�ch')

-- B?ng PhieuMuonTra
INSERT INTO PhieuMuonTra (MaPhieuMuonTra, SoThe, NgayMuon, NgayHenTra, NgayTra, MaNhanVien)
VALUES
('P1', 'DG1', '2017-2-2', '2017-6-2', '2017-6-2', 'NV1'),
('P2', 'DG2', '2017-9-15', '2017-12-15', '2018-1-15', 'NV1'),
('P3', 'DG1', '2018-2-20', '2018-6-20', '2018-12-20', 'NV2'),
('P4', 'DG3', '2018-5-4', '2018-9-5', '2018-9-1', 'NV3'),
('P5', 'DG4', '2019-2-20', '2019-6-10', '', 'NV4')

-- B?ng ChiTietPhieuTra
INSERT INTO ChiTietPhieuMuonTra (MaPhieuMuonTra, MaCuonSach, MaVP, TinhTrangTra)
VALUES
('P1', 'CS1', 'VP0', N'Kh�ng r�ch'),
('P2', 'CS2', 'VP1', N'Kh�ng r�ch'),
('P3', 'CS3', 'VP2', N'Kh�ng r�ch'),
('P4', 'CS4', 'VP4', N'L�m r�ch s�ch'),
('P5', 'CS5', 'VP0', N'Kh�ng r�ch')
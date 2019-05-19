CREATE DATABASE QuanLyThuVien
USE QuanLyThuVien

-----------------------------------------Thiết kế cơ sở dữ liệu--------------------------------------------------------

--	1. Bảng DocGia
CREATE TABLE DocGia(
	SoThe NCHAR(10) PRIMARY KEY,
	HoTen NVARCHAR(50),
	NgaySinh DATE,
	GioiTinh NCHAR(10),
	DiaChi NVARCHAR(50),
	SDT NCHAR(10))

--	2. Bảng ViPham
 CREATE TABLE ViPham (
     MaVP NCHAR(10) PRIMARY KEY,
     TenVP NVARCHAR(50) ,
     TienVP MONEY,
     GhiChu NVARCHAR(50))

-- 3. Bảng NhanVien
CREATE TABLE NhanVien(
	MaNhanVien NCHAR(10) PRIMARY KEY,
	TenNhanVien NVARCHAR(50),
	NgaySinhNV DATE,
	GioiTinhNV NCHAR(10),
	DiaChiNV NVARCHAR(50),
	SDTNV NCHAR(10))

--	4. Bảng DauSach
CREATE TABLE DauSach(
	MaDauSach NCHAR(10) PRIMARY KEY,
	TenDauSach NVARCHAR(50),
	SoTrang INT,
	GiaBan MONEY,
	SoLuong INT,
	TheLoai NVARCHAR(50),
	NXB NVARCHAR(50))

--	5. Bảng CuonSach
CREATE TABLE CuonSach(
	MaCuonSach NCHAR(10) PRIMARY KEY,
	TinhTrangCuonSach NVARCHAR(50),
	MaDauSach NCHAR(10) REFERENCES DauSach (MaDauSach))

--	6. Bảng PhieuMuonTra
CREATE TABLE PhieuMuonTra(
	MaPhieuMuonTra NCHAR(10)PRIMARY KEY,
	NgayMuon DATE,
	NgayHenTra DATE,
	NgayTra DATE,
	SoThe NCHAR(10) REFERENCES DocGia (SoThe),
	MaNhanVien NCHAR(10) REFERENCES NhanVien (MaNhanVien))

--	7. Bảng ChiTietPhieuTra
CREATE TABLE ChiTietPhieuMuonTra(
	MaCuonSach NCHAR(10) REFERENCES CuonSach (MaCuonSach),
	MaPhieuMuonTra NCHAR(10) REFERENCES PhieuMuonTra (MaPhieuMuonTra),
	MaVP NCHAR(10) REFERENCES ViPham (MaVP),
	TinhTrangTra NVARCHAR(50),
	PRIMARY KEY (MaCuonSach, MaPhieuMuonTra))

-- 8. Bảng Login
CREATE TABLE [Login](
	MaNhanVien NCHAR(10) REFERENCES NhanVien(MaNhanVien),
	MatKhau NVARCHAR(50),
	PhanQuyen NVARCHAR(50),
	PRIMARY KEY (MaNhanVien))

--------------------------------------------------Nhập dữ liệu----------------------------------------------------------

-- Bảng DocGia
INSERT INTO DocGia (SoThe, HoTen, NgaySinh, GioiTinh, DiaChi, SDT)
VALUES
('DG1', N'Đỗ Hồng Nhị', '1998-09-20', N'nữ', N'Hà Nội', '0332968986'),
('DG2', N'Nguyễn Thị Mai Dung', '1998-12-22', N'nữ', N'Vĩnh Phúc', '0987634265'),
('DG3', N'Phạm Thị Loan', '1999-03-27', N'nữ', N'Ninh Bình', '0936572947'),
('DG4', N'Trần Thu Trang', '2000-02-28', N'nữ', N'Hải Phòng', '0973264829'),
('DG5', N'Nguyễn Văn Đạt', '2001-1-1', 'nam', N'Thanh Hóa', '0384656382')

-- Bảng ViPham
INSERT INTO ViPham (MaVP, TenVP, TienVP, GhiChu)
VALUES
('VP0', N'Không vi phạm', '', ''),
('VP1', N'Trả sách muộn 1 tháng', '20', ''),
('VP2', N'Trả sách muộn 1 kỳ', '100', ''),
('VP3', N'Trả sách muộn từ 1 năm trở lên', '500', ''),
('VP4', N'Làm rách sách', '50', ''),
('VP5', N'Làm mất sách', '', N'Giá cuốn sách * 5')

-- Bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinhNV, GioiTinhNV, DiaChiNV, SDTNV) 
VALUES
('NV1', N'Đào Thị Huệ', '1998-6-6', N'Nữ', N'Hải Dương', '0275284925'),
('NV2', N'Triệu Thị Mỹ Hạnh', '1999-09-25', N'Nữ', N'Nam Định', '0293682942'),
('NV3', N'Hoàng Thị Chung', '2000-09-28', N'Nữ', N'Thanh Hóa', '0925348263'),
('NV4', N'Vũ Hải Hậu', '2001-09-25', 'Nam', N'Hà Nội', '0925429421'),
('NV5', N'Nguyễn Văn Kiên', '2002-9-9', 'Nam', N'Phú Thọ', '0256292456')

-- Bảng Login
INSERT INTO Login (MaNhanVien, MatKhau, PhanQuyen)
VALUES
('NV1', '12345678', 'admin'),
('NV2', '12345678', 'admin'),
('NV3', '12345678', 'admin'),
('NV4', '12345678', 'super admin'),
('NV5', '12345678', 'super admin')

-- Bảng DauSach
INSERT INTO DauSach (MaDauSach, TenDauSach, SoTrang, GiaBan, SoLuong, TheLoai, NXB)
VALUES
('DS1', N'Mạng máy tính', '209', '60', '100', N'Công nghệ thông tin', N'NXB Giáo dục'),
('DS2', N'Toán cao cấp', '304', '80', '200', 'Toán hoc' , N'NXB ĐHSP'),
('DS3', N'Tôi thấy hoa vàng trên cỏ xanh', '165', '50', '300', 'Văn học', N'NXB SkyBook'),
('DS4', N'Dế Mèn phiêu lưu kí', '98', '100', '400', N'Văn học', N'NXB Kim Đồng'),
('DS5', N'Ảnh kỹ thuật số', '325', '72', '500', N'Công nghệ', N'NXB Thái Hà')

-- Bảng CuonSach
INSERT INTO CuonSach (MaCuonSach, MaDauSach, TinhTrangCuonSach)
VALUES
('CS1', 'DS1', N'Còn sách'),
('CS2', 'DS1', N'Còn sách'),
('CS3', 'DS2', N'Đã mượn'),
('CS4', 'DS3', N'Đã mượn'),
('CS5', 'DS3', N'Còn sách')

-- Bảng PhieuMuonTra
INSERT INTO PhieuMuonTra (MaPhieuMuonTra, SoThe, NgayMuon, NgayHenTra, NgayTra, MaNhanVien)
VALUES
('P1', 'DG1', '2017-2-2', '2017-6-2', '2017-6-2', 'NV1'),
('P2', 'DG2', '2017-9-15', '2017-12-15', '2018-1-15', 'NV1'),
('P3', 'DG1', '2018-2-20', '2018-6-20', '2018-12-20', 'NV2'),
('P4', 'DG3', '2018-5-4', '2018-9-5', '2018-9-1', 'NV3'),
('P5', 'DG4', '2019-2-20', '2019-6-10', '', 'NV4')

-- Bảng ChiTietPhieuTra
INSERT INTO ChiTietPhieuMuonTra (MaPhieuMuonTra, MaCuonSach, MaVP, TinhTrangTra)
VALUES
('P1', 'CS1', 'VP0', N'Không rách'),
('P2', 'CS2', 'VP1', N'Không rách'),
('P3', 'CS3', 'VP2', N'Không rách'),
('P4', 'CS4', 'VP4', N'Làm rách sách'),
('P5', 'CS5', 'VP0', N'Không rách')

SELECT MaPhieuMuonTra, MaCuonSach, ViPham.MaVP, TenVP, TienVP, TinhTrangTra
FROM ChiTietPhieuMuonTra, ViPham
WHERE ChiTietPhieuMuonTra.MaVP = ViPham.MaVP

SELECT * FROM PhieuMuonTra WHERE MaPhieuMuonTra LIKE '%P1%' OR MaNhanVien LIKE '%P1%'
SELECT dbo.PhieuMuonTra.MaPhieuMuonTra, dbo.PhieuMuonTra.NgayMuon, dbo.PhieuMuonTra.NgayHenTra, dbo.PhieuMuonTra.NgayTra, dbo.NhanVien.MaNhanVien, dbo.NhanVien.TenNhanVien, dbo.DocGia.SoThe, dbo.DocGia.HoTen FROM dbo.PhieuMuonTra INNER JOIN dbo.NhanVien ON dbo.PhieuMuonTra.MaNhanVien = dbo.NhanVien.MaNhanVien INNER JOIN dbo.DocGia ON dbo.PhieuMuonTra.SoThe = dbo.DocGia.SoThe
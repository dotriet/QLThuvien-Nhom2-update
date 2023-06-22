CREATE DATABASE QLTV
USE QLTV
-----------------------
set dateformat DMY
CREATE FUNCTION [dbo].[AUTO_IDDG]()
RETURNS VARCHAR(5)--
AS
BEGIN
	DECLARE @ID VARCHAR(5)--
	IF (SELECT COUNT(MaDocGia) FROM DOCGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDocGia, 3)) FROM DocGia--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'DG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'DG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
---------------
CREATE TABLE DOCGIA (
	MaDocGia Varchar(50) PRIMARY KEY DEFAULT ([DBO].[AUTO_IDDG]()),
	HoTen Nvarchar(100) not null,
	MaLoaiDocGia Varchar(50) not null,
	NgSinh Date not null,
	DChi Nvarchar(200) not null,
	Email Varchar(100) not null,
	NgLapThe date not null,
	NgHetHan date ,
	TongNo money not null
	)
	alter table DOCGIA
	add constraint macdinh1 default (0) for TongNo
	CREATE TRIGGER trg5 ON DOCGIA for update AS 
BEGIN
DECLARE @i int
select @i= ThoiHanThe from THAMSO
	UPDATE DOCGIA
	SET NgHetHan =(
		SELECT dateadd(MM,@i,NgLapThe)
		FROM inserted
		where MADOCGIA=DOCGIA.MADOCGIA
	)
	from DOCGIA
join inserted on DOCGIA.MaDocGia=inserted.MaDocGia
END
GO
CREATE TRIGGER trg6 ON DOCGIA for insert AS 
BEGIN
DECLARE @i int
select @i= ThoiHanThe from ThamSo
	UPDATE DOCGIA
	SET NgHetHan =(
		SELECT dateadd(mm,@i,NgLapThe)
		FROM inserted
		where MaDocGia=DOCGIA.MaDocGia
	)
	from DOCGIA
	join inserted On DOCGIA.MaDocGia=inserted.MaDocGia 
END
GO
	
----------------
CREATE FUNCTION [dbo].[AUTO_IDLDG]()--
RETURNS VARCHAR(7)--
AS
BEGIN
	DECLARE @ID VARCHAR(7)--
	IF (SELECT COUNT(MaLoaiDocGia) FROM LOAIDOCGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLoaiDocGia, 3)) FROM LOAIDOCGIA--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MLDG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MLDG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE LOAIDOCGIA (
	MaLoaiDocGia Varchar(50) primary key DEFAULT ([DBO].[AUTO_IDLDG]()),
	TenLoaiDocGia Nvarchar(100) not null
	)
------------
CREATE FUNCTION [dbo].[AUTO_IDS]()--
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaSach) FROM SACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSach, 3)) FROM Sach--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE SACH (
	MaSach Varchar(50) primary key DEFAULT ([DBO].[AUTO_IDS]()) ,
	MaDauSach Varchar(50) not null,
	NhaXuatBan Nvarchar(100) not null,
	NamXuatBan int not null,
	SoLuong int default (0),
	TriGia money not null
	)

	CREATE FUNCTION [dbo].[AUTO_MCTPN]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaCTPN) FROM CT_PHIEUNHAP) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTPN, 3)) FROM CT_PHIEUNHAP--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPN00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CT_PHIEUNHAP(
	MaCTPN Varchar(50) primary key default ([dbo].[AUTO_MCTPN]()),
	MaPhieuNhapSach Varchar(50) not null,
	MaSach Varchar(50) not null,
	SoLuong int not null,
	DonGia money not null,
	)
	alter table CT_PHIEUNHAP
add ThanhTien as (DonGia*SoLuong) 


CREATE TRIGGER trig7 ON CT_PHIEUNHAP for INSERT AS 
BEGIN
	UPDATE SACH
	SET soluong =SACH.soluong+(
		SELECT inserted.soluong
		FROM inserted,SACH
			where SACH.MaSach=inserted.MaSach
	)
	from SACH
	join inserted On SACH.MaSach=inserted.MaSach
END
GO

CREATE TRIGGER trig8 ON CT_PHIEUNHAP for DELETE AS 
BEGIN
	UPDATE SACH
	SET soluong =SACH.soluong-(
		SELECT deleted.soluong
		FROM deleted,SACH
			where SACH.MaSach=deleted.MaSach
	)
	from SACH
	join deleted On SACH.MaSach=deleted.MaSach
END
GO

CREATE TRIGGER trig9 ON CT_PHIEUNHAP for update AS 
BEGIN
	UPDATE SACH
	SET soluong =SACH.soluong-(
		SELECT deleted.soluong
		FROM deleted,SACH
			where SACH.MaSach=deleted.MaSach
	)+
(
		SELECT inserted.soluong
		FROM inserted,SACH
			where SACH.MaSach=inserted.MaSach
	)
			
	from SACH
	join deleted On SACH.MaSach=deleted.MaSach
END
GO
	-----------------
	CREATE FUNCTION [dbo].[AUTO_CS]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaCuonSach) FROM CuonSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCuonSach, 3)) FROM CuonSach--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE CUONSACH(
	MaCuonSach Varchar(50) primary key DEFAULT ([DBO].[AUTO_CS]()),
	MaSach Varchar(50) not null,
	TinhTrang Bit not null
	)
	----------------
		CREATE FUNCTION [dbo].[AUTO_MTL]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaTheLoai) FROM TheLOAI) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTheLoai, 3)) FROM TheLoai--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MTL00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MTL0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE THELOAI (
	MaTheLoai Varchar(50) primary key default ([dbo].[AUTO_MTL]()),
	TenTheLoai Nvarchar(100) not null
	)
--------------------
CREATE FUNCTION [dbo].[AUTO_MDS]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaDauSach) FROM DAUSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDauSach, 3)) FROM DAUSACH--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MDS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MDS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE DAUSACH (
	MaDauSach Varchar(50) primary key default ([dbo].[AUTO_MDS]()) ,
	TenDauSach Nvarchar(100) not null,
	MaTheLoai Varchar(50) not null
	)
------------
CREATE FUNCTION [dbo].[AUTO_MTG]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaTacGia) FROM TACGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTacGia, 3)) FROM TacGia--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MTG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MTG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE TACGIA (
	MaTacGia Varchar(50) primary key default ([dbo].[AUTO_MTG]()),
	TenTacGia Nvarchar(100) not null
	)	
	--------------

CREATE TABLE CTTACGIA (
	MaDauSach Varchar(50) ,
	MaTacGia Varchar(50) not null,
	PRIMARY KEY (MaDauSach, MaTacGia)
	)
-------------------
CREATE FUNCTION [dbo].[AUTO_MPMS]()--
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaPhieuMuonSach) FROM PHIEUMUON) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuMuonSach, 3)) FROM PHIEUMUON--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPMS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPMS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUMUON (
	MaPhieuMuonSach Varchar(50) primary key DEFAULT ([dbo].[AUTO_MPMS]()),
	MaDocGia Varchar(50) not null,
	NgMuon date not null,
	HanTra date not null
	)
	-----------------------------
CREATE FUNCTION [dbo].[AUTO_MCTPM]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaChiTietPhieuMuon) FROM CTPHIEUMUON) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChiTietPhieuMuon, 3)) FROM CTPHIEUMUON--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPM00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPM0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CTPHIEUMUON(
	MaChiTietPhieuMuon Varchar(50) primary key default ([dbo].[AUTO_MCTPM]()),
	MaPhieuMuonSach Varchar(50) not null,
	MaCuonSach Varchar(50) not null,
	TinhTrangPM Bit not null
	)
------------------------------
CREATE FUNCTION [dbo].[AUTO_MPTS]()--
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaPhieuTraSach) FROM PHIEUTraSach) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuTraSach, 3)) FROM PhieuTraSach--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPTS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPTS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUTRASACH (
	MaPhieuTraSach Varchar(50) primary key default ([dbo].[AUTO_MPTS]()),
	MaDocGia Varchar(50) not null,
	NgTra date not null,
	TienPhatKyNay money not null
	)
	------------------
CREATE FUNCTION [dbo].[AUTO_MCTPTS]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaChiTietPhieuTra) FROM CTPT) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChiTietPhieuTra, 3)) FROM CTPT--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPT00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPT0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CTPT(
	MaChiTietPhieuTra Varchar(50) primary key default ([dbo].[AUTO_MCTPTS]()),
	MaPhieuTraSach Varchar(50) not null,
	MaCuonSach Varchar(50) not null,
	MaPhieuMuonSach Varchar(50) not null,
	SoNgayMuon int not null,
	TienPhat money not null
	)
-----------------------------
CREATE FUNCTION [dbo].[AUTO_MPNS]()--
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaPhieuNhapSach) FROM PHIEUNHAPSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuNhapSach, 3)) FROM PHIEUNHAPSACH--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPNS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPNS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUNHAPSACH (
	MaPhieuNhapSach Varchar(50) primary key default ([dbo].[AUTO_MPNS]()),
	NgLap date not null,
	TongTien money default (0)
	)
	-------------------
CREATE FUNCTION [dbo].[AUTO_MCTPN]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaCTPN) FROM CT_PHIEUNHAP) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTPN, 3)) FROM CT_PHIEUNHAP--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPN00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CT_PHIEUNHAP(
	MaCTPN Varchar(50) primary key default ([dbo].[AUTO_MCTPN]()),
	MaPhieuNhapSach Varchar(50) not null,
	MaSach Varchar(50) not null,
	SoLuong int not null,
	DonGia money not null,
	)
	alter table CT_PHIEUNHAP
add ThanhTien as (DonGia*SoLuong) 
----------------------------
CREATE FUNCTION [dbo].[AUTO_MPT]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaPhieuThu) FROM PHIEUTHUTIEN) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuThu, 3)) FROM PHIEUTHUTIEN--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPT00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPT0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUTHUTIEN (
	MaPhieuThu Varchar(50) primary key default ([dbo].[AUTO_MPT]()),
	MaDocGia Varchar(50) not null,
	NgThu date not null,
	SoTienThu money not null,
	ConLai money not null
	)
	-----------------------------
CREATE FUNCTION [dbo].[AUTO_MBCMS]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaBaoCaoMuonSach) FROM BAOCAOMUONSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaBaoCaoMuonSach, 3)) FROM BAOCAOMUONSACH--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MBCMS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MBCMS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE BAOCAOMUONSACH (
	MaBaoCaoMuonSach Varchar(50) primary key default ([dbo].[AUTO_MBCMS]()),
	ThangNam date not null,
	TongSoLuotMuon int not null
	)
	-----------------------
CREATE FUNCTION [dbo].[AUTO_MCTBCMS]()--
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	IF (SELECT COUNT(MaCTBCMS) FROM CTBCMS) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTBCMS, 3)) FROM CTBCMS--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTBCMS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTBCMS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TRIGGER trig1 ON CT_PHIEUNHAP for INSERT AS 
BEGIN
	UPDATE PHIEUNHAPSACH
	SET TongTien =TongTien+(
		SELECT ThanhTien
		FROM inserted,PHIEUNHAPSACH
			where PHIEUNHAPSACH.MaPhieuNhapSach=inserted.MaPhieuNhapSach
	)
	from PHIEUNHAPSACH
	join inserted On PHIEUNHAPSACH.MAPHIEUNHAPSACH=inserted.MAPHIEUNHAPSACH
END
GO
CREATE TRIGGER trig2 ON CT_PHIEUNHAP for DELETE AS 
BEGIN
	UPDATE PHIEUNHAPSACH
	SET TongTien =TongTien-(
		SELECT ThanhTien
		FROM deleted,PHIEUNHAPSACH
			where PHIEUNHAPSACH.MaPhieuNhapSach=deleted.MaPhieuNhapSach
	)
	from PHIEUNHAPSACH
	join deleted On PHIEUNHAPSACH.MAPHIEUNHAPSACH=deleted.MAPHIEUNHAPSACH
END
GO
CREATE TRIGGER trig3 ON CT_PHIEUNHAP for update AS 
BEGIN
	UPDATE PHIEUNHAPSACH
	SET TongTien =TongTien-(
		SELECT ThanhTien
		FROM deleted,PHIEUNHAPSACH
			where PHIEUNHAPSACH.MaPhieuNhapSach=deleted.MaPhieuNhapSach
	)+
(
		SELECT ThanhTien
		FROM inserted,PHIEUNHAPSACH
			where PHIEUNHAPSACH.MaPhieuNhapSach=inserted.MaPhieuNhapSach
	)
			
	from PHIEUNHAPSACH
	join deleted On PHIEUNHAPSACH.MAPHIEUNHAPSACH=deleted.MAPHIEUNHAPSACH
END
GO
CREATE TABLE CTBCMS(
	MaCTBCMS Varchar(50) primary key default ([dbo].[AUTO_MCTBCMS]()),
	MaBaoCaoMuonSach Varchar(50) not null,
	MaTheLoai Varchar(50) not null,
	SoLuotMuon int not null,
	TiLe float not null
	)
------------------------------------

CREATE TABLE BCTRATRE(
	NgayThangNam date primary key default getdate(),
	MaCuonSach Varchar(50) not null,
	MaPhieuMuonSach Varchar(50) not null,
	SoNgayTraTre int not null
	)
CREATE TABLE THAMSO(
	ThoiHanThe int not null,
	TuoiToiThieu int not null,
	TuoiToiDa int not null,
	ThoiGianLuuHanh int not null,
	SoNgayMuonMax int not null,
	SoSachMuonMax int not null,
	MucThuTienPhat money not null
	)
------------------------------------
ALTER TABLE DOCGIA ADD CONSTRAINT FK_DG FOREIGN KEY (MaLoaiDocGia) REFERENCES LOAIDOCGIA(MaLoaiDocGia)
ALTER TABLE SACH ADD CONSTRAINT FK_S FOREIGN KEY (MaDauSach) REFERENCES DAUSACH(MaDauSach)
ALTER TABLE DAUSACH ADD CONSTRAINT FK_DS FOREIGN KEY (MaTheLoai) REFERENCES THELOAI(MaTheLoai)
ALTER TABLE CUONSACH ADD CONSTRAINT FK_CS FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE CTTACGIA ADD CONSTRAINT FK_CTTG FOREIGN KEY (MaDauSach) REFERENCES DAUSACH(MaDauSach)
ALTER TABLE CTTACGIA ADD CONSTRAINT FK_CTTG01 FOREIGN KEY (MaTacGia) REFERENCES TACGIA(MaTacGia)
ALTER TABLE PHIEUMUON ADD CONSTRAINT FK_PM FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
ALTER TABLE CTPHIEUMUON ADD CONSTRAINT FK_CTPM FOREIGN KEY (MaCuonSach) REFERENCES CUONSACH(MaCuonSach)
ALTER TABLE CTPHIEUMUON ADD CONSTRAINT FK_CTPM01 FOREIGN KEY (MaPhieuMuonSach) REFERENCES PHIEUMUON(MaPhieuMuonSach)
ALTER TABLE PHIEUTRASACH ADD CONSTRAINT FK_PT FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
ALTER TABLE CTPT ADD CONSTRAINT FK_CTPT FOREIGN KEY (MaCuonSach) REFERENCES CUONSACH(MaCuonSach)
ALTER TABLE CTPT ADD CONSTRAINT FK_CTPT01 FOREIGN KEY (MaPhieuTraSach) REFERENCES PHIEUTRASACH(MaPhieuTraSach)
ALTER TABLE CTPT ADD CONSTRAINT FK_CTPT02 FOREIGN KEY (MaPhieuMuonSach) REFERENCES PHIEUMUON(MaPhieuMuonSach)
ALTER TABLE CT_PHIEUNHAP ADD CONSTRAINT FK_CTPN FOREIGN KEY (MaPhieuNhapSach) REFERENCES PHIEUNHAPSACH(MaPhieuNhapSach)
ALTER TABLE CT_PHIEUNHAP ADD CONSTRAINT FK_CTPN01 FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE PHIEUTHUTIEN ADD CONSTRAINT FK_PTT FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
ALTER TABLE CTBCMS ADD CONSTRAINT FK_CTBCMS FOREIGN KEY (MaTheLoai) REFERENCES THELOAI(MaTheLoai)
ALTER TABLE CTBCMS ADD CONSTRAINT FK_CTBCMS01 FOREIGN KEY (MaBaoCaoMuonSach) REFERENCES BAOCAOMUONSACH(MaBaoCaoMuonSach)
ALTER TABLE BCTRATRE ADD CONSTRAINT FK_BCTT FOREIGN KEY (MaCuonSach) REFERENCES CUONSACH(MaCuonSach)
ALTER TABLE BCTRATRE ADD CONSTRAINT FK_BCTT02 FOREIGN KEY (MaPhieuMuonSach) REFERENCES PHIEUMUON(MaPhieuMuonSach)
------------------
ALTER TABLE dbo.CUONSACH ADD MaCTPN VARCHAR(50)
ALTER TABLE dbo.CUONSACH ADD CONSTRAINT cs_fk FOREIGN KEY (MaCTPN) REFERENCES dbo.CT_PHIEUNHAP(MaCTPN)
exec sp_DeleteAllData
---------------------------------------------------------
insert into PHIEUNHAPSACH (NgLap) values ('1/5/2015')
---------------------------------------------------------
insert into TACGIA (TenTacGia) values (N'Nguyễn Du')
insert into TACGIA (TenTacGia) values (N'Ngô Tất Tố')
insert into TACGIA (TenTacGia)values (N'Nam Cao')
insert into TACGIA (TenTacGia)values (N'Vũ Trọng Phụng')
insert into TACGIA (TenTacGia)values (N'Nguyễn Ngọc Tư')
insert into TACGIA (TenTacGia)values (N'Nhất Linh')
insert into TACGIA (TenTacGia) values (N'Đoàn Giỏi')
insert into TACGIA (TenTacGia)values (N'Nguyễn Nhật Ánh')
insert into TACGIA (TenTacGia) values (N'Nguyễn Duy')
insert into TACGIA (TenTacGia) values (N'Tô Hoài')
insert into TACGIA (TenTacGia) values (N'Trần Văn Khê')
insert into TACGIA (TenTacGia) values (N'Xuân Diệu')
insert into TACGIA (TenTacGia) values (N'Hồ Xuân Hương')
insert into TACGIA (TenTacGia) values (N'Huy Cận')
insert into TACGIA (TenTacGia) values (N'Bùi Giáng')
insert into TACGIA (TenTacGia) values (N'Hàn Mặc Tử')
insert into TACGIA (TenTacGia) values (N'Hoàng Cầm')
insert into TACGIA (TenTacGia) values (N'Tản Đà')
insert into TACGIA (TenTacGia) values (N'Tố Hữu')
insert into TACGIA (TenTacGia) values (N'Xuân Quỳnh')
insert into TACGIA (TenTacGia) values (N'Nguyễn Quang Sáng')
insert into TACGIA (TenTacGia) values (N'Hồ Anh Thái')

---------------------------------------------------------
insert into THELOAI (TenTheLoai) values (N'Tiếu thuyết')
insert into THELOAI (TenTheLoai) values (N'Truyện ngắn')
insert into THELOAI (TenTheLoai) values (N'Thơ')
---------------------------------------------------------
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Truyện Kiều','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Tắt Đèn','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Lão Hạc','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Số đỏ','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Sống Mòn','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Mặt Trời Lớn','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Đất rừng Phương Nam','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Cô gái đến từ hôm qua','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Những người không tên','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Truyện ngắn của Tô Hoài','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Nỗi buồn chim sáo','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Hoàng hôn','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Từ tương tư','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Chỉ vàng','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Đôi mắt','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Trăng non','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Lệ đá','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Hồn Trương Ba, da hàng thịt','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Em yêu cây cỏ nước non','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Cao nguyên xanh','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Chữ người tử tù','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Con chim xanh biếc bay về','MTL002')
---------------------------------------------------------

insert into CTTACGIA values ('MDS001','MTG001')
insert into CTTACGIA values ('MDS002','MTG002')
insert into CTTACGIA values ('MDS003','MTG003')
insert into CTTACGIA values ('MDS004','MTG004')
insert into CTTACGIA values ('MDS005','MTG005')
insert into CTTACGIA values ('MDS006','MTG006')
insert into CTTACGIA values ('MDS007','MTG007')
insert into CTTACGIA values ('MDS008','MTG008')
insert into CTTACGIA values ('MDS009','MTG09')
insert into CTTACGIA values ('MDS010','MTG010')
insert into CTTACGIA values ('MDS011','MTG011')
insert into CTTACGIA values ('MDS012','MTG012')
insert into CTTACGIA values ('MDS013','MTG013')
insert into CTTACGIA values ('MDS014','MTG014')
insert into CTTACGIA values ('MDS015','MTG015')
insert into CTTACGIA values ('MDS016','MTG016')
insert into CTTACGIA values ('MDS017','MTG017')
insert into CTTACGIA values ('MDS018','MTG018')
insert into CTTACGIA values ('MDS019','MTG019')
insert into CTTACGIA values ('MDS020','MTG020')
insert into CTTACGIA values ('MDS021','MTG021')
insert into CTTACGIA values ('MDS022','MTG022')

---------------------------------------------------------
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS001',N'NXB Trẻ','2018','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS002',N'NXB Văn Học','2019','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS003',N'NXB Văn Học','2019','200000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS004',N'NXB Văn Học','2018','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS005',N'NXB Văn Học','2019','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS006',N'NXB Trẻ','2020','105000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS007',N'NXB Văn Học','2021','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS008',N'NXB Văn Học','2020','120000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS009',N'NXB Văn Học','2019','170000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS010',N'NXB Văn Học','2020','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS011',N'NXB Trẻ','2021','180000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS012',N'NXB Văn Học','2020','130000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS013',N'NXB Trẻ','2020','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS014',N'NXB Văn Học','2018','120000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS015',N'NXB Văn Học','2017','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS016',N'NXB Văn Học','2020','110000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS017',N'NXB Trẻ','2020','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS018',N'NXB Văn Học','2020','200000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS019',N'NXB Văn Học','2022','210000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS020',N'NXB Văn Học','2021','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS021',N'NXB Trẻ','2020','220000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,TriGia) values ('MDS022',N'NXB Văn Học','2019','240000')

insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS001','10','100000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS002','10','100000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS003','10','200000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS004','10','150000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS005','10','100000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS006','10','105000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS007','10','100000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS008','10','120000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS009','10','170000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS010','10','150000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS011','10','180000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS012','10','130000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS013','10','150000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS014','10','120000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS015','10','150000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS016','10','110000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS017','10','150000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS018','10','200000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS019','10','210000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS020','10','150000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS021','10','220000')
insert into CT_PHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia) values ('MPNS001','MS022','10','240000')
---------------------------------------------------------
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS001','1','MCTPN001')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS002','1','MCTPN002')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS003','1','MCTPN003')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS004','1','MCTPN004')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS005','1','MCTPN005')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS006','1','MCTPN006')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS007','1','MCTPN007')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS008','1','MCTPN008')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS009','1','MCTPN009')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS010','1','MCTPN010')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS011','1','MCTPN011')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS012','1','MCTPN012')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS013','1','MCTPN013')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS014','1','MCTPN014')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS015','1','MCTPN015')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS016','1','MCTPN016')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS017','1','MCTPN017')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS018','1','MCTPN018')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS019','1','MCTPN019')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS020','1','MCTPN020')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS021','1','MCTPN021')
insert into CUONSACH (MaSach,TinhTrang,MaCTPN) values ('MS022','1','MCTPN022')


---------------------------------------------------------
---------------------------------------------------------
insert into THAMSO values ('6','18','55','8','4','5','1000')
----------------------------------------------------------
insert into LOAIDOCGIA(TenLoaiDocGia) values (N'Sinh Viên')
insert into LOAIDOCGIA(TenLoaiDocGia) values (N'Giảng Viên')
---------------------------------------------------------
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Đức Thái Vĩ Khang','MLDG001','10/5/2003',N'Long An',N'NguyenVanA@gmail.com','2-1-2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Giang Nam','MLDG001','22/5/2003',N'Đồng Tháp',N'NguyenVanB@gmail.com','12/3/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Thị Bích Chi','MLDG001','1/2/2003',N'Quảng Ngãi',N'NguyenVanC@gmail.com','1/4/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Nguyên Triết','MLDG002','23/6/2000',N'Quảng Ngãi',N'NguyenVanD@gmail.com','13/4/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Minh Nhân','MLDG002','2/1/1992',N'Huế',N'NguyenVanE@gmail.com','10/4/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Nguyễn Hà Vy','MLDG001','1/1/2000',N'Sóc Trăng',N'NguyenVanF@gmail.com','13/4/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Minh Đức','MLDG002','1/10/1997',N'Đồng Nai',N'NguyenVanG@gmail.com','1/5/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Phúc Thọ','MLDG001','8/1/2002',N'Huế',N'NGuyenVanH@gmail.com','5/5/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Hạnh Thảo','MLDG001','20/02/2002',N'Vĩnh Long',N'NguyenVanI@gmail.com','6/5/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,TongNo) values (N'Đỗ Thị Tường Vi','MLDG002','1/2/1991',N'Đắc Lắc',N'NguyenVanK@gmail.com','10/5/2022','0')
---------------------------------------------------------
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG001','11/1/2022','15/1/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG002','15/3/2022','19/3/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG003','15/4/2022','19/4/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG004','20/4/2022','24/4/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG005','25/4/2022','29/4/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG006','30/4/2022','4/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG007','16/5/2022','20/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG008','20/5/2022','24/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG009','22/5/2022','26/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG010','28/5/2022','2/6/2022')
---------------------------------------------------------                        
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS001','MCS001','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS002','MCS002','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS003','MCS003','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS004','MCS004','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS005','MCS005','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS006','MCS006','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS007','MCS007','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS008','MCS008','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS009','MCS009','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS010','MCS010','1')
---------------------------------------------------------
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG001','12/1/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG002','16/3/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG003','16/4/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG004','21/4/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG005','26/4/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG006','1/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG007','17/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG008','21/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG009','23/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG010','29/5/2022','0')
---------------------------------------------------------                          
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS001','MCS001','MPMS001','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS002','MCS002','MPMS002','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS003','MCS003','MPMS003','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS004','MCS004','MPMS004','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS005','MCS005','MPMS005','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS006','MCS006','MPMS006','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS007','MCS007','MPMS007','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS008','MCS008','MPMS008','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS009','MCS009','MPMS009','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS010','MCS010','MPMS010','1','0')
---------------------------------------------------------

insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('3/1/2022','1')
insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('3/3/2022','1')
insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('30/4/2022','3')
insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('3/5/2022','5')
---------------------------------------------------------
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS001','MTL001','1','0.1')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS002','MTL002','1','0.1')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS003','MTL003','1','0.1')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS003','MTL002','2','0.2')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS004','MTL001','2','0.2')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS004','MTL002','2','0.2')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS004','MTL003','1','0.1')
---------------------------------------------------------
---------------------------------------------------------



---------------------------------------------------------




CREATE DATABASE QLDKHP
GO

USE QLDKHP
GO

CREATE TABLE SinhVien
(
	IDSV INT PRIMARY KEY,
	Ho NVARCHAR(10) not null unique,
	Ten NVARCHAR(50) not null unique,
	GioiTinh NVARCHAR(5) CHECK(GioiTinh = N'Nam' OR GioiTinh = N'Nữ'),
	NTNSinh DATE CHECK (NTNSinh < GETDATE()),
	DiaChi NVARCHAR(50),
	SDT VARCHAR(10) UNIQUE,
	SoTinChiDaChon INT CHECK (SoTinChiDaChon <= 185 AND SoTinChiDaChon > 0)
)

CREATE TABLE HocPhan
(
	IDHP VARCHAR(11) PRIMARY KEY,
	TenHP NVARCHAR(50) unique,
	TinChiLyThuyet INT CHECK (TinChiLyThuyet > 0),
	TinChiThucHanh INT CHECK (TinChiThucHanh > 0),
	TongSoTinChi INT
)

CREATE TABLE SinhVienDangKyHocPhan
(
	IDSV INT REFERENCES SinhVien(IDSV),
	IDHP VARCHAR(11) REFERENCES HocPhan(IDHP),
	NgayDangKy DATE,
	HocKy NVARCHAR(10),
	NamHoc INT
)
--SinhVien
set dateformat dmy
insert into SinhVien values ('1911133', N'Nguyễn', N'Trần Quang Bảo', N'Nam', '03/11/2001', N'Đào Duy Từ', '0363456789', 104)
insert into SinhVien values ('1914578', N'Hoàng', N'Trung Hưng', N'Nam', '12/12/2001', N'Nguyễn Chí Thanh', '0366459862', 97)
insert into SinhVien values ('1915743', N'Cao', N'Thị Cẩm Tú', N'Nữ', '26/05/2001', N'Bùi Thị Xuân', '0363598137', 110)
insert into SinhVien values ('1911459', N'Trần', N'Hải Hà', N'Nam', '29/08/2001', N'Phan Bội Châu', '0364985323', 101)
insert into SinhVien values ('1913754', N'Đỗ', N'Thị Thanh Vân', N'Nữ', '06/06/2001', N'Phan Đình Phùng', '0368567433', 107)
insert into SinhVien values ('1913854', N'Phan', N'Trung Quân', N'Nam', '30/12/2000', N'Nguyễn Văn Trỗi', '0365375343', 105)
insert into SinhVien values ('1914854', N'Cù', N'Thị Thảo', N'Nữ', '22/08/2001', N'3 tháng 2', '0364675867', 98)
insert into SinhVien values ('1911147', N'Đào', N'Xuân Hải', N'Nam', '15/03/2001', N'Nguyễn Thị Minh Khai', '0369876412', 100)
insert into SinhVien values ('1911249', N'Mai', N'Hậu', N'Nữ', '01/02/2001', N'Lê Đại Hành', '0369867898', 109)
insert into SinhVien values ('1914775', N'Đinh', N'Trọng Đạt', N'Nam', '03/09/2000', N'Ấp Ánh Sáng', '0367834342', 103)
--Hoc Phan
insert into HocPhan values (N'CT3111D',N'Lập trình cơ sở dữ liệu','2','2','4')
insert into HocPhan values (N'CT3116D',N'Đồ án cơ sở','1','2','3')
insert into HocPhan values (N'CT3133D',N'Phát triển ứng dụng di động','2','2','3')
insert into HocPhan values (N'CT3134D',N'Phát triển ứng dụng web','1','3','4')
insert into HocPhan values (N'CT4215D',N'Công nghệ phần mềm','2','1','3')
insert into HocPhan values (N'LC3101D',N'Tư tưởng Hồ Chí Minh','1','1','2')
insert into HocPhan values (N'CT2105D',N'Cấu trúc dữ liệu và thuật giải','1','2','3')
insert into HocPhan values (N'CT3141D',N'Thiết kế giao diện','2','1','3')
--Sinh Vien Dang Ky Hoc Phan
set dateformat dmy
--Nguyễn Trần Quang Bảo
insert into SinhVienDangKyHocPhan values('1911133','CT3111D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','CT3116D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','CT3133D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','CT3134D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','CT4215D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','LC3101D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','CT2105D','15/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911133','CT3141D','15/08/2021',N'Học Kì 1','2021')
--Hoàng Trung Hưng
insert into SinhVienDangKyHocPhan values('1914578','CT3111D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','CT3116D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','CT3133D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','CT3134D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','CT4215D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','LC3101D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','CT2105D','07/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914578','CT3141D','07/08/2021',N'Học Kì 1','2021')
--Cao Thị Cẩm Tú
insert into SinhVienDangKyHocPhan values('1915743','CT3111D','09/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1915743','CT3116D','09/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1915743','CT3133D','09/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1915743','CT3134D','09/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1915743','CT4215D','09/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1915743','LC3101D','09/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1915743','CT2105D','09/08/2021',N'Học Kì 1','2021')
--Trần Hải Hà
insert into SinhVienDangKyHocPhan values('1911459','CT3111D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','CT3116D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','CT3133D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','CT3134D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','CT4215D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','LC3101D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','CT2105D','12/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911459','CT3141D','12/08/2021',N'Học Kì 1','2021')
--Đỗ Thị Thanh Vân
insert into SinhVienDangKyHocPhan values('1913754','CT3111D','16/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913754','CT3116D','16/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913754','CT3133D','16/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913754','CT3134D','16/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913754','CT4215D','16/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913754','LC3101D','16/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913754','CT3141D','16/08/2021',N'Học Kì 1','2021')
--Phan Trung Quân
insert into SinhVienDangKyHocPhan values('1913854','CT3111D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','CT3116D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','CT3133D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','CT3134D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','CT4215D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','LC3101D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','CT2105D','17/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1913854','CT3141D','17/08/2021',N'Học Kì 1','2021')
--Cù Thị Thảo
insert into SinhVienDangKyHocPhan values('1914854','CT3111D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','CT3116D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','CT3133D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','CT3134D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','CT4215D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','LC3101D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','CT2105D','11/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914854','CT3141D','11/08/2021',N'Học Kì 1','2021')
--Đào Xuân Hải
insert into SinhVienDangKyHocPhan values('1911147','CT3111D','13/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911147','CT3116D','13/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911147','CT3133D','13/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911147','CT3134D','13/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911147','CT4215D','13/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911147','LC3101D','13/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911147','CT3141D','13/08/2021',N'Học Kì 1','2021')
--Mai Hậu
insert into SinhVienDangKyHocPhan values('1911249','CT3111D','08/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911249','CT3116D','08/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911249','CT3133D','08/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911249','CT3134D','08/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911249','CT4215D','08/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911249','LC3101D','08/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1911249','CT2105D','08/08/2021',N'Học Kì 1','2021')
--Đinh Trọng Đạt
insert into SinhVienDangKyHocPhan values('1914775','CT3111D','10/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914775','CT3116D','10/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914775','CT3133D','10/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914775','CT3134D','10/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914775','CT4215D','10/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914775','LC3101D','10/08/2021',N'Học Kì 1','2021')
insert into SinhVienDangKyHocPhan values('1914775','CT3141D','10/08/2021',N'Học Kì 1','2021')
--Xuat bang
select *from SinhVien
select *from HocPhan
select *from SinhVienDangKyHocPhan
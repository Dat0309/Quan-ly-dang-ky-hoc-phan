Create Database QLDKHP
go
use QLDKHP
go

Create table SinhVien
(
	MSSV int primary key,
	Holot nvarchar(100),
	Ten nvarchar(50),
	Tenlop nvarchar(20),
	Khoa nvarchar(100),
	Gioitinh bit,
	Ngaysinh smalldatetime,
	Diachi nvarchar(1000)
)
go
Create table Khoa
(
	MaKhoa int primary key identity(1,1),
	TenKhoa nvarchar(100),
)
go
create table Lop
(
	MaLop int primary key identity(1,1),
	TenLop nvarchar(20),
	MaKhoa int references Khoa(MaKhoa)
)
go
create table HocPhan
(
	MaHP nvarchar(20) primary key,
	TenHP nvarchar(100),
	LoaiHP nvarchar(20),
	HocKy int,
	Nam int,
	Khoa nvarchar(100),
	TSTC int,
	GioiHan int
)
go

create table CT_DKHP
(
	MSSV int references SinhVien(MSSV),
	MaHP nvarchar(20) references HocPhan(MaHP),
	NgayDK smalldatetime,
	HocKy int,
	NamHoc nvarchar(20),
	primary key (MSSV,MaHP)
)
go

Create table Quyen
(
	Id int primary key identity(1,1),
	TenQuyen nvarchar(50),
	MoTa nvarchar(3000)
)
go

Create table TaiKhoan
(
	ID int primary key identity(1,1),
	UserName nvarchar(100),
	Password nvarchar(100),
	Active bit,
	IDQuyen int references Quyen(Id),
	CreateDate smalldatetime,
	FullName nvarchar(100)
)
go

create table LichThi
(
	id int primary key identity(1,1),
	MaHP nvarchar(20) references HocPhan(MaHP),
	HocKy int,
	NamHoc int,
	NgayThi smalldatetime,
	GioThi time,
	ThoiLuong int,
	PhongThi nvarchar(100),
	DiaDiem nvarchar(1000),
	GhiChu nvarchar(3000)
)
go

create table HocPhi
(
	id int primary key identity(1,1),
	MSSV int references SinhVien(MSSV),
	HocKy int,
	NamHoc int,
	HocPhi int,
	CapNhat smalldatetime
)
go
--
create procedure SinhVien_GetAll
as
select * from SinhVien
go
create procedure Khoa_GetAll
as
select * from Khoa
go
create procedure Lop_GetAll
as
select * from Lop
go
create procedure HocPhan_GetAll
as 
select * from HocPhan
go

create procedure TaiKhoan_GetAll
as
select * from TaiKhoan
go

create procedure Quyen_GetAll
as
select * from Quyen
go

create procedure ChiTietDK_GetAll
as
select * from CT_DKHP
go

alter procedure SinhVien_InsertUpdateDelete
	@MSSV int output,
	@HoLot nvarchar(100),
	@Ten nvarchar(50),
	@GioiTinh bit,
	@NgaySinh smalldatetime,
	@TenLop nvarchar(20),
	@Khoa nvarchar(100),
	@Diachi nvarchar(1000),
	@Action int
	as
	if @Action = 0
	begin
		insert into SinhVien (MSSV,HoLot,Ten,GioiTinh,NgaySinh,TenLop,Khoa,DiaChi)
		values (@MSSV, @HoLot,@Ten,@GioiTinh,@NgaySinh,@TenLop,@Khoa,@Diachi)
	end
	else if @Action = 1
	begin
		update SinhVien set HoLot=@HoLot,Ten=@Ten,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,TenLop=@TenLop,Khoa=@Khoa,DiaChi=@Diachi
		where MSSV=@MSSV
	end
	else if @Action = 2
	begin
		delete from HocPhi where MSSV = @MSSV
		delete from CT_DKHP where MSSV = @MSSV
		delete from SinhVien where MSSV = @MSSV
	end
go

create procedure HocPhan_InsertUpdateDelete
	@MaHP varchar(20) output,
	@TenHP nvarchar(50),
	@LoaiHocPhan nvarchar(20),
	@HocKy int,
	@Nam int,
	@Khoa nvarchar(100),
	@TongSoTinChi int,
	@GioiHan int,
	@Action int
	as
	if @Action = 0
	begin
		insert into HocPhan (MaHP,TenHP, LoaiHP,HocKy,Nam,Khoa, TSTC, GioiHan)
		values (@MaHP,@TenHP,@LoaiHocPhan,@HocKy,@Nam,@Khoa,@TongSoTinChi,@GioiHan)
	end
	else if @Action = 1
	begin
		update HocPhan set TenHP = @TenHP, LoaiHP = @LoaiHocPhan, HocKy = @HocKy, Nam = @Nam, Khoa = @Khoa,TSTC=@TongSoTinChi, GioiHan=@GioiHan
		where MaHP = @MaHP
	end
	else if @Action = 2
	begin
		delete from HocPhan where MaHP = @MaHP
	end
go

create procedure Quyen_InsertUpdateDelete
	@Id int output,
	@TenQuyen nvarchar(50),
	@Mota nvarchar(3000),
	@Action int
	as
	if @Action = 0
	begin
		insert into Quyen (TenQuyen,MoTa)
		values (@TenQuyen, @Mota)
		set @Id = @@IDENTITY
	end
	else if @Action = 1
	begin
		update Quyen set TenQuyen = @TenQuyen, MoTa = @Mota
		where Id = @Id
	end
	else if @Action = 2
	begin
		delete from Quyen where Id = @Id
	end
go

create procedure TaiKhoan_InsertUpdateDelete
	@Id int output,
	@UserName nvarchar(100),
	@Password nvarchar(100),
	@Active bit,
	@IDQuyen int,
	@CreateDate smalldatetime,
	@FullName nvarchar(100),
	@Action int
	as
	if @Action = 0
	begin
		insert into TaiKhoan (UserName, Password, Active, IDQuyen,CreateDate,FullName)
		values (@UserName, @Password, @Active, @IDQuyen, @CreateDate,@FullName)
		set @Id = @@IDENTITY
	end
	else if @Action = 1
	begin
		update TaiKhoan set Active = @Active, @IDQuyen = @IDQuyen
		where Id = @Id
	end
	else if @Action = 2
	begin
		update TaiKhoan set Active = 'false'
		where Id = @Id
	end
go


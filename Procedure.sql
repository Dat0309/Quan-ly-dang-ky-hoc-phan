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

create table HocPhan
(
	MaHP nvarchar(20) primary key,
	TenHP nvarchar(100),
	LoaiHP nvarchar(20),
	HocKy int,
	Nam int,
	Khoa nvarchar(100),
	STC int,
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

--drop table LichThi
--drop table CT_DKHP
--drop table HocPhan


create procedure SinhVien_GetAll
as
select * from SinhVien
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

create procedure SinhVien_InsertUpdateDelete
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
	delete from SinhVien where MSSV = @MSSV
end
go

alter procedure HocPhan_InsertUpdateDelete
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
	insert into HocPhan (MaHP,TenHP, LoaiHP,HocKy,Nam,Khoa, STC, GioiHan)
	values (@MaHP,@TenHP,@LoaiHocPhan,@HocKy,@Nam,@Khoa,@TongSoTinChi,@GioiHan)
end
else if @Action = 1
begin
	update HocPhan set TenHP = @TenHP, LoaiHP = @LoaiHocPhan, HocKy = @HocKy, Nam = @Nam, Khoa = @Khoa,STC=@TongSoTinChi, GioiHan=@GioiHan
	where MaHP = @MaHP
end
else if @Action = 2
begin
	delete from HocPhan where MaHP = @MaHP
end
go

alter procedure CTDK_InsertUpdateDelete
@MSSV int,
@MaHP varchar(20),
@NgayDangKy smalldatetime,
@HocKy int,
@NamHoc nvarchar(20),
@Action int
as
if @Action = 0
begin
	insert into CT_DKHP (MSSV, MaHP, NgayDK, HocKy, NamHoc)
	values (@MSSV, @MaHP, @NgayDangKy, @HocKy, @NamHoc)
end
else if @Action = 1
begin
	delete from CT_DKHP where MSSV = @MSSV and MaHP = @MaHP
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

select * from HocPhan
where MaHP not in (
	select MaHP from CT_DKHP where MSSV = 1914775
)and Nam = 3 and HocKy = 1

alter procedure GetHPChuaTichLuy
@mssv int
as
begin
	select * from HocPhan
		where MaHP not in (
					select MaHP from CT_DKHP where MSSV = @mssv
					)
end

alter procedure GetHPTheoKeHoach
@mssv int,
@nam int,
@hocky int,
@khoa nvarchar(100)
as
begin
	select * from HocPhan
	where MaHP not in (
	select MaHP from CT_DKHP where MSSV = @mssv
	)and Nam = @nam and HocKy = @hocky and (Khoa = @khoa or Khoa is null)
end

alter procedure GetHPNgoaiKeHoach
@mssv int,
@hocky int,
@khoa nvarchar(100)
as
begin
	select * from HocPhan
	where MaHP not in (
	select MaHP from CT_DKHP where MSSV = @mssv
	)and (Khoa = @khoa or Khoa is null) and HocKy = @hocky
end

select * from CT_DKHP,HocPhan where CT_DKHP.MaHP = HocPhan.MaHP and MSSV = 1914775

create procedure GetKQDK
@mssv int
as
begin
	select * from CT_DKHP,HocPhan where CT_DKHP.MaHP = HocPhan.MaHP and MSSV = @mssv

end
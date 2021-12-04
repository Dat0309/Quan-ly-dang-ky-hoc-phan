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
	TCLT int,
	TCTH int,
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
create table HocPhi
(
	id int primary key identity(1,1),
	MSSV int references SinhVien(MSSV),
	HocKy int,
	NamHoc nvarchar(20),
	SoTien int,
	CapNhat smalldatetime,
	TinhTrang bit
)
go

--drop table SinhVien
--drop table LichThi
--drop table CT_DKHP
--drop table HocPhan
--drop table HocPhi


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

create procedure Khoa_GetAll
as
select * from Khoa
go

create procedure Lop_GetAll
as
select * from Lop
go

alter procedure HocPhi_GetAll
as
select * from HocPhi where TinhTrang = 'false'
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
	if not exists (select * from SinhVien where MSSV = @MSSV)
	begin
		insert into SinhVien (MSSV,HoLot,Ten,GioiTinh,NgaySinh,TenLop,Khoa,DiaChi)
		values (@MSSV, @HoLot,@Ten,@GioiTinh,@NgaySinh,@TenLop,@Khoa,@Diachi)
		insert into TaiKhoan (UserName, Password, Active, IDQuyen,CreateDate,FullName)
		values (@MSSV, @MSSV, 'true', 2, GETDATE(),@HoLot + ' ' + @Ten)
	end
end
else if @Action = 1
begin
	update SinhVien set HoLot=@HoLot,Ten=@Ten,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,TenLop=@TenLop,Khoa=@Khoa,DiaChi=@Diachi
	where MSSV=@MSSV
end
else if @Action = 2
begin
	delete from CT_DKHP where MSSV = @MSSV
	delete from HocPhi where MSSV = @MSSV
	delete from SinhVien where MSSV = @MSSV
end
go

alter procedure HocPhan_InsertUpdateDelete
@MaHP varchar(20) output,
@TenHP nvarchar(50),
@LoaiHP nvarchar(20),
@HocKy int,
@Nam int,
@Khoa nvarchar(100),
@STC int,
@TCLT int,
@TCTH int,
@GioiHan int,
@Action int
as
if @Action = 0
begin
	insert into HocPhan (MaHP,TenHP, LoaiHP,HocKy,Nam,Khoa, STC,TCLT,TCTH, GioiHan)
	values (@MaHP,@TenHP,@LoaiHP,@HocKy,@Nam,@Khoa,@TongSoTinChi,@TCLT, @TCTH ,@GioiHan)
end
else if @Action = 1
begin
	update HocPhan set TenHP = @TenHP, LoaiHP = @LoaiHP, HocKy = @HocKy, Nam = @Nam, Khoa = @Khoa,STC=@TongSoTinChi,TCLT=@TCLT,TCTH=@TCTH, GioiHan=@GioiHan
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

alter procedure UpdatePassword
@UserName nvarchar(100),
@Password nvarchar(100)
as
update TaiKhoan set Password = @Password
		where UserName = @UserName

alter procedure HocPhi_InsertUpdateDelete
	@Id int output,
	@MSSV int,
	@HocKy int,
	@NamHoc nvarchar(20),
	@SoTien int,
	@CapNhat smalldatetime,
	@TinhTrang bit,
	@Action int
	as
	if @Action = 0
	begin
		if not exists (select * from HocPhi where MSSV = @MSSV and HocKy=@HocKy and NamHoc = @NamHoc)
		begin
			insert into HocPhi(MSSV, HocKy, NamHoc, SoTien, CapNhat, TinhTrang)
			values (@MSSV, @HocKy, @NamHoc, @SoTien, @CapNhat, @TinhTrang)
			set @Id = @@IDENTITY
		end
		else 
		begin
			update HocPhi set SoTien = @SoTien
		where MSSV = @MSSV and HocKy = @HocKy and NamHoc = @NamHoc
		end
	end
	else if @Action = 1
	begin
		update HocPhi set SoTien = @SoTien
		where MSSV = @MSSV and HocKy = @HocKy and NamHoc = @NamHoc
	end
	else if @Action = 2
	begin
		delete from HocPhi
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

select * from CT_DKHP,HocPhan where CT_DKHP.MaHP = HocPhan.MaHP and MSSV = 1914775 and CT_DKHP.HocKy = 1 and CT_DKHP.NamHoc = '2021 - 2022'

create procedure GetKQDK
@mssv int
as
begin
	select * from CT_DKHP,HocPhan where CT_DKHP.MaHP = HocPhan.MaHP and MSSV = @mssv

end

create procedure GetKQDK_HienTai
@mssv int,
@hocky int,
@namhoc varchar(20)
as
begin
	select * from CT_DKHP,HocPhan where CT_DKHP.MaHP = HocPhan.MaHP and MSSV = @mssv and CT_DKHP.HocKy = @hocky and CT_DKHP.NamHoc = @namhoc
end

create procedure UpdateCTDKHP
@mssv int,
@mahp nvarchar(20),
@ngaydk smalldatetime,
@hocky int,
@namhoc varchar(20)
as
begin
	if not exists (select * from CT_DKHP where MSSV = @mssv and MaHP = @mahp)
	begin
		insert into CT_DKHP (MSSV, MaHP, NgayDK, HocKy, NamHoc)
		values (@mssv, @mahp, @ngaydk, @hocky, @namhoc)
	end	
end

alter procedure DeleteByKey
@mssv int,
@mahp nvarchar(20)
as
begin
	delete from CT_DKHP where MSSV = @mssv and MaHP = @mahp
end

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
	if not exists (select * from CT_DKHP where MSSV = @MSSV and MaHP = @MaHP)
	begin
		insert into CT_DKHP (MSSV, MaHP, NgayDK, HocKy, NamHoc)
		values (@MSSV, @MaHP, @NgayDangKy, @HocKy, @NamHoc)
	end
end
else if @Action = 1
begin
	delete from CT_DKHP where MSSV = @MSSV and MaHP = @MaHP
end
go

select a.MSSV, a.MaHP, b.HoLot, b.Ten, c.TenHP, b.TenLop, c.LoaiHP, b.Khoa, c.STC
from CT_DKHP a, SinhVien b, HocPhan c
where a.MSSV = b.MSSV and a.MaHP = c.MaHP and a.HocKy = 1 and a.NamHoc = ''
order by a.MaHP

alter procedure QLChiTietDKHP
as
select a.MSSV, a.MaHP, b.HoLot, b.Ten, c.TenHP, b.TenLop, c.LoaiHP, b.Khoa, c.STC,SLDK.SLDK, a.HocKy, a.NamHoc
from CT_DKHP a, SinhVien b, HocPhan c, (select MaHP,count(*) as SLDK from CT_DKHP group by CT_DKHP.MaHP) SLDK
where a.MSSV = b.MSSV and a.MaHP = c.MaHP and SLDK.MaHP = c.MaHP
order by a.MaHP

alter procedure GetChiTietTheoHocKyVaNam
@hocky int,
@nam varchar(20)
as
select a.MSSV, a.MaHP, b.HoLot, b.Ten, c.TenHP, b.TenLop, c.LoaiHP, b.Khoa, c.STC,SLDK.SLDK, a.HocKy, a.NamHoc
from CT_DKHP a, SinhVien b, HocPhan c, (select MaHP,count(*) as SLDK from CT_DKHP group by CT_DKHP.MaHP) SLDK
where a.MSSV = b.MSSV and a.MaHP = c.MaHP and SLDK.MaHP = c.MaHP and a.HocKy = @hocky and a.NamHoc = @nam
order by a.MaHP


create table Khoa
(
	TenKhoa nvarchar(100) primary key
)

create table Lop
(
	TenLop nvarchar(20) primary key,
	TenKhoa nvarchar(100) references Khoa(TenKhoa)
)

drop table Khoa
drop table Lop
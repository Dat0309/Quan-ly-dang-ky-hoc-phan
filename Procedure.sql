create table LichThi
(
	id int primary key identity(1,1),
	MaHP nvarchar(20) references HocPhan(MaHP),
	HocKy int,
	NamHoc nvarchar(20),
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

create procedure GetChiTietTheoHocKyVaNam
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

create procedure [dbo].[LichThi_GetAll]
as
select * from HocPhan a, LichThi b where a.MaHP = b.MaHP
go

alter procedure [dbo].[LichThi_InsertUpdatedelete]
	@id int output,
	@MaHP nvarchar(20),
	@HocKy int,
	@NamHoc nvarchar(20),
	@NgayThi smalldatetime,
	@GioThi time,
	@ThoiLuong int,
	@PhongThi nvarchar(100),
	@DiaDiem nvarchar(1000),
	@GhiChu nvarchar(3000),
	@Action int
as
begin
if @Action = 0
	begin
		if not exists (select * from LichThi where MaHP = @MaHP)
			begin
				insert into [LichThi] ([MaHP], [HocKy], [NamHoc], [NgayThi], [GioThi], [ThoiLuong], [PhongThi], [DiaDiem], [GhiChu])
				values (@MaHP, @HocKy, @NamHoc, @NgayThi, @GioThi, @ThoiLuong, @PhongThi, @DiaDiem, @GhiChu)
				set @id=@@IDENTITY
			end
	end
else if @Action = 1
	begin	
		update [LichThi]
		set [NgayThi] = @NgayThi,
			[GioThi] = @GioThi,
			[ThoiLuong] = @ThoiLuong,
			[PhongThi] = @PhongThi,
			[DiaDiem] = @DiaDiem,
			[GhiChu] = @GhiChu
			where [id] = @id
	end
else if @Action = 2
	begin
		delete from [LichThi] where [id] = @id
	end
end


execute dbo.LichThi_InsertUpdatedelete 2,N'CT3116D',1,N'2021 - 2022','12-25-2021','13:00:00',60,N'A7',N'DHDL',N'Cap nhat',1

select * from HocPhan a, CT_DKHP b where a.MaHP = b.MaHP and b.NamHoc = '2021 - 2022' and b.HocKy = 1

select*from CT_DKHP

create procedure QLChiTietHP
as
select a.MaHP, a.TenHP, a.Khoa, a.STC, sldk.SLDK, a.HocKy, b.GioThi, b.DiaDiem, b.ThoiLuong, b.GhiChu
from HocPhan a, (select MaHP, COUNT(*)as SLDK From CT_DKHP group by CT_DKHP.MaHP) as sldk,
(select MaHP, COUNT(*)as GioThi, DiaDiem, ThoiLuong, GhiChu
from LichThi 
group by LichThi.MaHP,GioThi, DiaDiem, ThoiLuong, GhiChu)as b
where a.MaHP = sldk.MaHP and b.MaHP = a.MaHP
order by a.MaHP

Create procedure GetHocPhanTheoHocKyVaNam
@NamHoc varchar(20),
@HocKy int
As
select a.MaHP, a.TenHP, a.Khoa, a.STC, sldk.SLDK
from HocPhan a, (select MaHP, COUNT(*)as SLDK From CT_DKHP group by CT_DKHP.MaHP) as sldk
where a.MaHP in (select distinct MaHP from CT_DKHP where NamHoc = @NamHoc and HocKy = @HocKy ) and a.MaHP = sldk.MaHP
order by a.MaHP

alter procedure CheckSVDangKyHocPhan
@MaHP nvarchar(20)
as
begin
	select *
	from SinhVien a
	where a.MSSV in (select MSSV from CT_DKHP where MaHP = @MaHP)
end

alter proc LoadLichThi
@NamHoc nvarchar(20),
@HocKy int
as
begin
select distinct  a.MaHP, a.TenHP, a.Khoa, a.STC, sldk.SLDK, b.NgayThi, b.GioThi, b.PhongThi, b.ThoiLuong, b.DiaDiem, b.GhiChu, b.id
from HocPhan a left join LichThi b on a.MaHP = b.MaHP, CT_DKHP c, (select MaHP, COUNT(*)as SLDK From CT_DKHP group by CT_DKHP.MaHP) as sldk
where a.HocKy = @HocKy and c.NamHoc = @NamHoc and c.MaHP = a.MaHP and a.MaHP = sldk.MaHP
end

alter procedure GetLichThiSV
@mssv int,
@hocky int
as
select * from LichThi
where MaHP in (select MaHP from CT_DKHP where MSSV = @mssv and HocKy = @hocky)
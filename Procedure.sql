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
@SDT varchar(10),
@Action int
as
if @Action = 0
begin
	insert into SinhVien (MSSV,HoLot,Ten,GioiTinh,NgaySinh,TenLop,Khoa,DiaChi,SDT)
	values (@MSSV, @HoLot,@Ten,@GioiTinh,@NgaySinh,@TenLop,@Khoa,@Diachi,@SDT)
end
else if @Action = 1
begin
	update SinhVien set HoLot=@HoLot,Ten=@Ten,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,TenLop=@TenLop,Khoa=@Khoa,DiaChi=@Diachi,SDT=@SDT
	where MSSV=@MSSV
end
else if @Action = 2
begin
	delete from SinhVien where MSSV = @MSSV
end
go

create procedure HocPhan_InsertUpdateDelete
@MaHP varchar(20) output,
@TenHP nvarchar(50),
@LoaiHocPhan nvarchar(20),
@TinChiLyThuyet int,
@TinChiThucHanh int,
@TongSoTinChi int,
@Action int
as
if @Action = 0
begin
	insert into HocPhan (MaHP,TenHP, LoaiHocPhan, TinChiLyThuyet, TinChiThucHanh, TongSoTinChi)
	values (@MaHP,@TenHP,@LoaiHocPhan,@TinChiLyThuyet,@TinChiThucHanh,@TongSoTinChi)
end
else if @Action = 1
begin
	update HocPhan set TenHP = @TenHP, LoaiHocPhan = @LoaiHocPhan,TinChiLyThuyet= @TinChiLyThuyet, TinChiThucHanh = @TinChiThucHanh,TongSoTinChi=@TongSoTinChi
	where MaHP = @MaHP
end
else if @Action = 2
begin
	delete from HocPhan where MaHP = @MaHP
end
go

create procedure CTDK_InsertUpdateDelete
@MSSV int,
@MaHP varchar(20),
@NgayDangKy smalldatetime,
@HocKy int,
@NamHoc int,
@Action int
as
if @Action = 0
begin
	insert into CT_DKHP (MSSV, MaHP, NgayDangKy, HocKy, NamHoc)
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
@Action int
as
if @Action = 0
begin
	insert into TaiKhoan (UserName, Password, Active, IDQuyen,CreateDate)
	values (@UserName, @Password, @Active, @IDQuyen, @CreateDate)
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
/*
Tên: Phan Thị Bích Hân
MSSV: 18211TT4883
Đồ Án Quản Lý Cửa Hàng Truyện Tranh
CSDL có tổng cộng 5 bảng
dbo.MANGASTORE, dbo.ACCOUNT, dbo.CUSTOMER, dbo.STAFF, dbo.SELL
*/

create database MANGAMANAGEMENT
go

use MANGAMANAGEMENT
go

--Tạo bảng--
--Bảng MANGASTORE--
/*ID, Name, author, genre, covertype, version, publishing company, price, quantity*/
create table MANGASTORE
(
	ID int identity(1, 1) primary key
	, Name varchar(100) not null
	, Author varchar(50) not null
	, Genre varchar (100) not null
	, CoverType varchar(50)
	, Version varchar(50)
	, PublishingCompany varchar(50) not null
	, Price int not null
	, Quantity int not null default 0
)
go

--Bảng STAFF--
/*ID, Name, Sex, Dateofbirth, Address, phone*/
--drop table STAFF
--go
create table STAFF
(
	ID int identity(1, 1) primary key
	, Name varchar(100) not null
	, Sex varchar(5) not null
	, DateOfBirth date not null DEFAULT GETDATE()
	, Address varchar(100) not null
	, Phone varchar(10) not null
)
go

--Bảng CUSTOMER--
create table CUSTOMER
(
	ID int identity(1,1) primary key
	, Name varchar(100) not null
	, Sex varchar(5) not null
	, DateOfBirth date not null DEFAULT GETDATE()
	, Address varchar(100) not null
	, Phone varchar(10) not null
)
go


--Bảng ACCOUNT--
/*ID, UserName, Password*/
create table ACCOUNT
(
	ID int identity(1, 1) primary key
	, Username varchar(50)
	, Password varchar(50)
)
go


--Bảng SELL--
/*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity, TotalPrice*/
--drop table SELL
--go
create table SELL
(
	ID int identity(1, 1) primary key
	, IDCustomer int
	, IDManga int not null
	, CustomerName varchar(100)
	, MangaName varchar(100) not null
	, Price int not null
	, Quantity int not null default 0
	FOREIGN KEY (IDManga) REFERENCES dbo.MANGASTORE(ID),
	FOREIGN KEY (IDCustomer) REFERENCES dbo.CUSTOMER(ID)
)
GO

--Bảng STOCKRECEIVING--
/*ID, Received date, staff name*/

----------------------------------------------------------------------------------------------------------
--THÊM DỮ LIỆU VÀO BẢNG--
--ACCOUNT--
insert into dbo.ACCOUNT
values('hanphan', '111')
go
insert into dbo.ACCOUNT
values('human', '222')
go

--MANGASTORE--
/*ID, Name, author, genre, covertype, version, publishing company, price, quantity*/
insert into dbo.MANGASTORE
values('Dua con cua thoi tiet', 'Shinkai Makoto', 'Tinh cam', 'Soft cover(Normal)', 'Collectible version', 'Nha xuat ban Hong Duc', 85000, 32)
go
insert into dbo.MANGASTORE
values('Nhung dua tre duoi theo tinh tu', 'Akisaka Asahi', 'Phieu luu', 'Soft cover(Normal)', 'Normal version', 'Nha xuat ban Phuong Nam', 50000, 17)
go
insert into dbo.MANGASTORE
values('Ky sinh thu', 'Hiroshi Iwaaki', 'Kinh di', 'Soft cover(Normal)', 'Normal version', 'Nha xuat ban Tre', 50000, 17)
go
insert into dbo.MANGASTORE
values('Your Name', 'Shinkai Makoto', 'Tam ly', 'Loose cover', 'Special version', 'Nha xuat ban Kim Dong', 95000, 96)
go
insert into dbo.MANGASTORE
values('Re:zero - bat dau lai o the gioi khac', 'Daichi Matsuse', 'Xuyen khong', 'Soft cover(Normal)', 'Normal version', 'Nha xuat ban Kim Dong', 50000, 17)
go

--STAFF--
/*ID, Name, Sex, Dateofbirth, Address, phone*/
insert into dbo.STAFF
values('Nguyen Phuong Khanh', 'nu', '6/9/2000', '456/45/7 Nguyen Tri Phuong', '0654123336')
go
insert into dbo.STAFF
values('Ho Duc Phuc', 'nam', '10/30/1999', '8888 Nhan Nghia', '0375556989')
go
insert into dbo.STAFF
values('Tran Gia Han', 'nu', '12/16/1996', '65 Phan Boi Chau', '0361558574')
go

--CUSTOMER--
/*ID, Name, Sex, Dateofbirth, Address, phone*/
insert into dbo.CUSTOMER
values('Le Ngoc Bao Anh', 'nu', '4/20/2000', '456/45/7 Nguyen Tri Phuong', '0358545895')
go
insert into dbo.CUSTOMER
values('Nguyen Phu Thien An', 'nam', '2/27/1990', '8888 Nhan Nghia', '0322235158')
go
insert into dbo.CUSTOMER
values('Pham Thi Thuy Tien', 'nu', '3/30/1997', '65 Phan Boi Chau', '0125446512')
go

--SELL--


----------------------------------------------------------------------------------------------------------
--PROCEDURE STORED--
--ACCOUNT TABLE--
--Get data account--
--Lấy dữ liệu từ bảng ACCOUNT
create proc GetDataAccount
As 
begin
	select * from dbo.ACCOUNT
end
go

create proc LoginAccount
	@Username varchar(50)
	, @Password varchar(50)
as
begin
	select dbo.ACCOUNT.Username, dbo.ACCOUNT.Password
	from dbo.ACCOUNT
	where Username =@Username and Password = @Password
end
go

--Add account--
create proc AddAcc
	@Username varchar(50), @Password varchar(50)
as
begin
	insert into dbo.ACCOUNT(Username, Password) 
	values (@Username, @Password)
end
go

--Edit/Update account--
create proc EditAcc
	@ID int, @Username varchar(50), @Password varchar(50)
as
	update dbo.ACCOUNT
	set Password = @Password
	where Username = @Username
go

--Delete/Remove account--
create proc DeleteAcc
	@Username varchar(50)
as 
begin
	delete from dbo.ACCOUNT 
	where Username = @Username
end
go

--Search account--
create proc SearchAcc
	@search varchar(50)
as
begin
	select * from dbo.ACCOUNT 
	where Username like '%'+@search+'%'
end
go

----------------------------------------------------------------------------------------------------------
--PROCEDURE STORED--
--MANGASTORE TABLE--
--Get data account--
--Lấy dữ liệu từ bảng MANGASTORE
create proc GetDataMangaStore
As 
begin
	select * from dbo.MANGASTORE
end
go

----Add MangaStore--
create proc AddMangaStore
	@Name varchar(100)
	, @Author varchar(50)
	, @Genre varchar (50)
	, @CoverType varchar(50)
	, @Version varchar(50)
	, @PublishingCompany varchar(50)
	, @Price int
	, @Quantity int
as
begin
	insert into dbo.MANGASTORE(Name, Author, Genre, CoverType, Version, PublishingCompany, Price, Quantity)
	values (@Name, @Author, @Genre, @CoverType, @Version, @PublishingCompany, @Price, @Quantity)
end
go

--Edit/Update MangaStore--
create proc EditMangaStore
	@ID int
	, @Name varchar(100)
	, @Author varchar(50)
	, @Genre varchar (50)
	, @CoverType varchar (50)
	, @Version varchar (50)
	, @PublishingCompany varchar(50)
	, @Price int
	, @Quantity int
as
	update dbo.MANGASTORE
	set 
		Name = @Name
		, Author = @Author
		, Genre = @Genre
		, CoverType = @CoverType
		, Version = @Version
		, PublishingCompany = @PublishingCompany
		, Price = @Price
		, Quantity = @Quantity
	where ID = @ID
go

--Delete/Remove MangaStore--
create proc DeleteMangaStore
	@ID int
as 
begin
	delete from dbo.MANGASTORE
	where ID = @ID
end
go

--Search MangaStore--
create proc SearchMangaStore
	@search varchar(50)
as
begin
	select * from dbo.MANGASTORE
	where Name like '%'+@search+'%'
end
go

----------------------------------------------------------------------------------------------------------
--PROCEDURE STORED--
--MANGASTORE TABLE--
--Get data account--
--Lấy dữ liệu từ bảng STAFF
create proc GetDataStaff
As 
begin
	select * from dbo.STAFF
end
go

----Add staff--
/*ID, Name, Sex, Dateofbirth, Address, phone*/
create proc AddStaff
	@Name varchar(100)
	, @Sex varchar(5)
	, @DateOfBirth date
	, @Address varchar(100)
	, @Phone varchar(10)
as
begin
	insert into dbo.STAFF(Name, Sex, DateOfBirth, Address, Phone)
	values (@Name, @Sex, @DateOfBirth, @Address, @Phone)
end
go

--Edit/Update staff--
create proc EditStaff
	@ID int
	, @Name varchar(100)
	, @Sex varchar(5)
	, @DateOfBirth date
	, @Address varchar(100)
	, @Phone varchar(10)
as
	update dbo.STAFF
	set 
		Name = @Name
		, Sex = @Sex
		, DateOfBirth = @DateOfBirth
		, Address = @Address
		, Phone = @Phone
	where ID = @ID
go

--Delete/Remove staff--
create proc DeleteStaff
	@ID int
as 
begin
	delete from dbo.STAFF
	where ID = @ID
end
go

--Search staff--
create proc SearchPhoneStaff
	@search varchar(50)
as
begin
	select * from dbo.STAFF
	where Phone like '%'+@search+'%'
end
go

----------------------------------------------------------------------------------------------------------
--PROCEDURE STORED--
--Customer TABLE--
--Get data Customer--
--Lấy dữ liệu từ bảng CUSTOMER
create proc GetDataCustomer
As 
begin
	select * from dbo.CUSTOMER
end
go

----Add Customer--
/*ID, Name, Sex, Dateofbirth, Address, phone*/
create proc AddCustomer
	@Name varchar(100)
	, @Sex varchar(5)
	, @DateOfBirth date
	, @Address varchar(100)
	, @Phone varchar(10)
as
begin
	insert into dbo.CUSTOMER(Name, Sex, DateOfBirth, Address, Phone)
	values (@Name, @Sex, @DateOfBirth, @Address, @Phone)
end
go

--Edit/Update Customer--
create proc EditCustomer
	@ID int
	, @Name varchar(100)
	, @Sex varchar(5)
	, @DateOfBirth date
	, @Address varchar(100)
	, @Phone varchar(10)
as
	update dbo.CUSTOMER
	set 
		Name = @Name
		, Sex = @Sex
		, DateOfBirth = @DateOfBirth
		, Address = @Address
		, Phone = @Phone
	where ID = @ID
go

--Delete/Remove Customer--
create proc DeleteCustomer
	@ID int
as 
begin
	delete from dbo.CUSTOMER
	where ID = @ID
end
go

--Search Customer--
create proc SearchPhoneCustomer
	@search varchar(50)
as
begin
	select dbo.CUSTOMER.Name
	from dbo.CUSTOMER
	where Phone like '%'+@search+'%'
end
go

--In danh sách Khách hàng--
--create proc PrintCustomer
--as
--begin
--	select dbo.CUSTOMER.*
--	from dbo.CUSTOMER
--end
--go


--PROCEDURE STORED--
--SELL TABLE--
--Get data SELL--
--Lấy dữ liệu từ bảng SELL

--dữ liệu chỉ để test
/*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity, TotalPrice*/
--SELECT dbo.SELL.ID, dbo.CUSTOMER.Name ,dbo.MANGASTORE.Name, dbo.MANGASTORE.Price, dbo.SELL.Quantity, dbo.SELL.TotalPrice
create proc GetDataSell
As 
begin
	--SELECT dbo.SELL.ID, dbo.CUSTOMER.Name ,dbo.MANGASTORE.Name, dbo.MANGASTORE.Price, dbo.SELL.Quantity, dbo.SELL.TotalPrice
	SELECT dbo.SELL.ID, dbo.SELL.IDCustomer, dbo.SELL.CustomerName, dbo.SELL.IDManga, dbo.SELL.MangaName, dbo.SELL.Price, dbo.SELL.Quantity
	FROM dbo.SELL
	LEFT OUTER JOIN dbo.CUSTOMER 
	ON dbo.SELL.IDCustomer = dbo.CUSTOMER.ID and dbo.SELL.CustomerName = dbo.CUSTOMER.Name
	LEFT OUTER JOIN dbo.MANGASTORE 
	ON dbo.SELL.IDManga = dbo.MANGASTORE.ID and dbo.SELL.MangaName = dbo.MANGASTORE.Name and dbo.SELL.Price = dbo.MANGASTORE.Price
end
go



create proc DeleteDataSell
as
begin
	delete from dbo.SELL
end
go

create proc TotalPrice
as
begin
	SELECT SUM(dbo.SELL.Price)
	FROM dbo.SELL
end
go

----Add Sell--
/*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity, TotalPrice*/
create proc AddSell
	@IDCustomer int
	, @IDManga int
	, @CustomerName varchar(100)
	, @MangaName varchar(100)
	, @Price int
	, @Quantity int
as
begin
	insert into dbo.SELL(IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity)
	values (@IDCustomer, @IDManga, @CustomerName, @MangaName, @Price, @Quantity)
end
go

--Edit/Update Sell--
create proc EditSell
	@ID int
	, @IDCustomer int
	, @IDManga int
	, @CustomerName varchar(100)
	, @MangaName varchar(100)
	, @Price int
	, @Quantity int
as
	update dbo.SELL
	set 
	IDCustomer = @IDCustomer
	, IDManga = @IDManga
	, CustomerName = @CustomerName
	, MangaName = @MangaName
	, Price = @Price
	, Quantity = @Quantity
	where ID = @ID
go

--Delete/Remove SELL--
create proc DeleteSell
	@ID int
as 
begin
	delete from dbo.SELL
	where ID = @ID
end
go

create proc GetIDNameCustomer
	@phone varchar(50)
as
begin
	select dbo.CUSTOMER.ID, dbo.CUSTOMER.Name
	from dbo.CUSTOMER
	where Phone like '%'+@phone+'%'
end
go

create proc GetNameManga
	@name varchar(100)
as
begin
	SELECT dbo.MANGASTORE.ID, dbo.MANGASTORE.Name, dbo.MANGASTORE.Price
	from dbo.MANGASTORE
	where Name like '%'+@name+'%'
end
go

/* cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhật */
CREATE TRIGGER sellManga ON dbo.SELL AFTER INSERT AS 
BEGIN
	UPDATE dbo.MANGASTORE
	SET dbo.MANGASTORE.Quantity = dbo.MANGASTORE.Quantity - (
		SELECT dbo.SELL.Quantity
		FROM dbo.SELL
		WHERE dbo.SELL.IDManga = dbo.MANGASTORE.ID
	)
	FROM dbo.MANGASTORE
	JOIN dbo.SELL ON dbo.MANGASTORE.ID = dbo.SELL.IDManga
END
GO
/* cập nhật hàng trong kho sau khi cập nhật đặt hàng */
--drop TRIGGER sellUpdateManga
--go

CREATE TRIGGER sellUpdateManga on dbo.SELL AFTER UPDATE AS
BEGIN
   UPDATE dbo.MANGASTORE SET dbo.MANGASTORE.Quantity = dbo.MANGASTORE.Quantity -
	   (SELECT Quantity FROM inserted WHERE IDManga = dbo.MANGASTORE.ID) +
	   (SELECT Quantity FROM deleted WHERE IDManga = dbo.MANGASTORE.ID)
   FROM dbo.MANGASTORE 
   JOIN deleted ON dbo.MANGASTORE.ID = deleted.IDManga
END
GO
/* cập nhật hàng trong kho sau khi hủy đặt hàng */
--drop TRIGGER sellCancelManga
--go

CREATE TRIGGER sellCancelManga ON dbo.SELL FOR DELETE AS 
BEGIN
	UPDATE dbo.MANGASTORE
	SET dbo.MANGASTORE.Quantity = dbo.MANGASTORE.Quantity + (SELECT Quantity FROM deleted WHERE IDManga = dbo.MANGASTORE.ID)
	FROM dbo.MANGASTORE 
	JOIN deleted ON dbo.MANGASTORE.ID = deleted.IDManga
END
GO
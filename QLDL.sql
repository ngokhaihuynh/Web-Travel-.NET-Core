CREATE DATABASE QLDL
USE QLDL

--Danh muc
CREATE TABLE CATEGORIES (
	CatId int identity(1,1) primary key,
	CatName nvarchar(300),
	Description nvarchar(max),
	ParentId int,  -- id danh muc cha
	levels int, -- cap cua danh muc
	Location int ,
	Publish bit, -- hien thi
	Image nvarchar(300), -- anh 
	Title nvarchar(300),
)


-- san pham
CREATE TABLE PRODUCTS (
	ProductId int identity(1,1) primary key,
	ProductName nvarchar(300),
	ShortDesc nvarchar(300),
	Description nvarchar(max),
	CatId int ,
	Price int,
	Discount int,
	Image nvarchar(300),
	video nvarchar(300),
	CreateDate  datetime,
	CreateModified datetime, -- ngay chinh sua
	BestSeller bit, -- san pham chinh
	HomeFlag bit, -- san pham gim
	Actice bit,
	Tags nvarchar(max),
	title nvarchar(300),
	MetaDesc nvarchar(300),
	MetaKey nvarchar(300),
	StockingTour int , -- con ranh tour
	Quantity int,
	Images nvarchar(300),
	Thumb nvarchar(MAX),
	Address nvarchar(MAX),
	FOREIGN KEY (CatId) REFERENCES CATEGORIES(CatId)
)


-- vi tri
CREATE TABLE LOCATIONS(
	LocationId int identity(1,1) primary key,
	Name nvarchar(200),
	Type nvarchar(20),
	Slug nvarchar(100),
	Namewithtype  nvarchar(300),
	Pathwithtype nvarchar(300),
	ParentCode int,
	Levels int
)

--khach hang
CREATE TABLE CUSTOMERS (
	CusId int identity(1,1) primary key,
	FullName nvarchar(300),
	Birthday datetime,
	Avata nvarchar(300),
	Address nvarchar(300),
	Email nvarchar(300),
	Phone nvarchar(300),
	LocationId int,
	District int,
	Ward int,
	CreateDate datetime,
	Password nvarchar(50),
	Encode nchar(10), -- ma hoa password
	LastLogin datetime,
	Active bit,
	Salt nvarchar(100),
	FOREIGN KEY (LocationId) REFERENCES LOCATIONS(LocationId)
)
-- trang thai don hang
CREATE TABLE TRANSACTSTATUS (
	TransactId int identity(1,1) primary key,
	Status nvarchar(100),
	Description nvarchar(max)
)

-- don hang
CREATE TABLE ORDERS (
	OrderId int identity(1,1) primary key,
	CusId int,
	OrderDate datetime,
	ShipDate datetime, -- ngay di
	TransactId int , -- trang thai
	Deteled bit, -- trang thai huy
	Paid bit, -- trang thai thanh toan
	PaymentDate datetime, -- ngay thanh toan
	PaymentId int, -- kieu thanh toan
	Note nvarchar(max),
	TotalMoney int,
	FOREIGN KEY (CusId) REFERENCES CUSTOMERS(CusId),
	FOREIGN KEY (TransactId) REFERENCES TRANSACTSTATUS(TransactId)
)

-- chi tiet don hang
CREATE TABLE ORDERDETAILS (
	OrderDetailId int identity(1,1) primary key,
	OrderId int,
	ProductId int,
	OrderNumber int,
	Quantity int,
	Discount int,
	Total int,
	ShipDate datetime,
	Price int,
	Location int,
	FOREIGN KEY (OrderId) REFERENCES ORDERS(OrderId),
	FOREIGN KEY (ProductId) REFERENCES PRODUCTS(ProductId)
)

-- thong tin it thay doi
CREATE TABLE PAGES (
	PageId int identity(1,1) primary key,
	PageName nvarchar(300),
	Contents nvarchar(max),
	Image nvarchar(300),
	Publish bit,
	Title nvarchar(300),
	MetaDesc nvarchar(300),
	MetaKey nvarchar(300),
	CreatDate datetime,
	Alias nvarchar(500),
)

-- Quyen truy cap
CREATE TABLE ROLES (
	RoleId int identity(1,1) primary key,
	RoleName nvarchar(100),
	Description nvarchar(100)
)

-- Tai Khoan
CREATE TABLE ACCOUNTS (
	AccId int identity(1,1) primary key,
	FullName nvarchar(150),
	Phone varchar(12),
	Email nvarchar(50),
	Password nvarchar(50),
	Encode nchar(10), -- ma hoa password
	Active bit,
	access int, -- quyen truy cap
	LastLogin datetime, -- lan dang nhap cuoi
	createDate datetime,
	RoleId int,
	Salt nvarchar(500),
	FOREIGN KEY (RoleId) REFERENCES ROLES(RoleId)
)

-- tin tuc
CREATE TABLE NEWS (
	PostId int identity(1,1) primary key,
	Tile nvarchar(300),
	ShortContent nvarchar(300),
	Contents nvarchar(max),
	Image nvarchar(300),
	Publish bit,
	CreateDate datetime,
	Author nvarchar(300), -- tac gia
	CatId int,
	AccId int ,
	Tags nvarchar(max),
	IsHot bit,
	IsNewFeed bit,
	MetaDesc nvarchar(300),
	MetaKey nvarchar(300),
	Views int,
	FOREIGN KEY (CatId) REFERENCES CATEGORIES(CatId),
	FOREIGN KEY (AccId) REFERENCES ACCOUNTS(AccId)
)
CREATE TABLE CONTACT (
	IdLienHe int identity(1,1) primary key,
	FullName nvarchar(300),

	Email nvarchar(500),
	Phone nvarchar(500),
	Note nvarchar(max),
	
)
CREATE TABLE COMMENT (
    CommentId INT IDENTITY(1,1) PRIMARY KEY ,
    CommentText TEXT NOT NULL,
    CusId INT,
    ProductId INT,
    CommentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CusId) REFERENCES CUSTOMERS(CusId),
    FOREIGN KEY (ProductId) REFERENCES PRODUCTS(ProductId)
);


ALTER TABLE ORDERS
ADD CONSTRAINT fk_LOCATIONS
FOREIGN KEY (LocationId)
REFERENCES LOCATIONS(LocationId);



create database FPT;
use FPT
create table KHACHHANG(
    MAKH varchar(10) not NULL,
    TenKH nvarchar(50) not NULL,
    DiaChi nvarchar(50) not NULL,
    Email varchar(50) not NULL,
    Sdt varchar(50) not NULL,
    Constraint PK_KHACHHANG primary key(MAKH)
);
create table TAICHINH(
    MATC varchar(10) not NULL,
    TenTC nvarchar(50) not NULL,
    STK varchar(50) not NULL,
    SoTien money not NULL,
    Constraint PK_TAICHINH primary key(MATC)
);
create table HOPDONG(
    MAHD varchar(10) not NULL,
    MAKH varchar(10) not NULL,
    NgayKy datetime not NULL,
    NgayHetHan datetime not NULL,
    GiaTriHD money not NULL,
    Constraint PK_HOPDONG primary key(MAHD),
    Constraint FK_HOPDONG_KHACHHANG foreign key (MAKH) references KHACHHANG(MAKH)
);
create table DUAN(
    MADA varchar(10) not null, 
    MAHD varchar(10) not null, 
    TenDA varchar(10) not null, 
    NgayBatDau datetime not null, 
    NgayKetThuc datetime not null, 
    TienDo varchar(10) not null, 
    Constraint PK_DUAN primary key (MADA), 
    Constraint FK_DUAN_HOPDONG foreign key(MAHD) references HOPDONG(MAHD)
)
create table NHANSU(
    MANV varchar(10) not null, 
    MADA varchar(10) not null, 
    TenNV nvarchar(50) not null,
    ChucVu nvarchar(50) not null, 
    DiaChi nvarchar(50) not null, 
    SDT varchar(10) not null, 
    constraint PK_NHANSU primary key(MANV), 
    constraint FK_NHANSU_DUAN foreign key (MADA) references DUAN(MADA), 
)
create table TAICHINH_DUAN(
    MaTC varchar(10) not null, 
    MaDA varchar(10) not null, 
    constraint PK_TAICHINH_DUAN primary key (MaTC,MaDA),
    constraint FK_TAICHINH_DUAN_TAICHINH foreign key (MATC) references TAICHINH(MATC),
    constraint FK_TAICHINH_DUAN_DUAN foreign key (MADA) references DUAN(MADA),  
)
INSERT INTO KHACHHANG VALUES('A1','Nguyễn Văn A','Nha Trang', 'abc@gmail.com','0123456789'),
							('A2','Nguyễn Văn B','Hải Phòng', 'edf@gmail.com','0123456798'),
							('A3','Nguyễn Văn C','Bình Dương', 'acv@gmail.com','0123456778'),
							('A4','Nguyễn Văn D','Hà Nội', 'ccc@gmail.com','0123456790'),
							('A5','Nguyễn Văn E','Vũng Tàu', 'dcmml@gmail.com','0123456778');
SELECT * FROM KHACHHANG;

INSERT INTO TAICHINH VALUES('TC1','Đại gia A','11111111', '2000000000'),
							('TC2','Đại gia B','22222222', '3000000000'),
							('TC3','Đại gia C','33333333', '4000000000'),
							('TC4','Đại gia D','44444444', '5000000000'),
							('TC5','Đại gia E','55555555', '6000000000'),
							('TC6','Đại gia f','66666666', '7000000000');
SELECT * FROM TAICHINH;

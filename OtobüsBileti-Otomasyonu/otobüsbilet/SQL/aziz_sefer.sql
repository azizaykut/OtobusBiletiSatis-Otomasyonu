USE [master]
GO
/****** Object:  Database [Kayıt]    Script Date: 21.07.2022 22:42:22 ******/
CREATE DATABASE [Kayıt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kayıt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Kayıt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kayıt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Kayıt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Kayıt] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kayıt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kayıt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kayıt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kayıt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kayıt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kayıt] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kayıt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kayıt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kayıt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kayıt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kayıt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kayıt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kayıt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kayıt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kayıt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kayıt] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Kayıt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kayıt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kayıt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kayıt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kayıt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kayıt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kayıt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kayıt] SET RECOVERY FULL 
GO
ALTER DATABASE [Kayıt] SET  MULTI_USER 
GO
ALTER DATABASE [Kayıt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kayıt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kayıt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kayıt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kayıt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kayıt] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kayıt', N'ON'
GO
ALTER DATABASE [Kayıt] SET QUERY_STORE = OFF
GO
USE [Kayıt]
GO
/****** Object:  Table [dbo].[Kullanıcı_Bilgi]    Script Date: 21.07.2022 22:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcı_Bilgi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanıcı_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satın_Al]    Script Date: 21.07.2022 22:42:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satın_Al](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Otobüs] [varchar](200) NULL,
	[Nereden] [varchar](50) NULL,
	[Nereye] [varchar](50) NULL,
	[Fiyat] [varchar](50) NULL,
	[Koltukno] [varchar](50) NULL,
	[Ad] [nvarchar](255) NULL,
	[Soyad] [nvarchar](255) NULL,
	[Telefon] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanıcı_Bilgi] ON 

INSERT [dbo].[Kullanıcı_Bilgi] ([id], [kullanıcı_adi], [sifre]) VALUES (1, N'admin', N'123')
SET IDENTITY_INSERT [dbo].[Kullanıcı_Bilgi] OFF
GO
SET IDENTITY_INSERT [dbo].[Satın_Al] ON 

INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (121, N'Travego', N'BARTIN', N'ZONGULDAK', N'189', N'2', N'İlayda', N'Özaydın', N'(574) 230-4923')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (122, N'Travego', N'IĞDIR', N'KARABÜK', N'140', N'15', N'Can', N'Hanoğlu', N'(548) 293-5423')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (123, N'Travego', N'VAN', N'SAKARYA', N'320', N'7', N'Mehmet', N'Polat', N'(548) 293-5423')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (124, N'Travego', N'YOZGAT', N'KONYA', N'170', N'10', N'Muhammet', N'Değer', N'(548) 293-5423')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (125, N'Travego', N'BATMAN', N'OSMANİYE', N'150', N'19', N'Nuriye', N'Seven', N'(235) 897-2032')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (127, N'Neoplan', N'KAYSERİ', N'SİNOP', N'139', N'18', N'Yusuf', N'Yıldız', N'(570) 235-9256')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (129, N'Setra', N'ERZURUM', N'ANTALYA', N'230', N'5', N'Aziz', N'Aykut', N'(544) 536-3396')
INSERT [dbo].[Satın_Al] ([ID], [Otobüs], [Nereden], [Nereye], [Fiyat], [Koltukno], [Ad], [Soyad], [Telefon]) VALUES (130, N'Setra', N'KONYA', N'KARAMAN', N'276', N'6', N'Furkan', N'Genç', N'(555) 567-4578')
SET IDENTITY_INSERT [dbo].[Satın_Al] OFF
GO
USE [master]
GO
ALTER DATABASE [Kayıt] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 12/06/2021 12:57:04 CH ******/
CREATE DATABASE [QuanLyBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.KHANH\MSSQL\DATA\QuanLyBanHang.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.KHANH\MSSQL\DATA\QuanLyBanHang_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanHang] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[Auth]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Auth](
	[authId] [int] NOT NULL,
	[userId] [int] NULL,
	[password_] [varchar](16) NOT NULL,
	[username] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[authId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[category]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[category](
	[categoryId] [int] NOT NULL,
	[name] [varchar](255) NULL,
	[productId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[filter]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filter](
	[tagId] [int] NULL,
	[productId] [int] NULL,
	[fiterId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[fiterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[history]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[history](
	[historyId] [int] NOT NULL,
	[userId] [int] NULL,
	[action] [varchar](max) NULL,
	[time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[historyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[order_]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_](
	[orderId] [int] NOT NULL,
	[userId] [int] NULL,
	[productId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[productId] [int] NOT NULL,
	[name] [varchar](max) NULL,
	[image_] [image] NULL,
	[prices] [int] NULL,
	[detail] [varchar](max) NULL,
	[categoryId] [int] NULL,
	[userId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[productId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tags]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tags](
	[tagId] [int] NOT NULL,
	[name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[tagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/06/2021 12:57:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Email] [varchar](50) NULL,
	[UserName] [varchar](255) NULL,
	[Address_] [varchar](255) NULL,
	[Sdt] [varchar](10) NULL,
	[Avatar] [image] NULL,
	[Desc_] [varchar](max) NULL,
	[userId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (1, 1, N'12345678', N'khanh')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (2, 2, N'admin', N'khanhadmin')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (3, 3, N'13122002', N'khanh1312')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (4, 4, N'admin', N'khanhsacas')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (5, 5, N'admin', N'test')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (6, 6, N'admin', N'acbakjscbkja')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (7, 7, N'admin', N'khanhaccssc')
INSERT [dbo].[Auth] ([authId], [userId], [password_], [username]) VALUES (8, 8, N'admin', N'knascbac')
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (N'khanh13122002@gmail.com', N'dangkhanh', NULL, NULL, NULL, N'khanh đ?p trai nh?t qu? đ?t', 1)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'khanhadmin', NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'khanh1312', NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'khanhsacas', NULL, NULL, NULL, NULL, 4)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'test', NULL, NULL, NULL, NULL, 5)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'acbakjscbkja', NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'khanhaccssc', NULL, NULL, NULL, NULL, 7)
INSERT [dbo].[Users] ([Email], [UserName], [Address_], [Sdt], [Avatar], [Desc_], [userId]) VALUES (NULL, N'knascbac', NULL, NULL, NULL, NULL, 8)
ALTER TABLE [dbo].[Auth]  WITH CHECK ADD  CONSTRAINT [FK_Auth_Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[Auth] CHECK CONSTRAINT [FK_Auth_Users]
GO
ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_products] FOREIGN KEY([productId])
REFERENCES [dbo].[products] ([productId])
GO
ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_products]
GO
ALTER TABLE [dbo].[filter]  WITH CHECK ADD  CONSTRAINT [FK_filter_products] FOREIGN KEY([productId])
REFERENCES [dbo].[products] ([productId])
GO
ALTER TABLE [dbo].[filter] CHECK CONSTRAINT [FK_filter_products]
GO
ALTER TABLE [dbo].[filter]  WITH CHECK ADD  CONSTRAINT [FK_filter_tags] FOREIGN KEY([tagId])
REFERENCES [dbo].[tags] ([tagId])
GO
ALTER TABLE [dbo].[filter] CHECK CONSTRAINT [FK_filter_tags]
GO
ALTER TABLE [dbo].[order_]  WITH CHECK ADD  CONSTRAINT [FK_order__products] FOREIGN KEY([productId])
REFERENCES [dbo].[products] ([productId])
GO
ALTER TABLE [dbo].[order_] CHECK CONSTRAINT [FK_order__products]
GO
ALTER TABLE [dbo].[order_]  WITH CHECK ADD  CONSTRAINT [FK_order__Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[order_] CHECK CONSTRAINT [FK_order__Users]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_category] FOREIGN KEY([categoryId])
REFERENCES [dbo].[category] ([categoryId])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_category]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([userId])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_Users]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO

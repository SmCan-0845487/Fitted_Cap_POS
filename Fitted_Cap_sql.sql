USE [master]
GO
/****** Object:  Database [Project_Person]    Script Date: 2024/11/13 下午 04:22:59 ******/
CREATE DATABASE [Project_Person]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_Person', FILENAME = N'D:\SQL Server 2022 Developer Edition\MSSQL16.MSSQLSERVER\MSSQL\DATA\Project_Person.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_Person_log', FILENAME = N'D:\SQL Server 2022 Developer Edition\MSSQL16.MSSQLSERVER\MSSQL\DATA\Project_Person_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Project_Person] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_Person].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_Person] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_Person] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_Person] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_Person] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_Person] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_Person] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_Person] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_Person] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_Person] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_Person] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_Person] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_Person] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_Person] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_Person] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_Person] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project_Person] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_Person] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_Person] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_Person] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_Person] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_Person] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_Person] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_Person] SET RECOVERY FULL 
GO
ALTER DATABASE [Project_Person] SET  MULTI_USER 
GO
ALTER DATABASE [Project_Person] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_Person] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_Person] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_Person] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_Person] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project_Person] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project_Person', N'ON'
GO
ALTER DATABASE [Project_Person] SET QUERY_STORE = ON
GO
ALTER DATABASE [Project_Person] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Project_Person]
GO
/****** Object:  Table [dbo].[訂單]    Script Date: 2024/11/13 下午 04:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[訂單](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[訂單編號] [nvarchar](50) NOT NULL,
	[下單會員id] [int] NOT NULL,
	[訂單狀態] [nvarchar](50) NULL,
	[下單時間] [nvarchar](50) NULL,
	[下貨地點] [nvarchar](100) NULL,
	[訂單總價] [nvarchar](50) NULL,
 CONSTRAINT [PK_訂單] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[訂單詳細資訊]    Script Date: 2024/11/13 下午 04:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[訂單詳細資訊](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[訂單編號] [nvarchar](50) NOT NULL,
	[下單會員id] [int] NOT NULL,
	[隊伍] [nvarchar](50) NULL,
	[品項名] [nvarchar](50) NULL,
	[顏色] [nvarchar](50) NULL,
	[尺寸] [nvarchar](10) NULL,
	[單價] [int] NULL,
	[數量] [int] NULL,
	[單品總價] [int] NULL,
 CONSTRAINT [PK_訂單詳細資料] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[帽子庫存]    Script Date: 2024/11/13 下午 04:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[帽子庫存](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[team] [nvarchar](50) NULL,
	[color] [nvarchar](50) NULL,
	[price] [int] NULL,
	[size] [nvarchar](50) NULL,
	[stock] [int] NULL,
 CONSTRAINT [PK_商品目錄] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[帽子圖檔]    Script Date: 2024/11/13 下午 04:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[帽子圖檔](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[team] [nvarchar](50) NULL,
	[color] [nvarchar](50) NULL,
	[price] [int] NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_商品圖檔] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[會員資料]    Script Date: 2024/11/13 下午 04:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[會員資料](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[生日] [date] NULL,
	[登入密碼] [nvarchar](50) NULL,
	[權限] [int] NULL,
 CONSTRAINT [PK_會員資料] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[訂單] ON 

INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (5, N'2408101529163681', 16, N'已完成', N'2024/8/10 下午 03:29:16', N'巨龍門市', N'11085')
INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (6, N'2408101632056773', 16, N'已完成', N'2024/8/10 下午 04:32:05', N'廣洽門市', N'5655')
INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (9, N'2408101708486826', 16, N'未出貨', N'2024/8/11 下午 05:08:48', N'廣洽門市', N'10065')
INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (10, N'2408101709112672', 16, N'未出貨', N'2024/8/11 下午 05:09:11', N'左營博愛店', N'11950')
INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (11, N'2408102039204663', 16, N'已完成', N'2024/8/12 下午 08:39:20', N'逢吉門市', N'4005')
INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (13, N'2408101708159271', 16, N'已完成', N'2024/8/13 上午 01:21:20', N'巨龍門市', N'5985')
INSERT [dbo].[訂單] ([id], [訂單編號], [下單會員id], [訂單狀態], [下單時間], [下貨地點], [訂單總價]) VALUES (15, N'2408162334268344', 16, N'已完成', N'2024/8/16 下午 11:34:26', N'左營博愛店', N'10860')
SET IDENTITY_INSERT [dbo].[訂單] OFF
GO
SET IDENTITY_INSERT [dbo].[訂單詳細資訊] ON 

INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (5, N'2408101529163681', 16, N'勇士', N'1995 World Series Wool', N'Black', N'7', 2040, 3, 6120)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (6, N'2408101529163681', 16, N'太空人', N'Raceway', N'Black', N'7', 2460, 2, 4920)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (7, N'2408101632056773', 16, N'勇士', N'Color Brush', N'Blue', N'7 1/8', 1870, 3, 5610)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (9, N'2408101708159271', 16, N'勇士', N'Cord', N'Brown', N'6 7/8', 1980, 3, 5940)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (10, N'2408101708486826', 16, N'勇士', N'Cord', N'Brown', N'6 7/8', 1980, 3, 5940)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (11, N'2408101708486826', 16, N'太空人', N'Camo Fill', N'Beige', N'7', 2040, 2, 4080)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (12, N'2408101709112672', 16, N'勇士', N'Cord', N'Brown', N'6 7/8', 1980, 3, 5940)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (13, N'2408101709112672', 16, N'太空人', N'Camo Fill', N'Beige', N'7', 2040, 2, 4080)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (14, N'2408101709112672', 16, N'勇士', N'Color Brush', N'Blue', N'8', 1870, 1, 1870)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (15, N'2408102039204663', 16, N'洋基', N'1988 World Series', N'Red', N'7', 1980, 2, 3960)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (17, N'2408162201031472', 17, N'勇士', N'1995 World Series Wool', N'Black', N'7', 2040, 3, 6120)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (18, N'2408162201031472', 17, N'勇士', N'Color Brush', N'Blue', N'7', 1870, 5, 9350)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (19, N'2408162201031472', 17, N'太空人', N'Farm Team', N'Red', N'7', 1560, 1, 1560)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (20, N'2408162334268344', 16, N'勇士', N'1995 World Series Wool', N'Black', N'7', 2040, 3, 6120)
INSERT [dbo].[訂單詳細資訊] ([id], [訂單編號], [下單會員id], [隊伍], [品項名], [顏色], [尺寸], [單價], [數量], [單品總價]) VALUES (21, N'2408162334268344', 16, N'道奇', N'Color Pack Earthy Brown', N'Brown', N'7', 1560, 3, 4680)
SET IDENTITY_INSERT [dbo].[訂單詳細資訊] OFF
GO
SET IDENTITY_INSERT [dbo].[帽子庫存] ON 

INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (1, N'Color Brush', N'勇士', N'Blue', 1870, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (2, N'Color Brush', N'勇士', N'Blue', 1870, N'7', 9)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (3, N'Color Brush', N'勇士', N'Blue', 1870, N'7 1/8', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (4, N'Color Brush', N'勇士', N'Blue', 1870, N'7 1/4', 5)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (5, N'Color Brush', N'勇士', N'Blue', 1870, N'7 3/8', 9)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (6, N'Color Brush', N'勇士', N'Blue', 1870, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (7, N'Color Brush', N'勇士', N'Blue', 1870, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (8, N'Color Brush', N'勇士', N'Blue', 1870, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (9, N'Color Brush', N'勇士', N'Blue', 1870, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (10, N'Color Brush', N'勇士', N'Blue', 1870, N'8', 9)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (11, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'6 7/8', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (12, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7', 2)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (13, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (14, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (15, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (16, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (17, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (18, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (19, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (20, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (21, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (22, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7', 7)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (23, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (24, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (25, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (26, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (27, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (28, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (29, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (30, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (31, N'Cardinal', N'道奇', N'Red', 1860, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (32, N'Cardinal', N'道奇', N'Red', 1860, N'7', 6)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (33, N'Cardinal', N'道奇', N'Red', 1860, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (34, N'Cardinal', N'道奇', N'Red', 1860, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (35, N'Cardinal', N'道奇', N'Red', 1860, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (36, N'Cardinal', N'道奇', N'Red', 1860, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (37, N'Cardinal', N'道奇', N'Red', 1860, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (38, N'Cardinal', N'道奇', N'Red', 1860, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (39, N'Cardinal', N'道奇', N'Red', 1860, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (40, N'Cardinal', N'道奇', N'Red', 1860, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (41, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (42, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7', 5)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (43, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (44, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (45, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (46, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (47, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (48, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (49, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (50, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (51, N'1988 World Series', N'洋基', N'Red', 1980, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (52, N'1988 World Series', N'洋基', N'Red', 1980, N'7', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (53, N'1988 World Series', N'洋基', N'Red', 1980, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (54, N'1988 World Series', N'洋基', N'Red', 1980, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (55, N'1988 World Series', N'洋基', N'Red', 1980, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (56, N'1988 World Series', N'洋基', N'Red', 1980, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (57, N'1988 World Series', N'洋基', N'Red', 1980, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (58, N'1988 World Series', N'洋基', N'Red', 1980, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (59, N'1988 World Series', N'洋基', N'Red', 1980, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (60, N'1988 World Series', N'洋基', N'Red', 1980, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (61, N'Raceway', N'太空人', N'Black', 2460, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (62, N'Raceway', N'太空人', N'Black', 2460, N'7', 3)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (63, N'Raceway', N'太空人', N'Black', 2460, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (64, N'Raceway', N'太空人', N'Black', 2460, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (65, N'Raceway', N'太空人', N'Black', 2460, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (66, N'Raceway', N'太空人', N'Black', 2460, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (67, N'Raceway', N'太空人', N'Black', 2460, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (68, N'Raceway', N'太空人', N'Black', 2460, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (69, N'Raceway', N'太空人', N'Black', 2460, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (70, N'Raceway', N'太空人', N'Black', 2460, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (71, N'Camo Fill', N'太空人', N'Beige', 2040, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (72, N'Camo Fill', N'太空人', N'Beige', 2040, N'7', 2)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (73, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (74, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (75, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (76, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (77, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (78, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (79, N'Camo Fill', N'太空人', N'Beige', 2040, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (80, N'Camo Fill', N'太空人', N'Beige', 2040, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (81, N'Farm Team', N'太空人', N'Red', 1560, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (82, N'Farm Team', N'太空人', N'Red', 1560, N'7', 1)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (83, N'Farm Team', N'太空人', N'Red', 1560, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (84, N'Farm Team', N'太空人', N'Red', 1560, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (85, N'Farm Team', N'太空人', N'Red', 1560, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (86, N'Farm Team', N'太空人', N'Red', 1560, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (87, N'Farm Team', N'太空人', N'Red', 1560, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (88, N'Farm Team', N'太空人', N'Red', 1560, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (89, N'Farm Team', N'太空人', N'Red', 1560, N'7 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (90, N'Farm Team', N'太空人', N'Red', 1560, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (94, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'6 7/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (95, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7', 1)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (96, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (97, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (98, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 3/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (99, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (100, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 5/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (101, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (102, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'7 7/8', 0)
GO
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (103, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (108, N'Cord', N'勇士', N'Brown', 1980, N'6 7/8', 6)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (109, N'Cord', N'勇士', N'Brown', 1980, N'7', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (110, N'Cord', N'勇士', N'Brown', 1980, N'7 1/8', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (111, N'Cord', N'勇士', N'Brown', 1980, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (112, N'Cord', N'勇士', N'Brown', 1980, N'7 3/8', 1)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (113, N'Cord', N'勇士', N'Brown', 1980, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (114, N'Cord', N'勇士', N'Brown', 1980, N'7 5/8', 2)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (115, N'Cord', N'勇士', N'Brown', 1980, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (116, N'Cord', N'勇士', N'Brown', 1980, N'7 7/8', 5)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (117, N'Cord', N'勇士', N'Brown', 1980, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (118, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'6 7/8', 9)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (119, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (120, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 1/8', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (121, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (122, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 3/8', 1)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (123, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 1/2', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (124, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 5/8', 2)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (125, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 3/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (126, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'7 7/8', 5)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (127, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (128, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'6 7/8', 5)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (129, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (130, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 1/8', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (131, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 1/4', 0)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (132, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 3/8', 2)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (133, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 1/2', 3)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (134, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 5/8', 8)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (135, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 3/4', 7)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (136, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'7 7/8', 4)
INSERT [dbo].[帽子庫存] ([id], [name], [team], [color], [price], [size], [stock]) VALUES (137, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'8', 0)
SET IDENTITY_INSERT [dbo].[帽子庫存] OFF
GO
SET IDENTITY_INSERT [dbo].[帽子圖檔] ON 

INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (1, N'Color Brush', N'勇士', N'Blue', 1860, N'勇士1.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (2, N'1995 World Series Wool', N'勇士', N'Black', 2040, N'勇士2.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (3, N'Patrick''s Day 2024', N'道奇', N'Green', 1560, N'道奇2.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (4, N'Cardinal', N'道奇', N'Red', 1860, N'道奇1.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (5, N'2024 Clubhouse Stone', N'洋基', N'White', 2040, N'洋基1.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (6, N'1988 World Series', N'洋基', N'Red', 1980, N'洋基2.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (7, N'Raceway', N'太空人', N'Black', 2460, N'太空人3.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (8, N'Camo Fill', N'太空人', N'Beige', 2040, N'太空人1.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (9, N'Farm Team', N'太空人', N'Red', 1560, N'太空人2.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (10, N'Color Pack Earthy Brown', N'道奇', N'Brown', 1560, N'道奇3.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (17, N'Cord', N'勇士', N'Brown', 1980, N'2408071428515369.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (18, N'Just Caps Rose Flower', N'響尾蛇', N'Red', 2680, N'響尾蛇1.png')
INSERT [dbo].[帽子圖檔] ([id], [name], [team], [color], [price], [pimage]) VALUES (19, N'Big League Chew', N'響尾蛇', N'Purple', 1680, N'響尾蛇2.png')
SET IDENTITY_INSERT [dbo].[帽子圖檔] OFF
GO
SET IDENTITY_INSERT [dbo].[會員資料] ON 

INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (1, N'李明', N'0912345678', N'台北市中正區忠孝東路一段100號', N'liming@example.com', CAST(N'1985-01-15' AS Date), N'A3B2C1', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (2, N'王小芳', N'0921234567', N'高雄市苓雅區五福一路300號 ', N'zhangjianguo@example.com', CAST(N'1978-12-02' AS Date), N'F6G5H4', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (3, N'張建國', N'0933456789', N'台中市西屯區台灣大道二段200號', N'wangxiaofang@example.com', CAST(N'1990-05-20' AS Date), N'X1Y2Z3', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (4, N'陳美玲', N'0944567890', N'新北市板橋區文化路四段400號', N'chenmeiling@example.com', CAST(N'1988-07-07' AS Date), N'P8Q7R6', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (5, N'劉強', N'0955678901', N'桃園市中壢區中山路500號', N'liuqiang@example.com', CAST(N'1982-03-22' AS Date), N'L4M3N2', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (6, N'何欣怡', N'0966789012', N'台南市永康區中華路600號', N'hexinyi@example.com', CAST(N'1995-11-11' AS Date), N'J5K4L3', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (7, N'周志強', N'0977890123', N'新竹市東區光復路700號', N'zhouzhiqiang@example.com', CAST(N'1975-08-08' AS Date), N'E1F2G3', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (9, N'馬麗', N'0999012345', N'台中市北區北屯路900號', N'mali@example.com', CAST(N'1980-04-14' AS Date), N'D3E4F5', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (11, N'菲道爾', N'0931558430', N'嘉義縣金北區羅斯福路219號', N'qwer@gmail.com', CAST(N'2000-09-17' AS Date), N'H2I1J3', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (13, N'店員', N'0912077385', N'台中市龍井區忠和里中央路三段190號', N'e6797', CAST(N'2000-09-17' AS Date), N'89er', 1)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (14, N'老闆', N'0000', N'資展國際', N'777', CAST(N'2024-07-30' AS Date), N'777', 2)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (15, N'竣貽', N'0955555555', N'高雄市鹽埕區', N'456@gmail.com', CAST(N'2024-07-31' AS Date), N'55555', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (16, N'冠廷', N'0912077386', N'高雄市鼓山區鼓山一路', N'a@gmail.com', CAST(N'2000-09-17' AS Date), N'111', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (17, N'王小明', N'0977777777', N'台中市西屯區烈美街3弄5號', N'777@gmail.com', CAST(N'2024-08-16' AS Date), N'7777777', 0)
INSERT [dbo].[會員資料] ([id], [姓名], [電話], [地址], [email], [生日], [登入密碼], [權限]) VALUES (21, N'林小冠', N'0911111111', N'台中市西屯區烈美街3弄16號', N'w@gmail.com', CAST(N'2024-08-20' AS Date), N'111', 0)
SET IDENTITY_INSERT [dbo].[會員資料] OFF
GO
USE [master]
GO
ALTER DATABASE [Project_Person] SET  READ_WRITE 
GO

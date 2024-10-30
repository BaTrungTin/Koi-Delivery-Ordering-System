USE [Quản Lý]
GO
/****** Object:  Table [dbo].[FeedBack]    Script Date: 31-10-2024 12:18:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedBack](
	[MaKH] [int] NOT NULL,
	[MaDH] [int] NOT NULL,
	[MaRate] [nvarchar](50) NULL,
	[Rating] [int] NULL,
	[Comment] [nchar](10) NULL,
	[CreDate] [datetime] NULL,
	[CreBy] [nchar](10) NULL,
 CONSTRAINT [PK_FeedBack] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 31-10-2024 12:18:04 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NULL,
	[TenKH] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DienThoai] [int] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[OrderTime] [datetime] NULL,
	[OrderBy] [nvarchar](250) NULL,
	[LsOrder] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

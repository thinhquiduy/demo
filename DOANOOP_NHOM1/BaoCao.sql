USE [BangBaocao]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 11/12/2017 6:10:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[TenCN] [nvarchar](max) NULL,
	[SoLuongDonHang] [int] NULL,
	[SoLuong] [int] NULL,
	[NgayThangQuiNam] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

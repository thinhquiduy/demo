USE [DoanhThu]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 11/2/2017 7:26:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Tên Chi Nhánh] [nchar](10) NULL,
	[Số lượng đơn hàng] [int] NULL,
	[Số lượng] [int] NULL,
	[Tổng chi phí] [int] NULL
) ON [PRIMARY]

GO

USE [DSMonAn]
GO
/****** Object:  Table [dbo].[DSMonAn]    Script Date: 11/5/2017 7:01:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSMonAn](
	[Tên] [nvarchar](max) NULL,
	[Giá] [int] NULL,
	[Ghi Chú] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [CSVApplication]
GO
/****** Object:  Table [dbo].[DataUsers]    Script Date: 14/01/2023 11:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Age] [int] NOT NULL,
	[City] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DataUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

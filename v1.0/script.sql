USE [Projekat]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 4/15/2019 11:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] NOT NULL,
	[Account_Type] [bit] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 4/15/2019 11:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Workers](
	[ID] [int] NOT NULL,
	[Name] [varchar](25) NOT NULL,
	[Surname] [varchar](25) NULL,
	[Email] [varchar](50) NOT NULL,
	[Birth] [date] NULL,
	[Username] [varchar](50) NOT NULL,
	[Possition] [varchar](50) NOT NULL,
	[Phone] [char](11) NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Workers] FOREIGN KEY([ID])
REFERENCES [dbo].[Workers] ([ID])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Workers]
GO

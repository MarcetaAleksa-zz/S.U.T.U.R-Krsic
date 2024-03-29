USE [S.U.T.U.R_Krsic]
GO
/****** Object:  Table [dbo].[log_korisnici]    Script Date: 2.12.2019. 19:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log_korisnici](
	[Nadlezni] [varchar](50) NOT NULL,
	[Korisnik] [varchar](50) NOT NULL,
	[Datum] [date] NOT NULL,
	[Unos] [bit] NOT NULL,
 CONSTRAINT [PK_log_korisnici] PRIMARY KEY CLUSTERED 
(
	[Nadlezni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[log_kupovina]    Script Date: 2.12.2019. 19:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log_kupovina](
	[Kartica] [varchar](50) NOT NULL,
	[Iznos] [smallmoney] NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[broj_kartice] [varchar](16) NOT NULL,
	[Kupovina] [bit] NOT NULL,
	[Datum] [date] NOT NULL,
 CONSTRAINT [PK_log_kupovina_1] PRIMARY KEY CLUSTERED 
(
	[broj_kartice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[log_prijavljivanje]    Script Date: 2.12.2019. 19:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log_prijavljivanje](
	[Korisnik] [varchar](50) NOT NULL,
	[Lozinka] [varchar](35) NOT NULL,
	[Datum] [date] NOT NULL,
	[Prijava] [bit] NOT NULL,
 CONSTRAINT [PK_log_prijavljivanje] PRIMARY KEY CLUSTERED 
(
	[Korisnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

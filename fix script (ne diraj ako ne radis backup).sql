USE [master]
GO
/****** Object:  Database [S.U.T.U.R_Krsic]    Script Date: 9/13/2019 12:10:40 AM ******/
CREATE DATABASE [S.U.T.U.R_Krsic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'S.U.T.U.R_Krsic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\S.U.T.U.R_Krsic.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'S.U.T.U.R_Krsic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\S.U.T.U.R_Krsic_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [S.U.T.U.R_Krsic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET ARITHABORT OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET  MULTI_USER 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET DELAYED_DURABILITY = DISABLED 
GO
USE [S.U.T.U.R_Krsic]
GO
/****** Object:  Table [dbo].[korisnici]    Script Date: 9/13/2019 12:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[korisnici](
	[korisnicki_id] [varchar](50) NOT NULL,
	[ime_korisnika] [varchar](50) NULL,
	[prezime_korisnika] [varchar](50) NULL,
	[lozinka] [varchar](35) NOT NULL,
	[adresa_stanovanja] [varchar](60) NULL,
	[broj_telefona] [varchar](12) NULL,
	[email] [varchar](50) NULL,
	[datum_rodjenja] [date] NULL,
	[pol] [varchar](6) NULL,
	[radna_pozicija] [smallint] NOT NULL,
 CONSTRAINT [PK_korisnici] PRIMARY KEY CLUSTERED 
(
	[korisnicki_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kreditne_kartice]    Script Date: 9/13/2019 12:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kreditne_kartice](
	[tip_kartice] [varchar](50) NOT NULL,
	[broj_kartice] [varchar](16) NOT NULL,
	[ime_vlasnika] [varchar](50) NOT NULL,
	[prezime_vlasnika] [varchar](50) NOT NULL,
	[datum_isteka] [varchar](5) NOT NULL,
	[CVV] [int] NOT NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[CVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[naziv_opreme]    Script Date: 9/13/2019 12:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[naziv_opreme](
	[id_opreme] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](9) NULL,
 CONSTRAINT [PK_naziv_opreme] PRIMARY KEY CLUSTERED 
(
	[id_opreme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[oprema]    Script Date: 9/13/2019 12:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[oprema](
	[id_robe] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](20) NOT NULL,
	[kolicina] [smallint] NOT NULL,
	[tip_robe] [int] NOT NULL,
	[cijena] [smallmoney] NOT NULL,
 CONSTRAINT [PK_oprema] PRIMARY KEY CLUSTERED 
(
	[id_robe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pozicija]    Script Date: 9/13/2019 12:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pozicija](
	[pozicija_id] [smallint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ime_pozicije] [char](15) NOT NULL,
	[radni_sati_po_danu] [smallint] NOT NULL,
	[satnica] [smallint] NOT NULL,
 CONSTRAINT [PK_pozicija] PRIMARY KEY CLUSTERED 
(
	[pozicija_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stanje_racuna]    Script Date: 9/13/2019 12:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stanje_racuna](
	[CVV] [int] NOT NULL,
	[nalog] [varchar](50) NOT NULL,
	[banka] [varchar](50) NOT NULL,
	[kreditna_kartica] [varchar](50) NOT NULL,
	[novcani_iznos] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Account_Balance] PRIMARY KEY CLUSTERED 
(
	[CVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[korisnici]  WITH CHECK ADD  CONSTRAINT [FK_korisnici_korisnici] FOREIGN KEY([radna_pozicija])
REFERENCES [dbo].[pozicija] ([pozicija_id])
GO
ALTER TABLE [dbo].[korisnici] CHECK CONSTRAINT [FK_korisnici_korisnici]
GO
ALTER TABLE [dbo].[oprema]  WITH CHECK ADD  CONSTRAINT [FK_oprema_naziv_opreme] FOREIGN KEY([tip_robe])
REFERENCES [dbo].[naziv_opreme] ([id_opreme])
GO
ALTER TABLE [dbo].[oprema] CHECK CONSTRAINT [FK_oprema_naziv_opreme]
GO
ALTER TABLE [dbo].[stanje_racuna]  WITH CHECK ADD  CONSTRAINT [FK_stanje_racuna_kreditne_kartice] FOREIGN KEY([CVV])
REFERENCES [dbo].[kreditne_kartice] ([CVV])
GO
ALTER TABLE [dbo].[stanje_racuna] CHECK CONSTRAINT [FK_stanje_racuna_kreditne_kartice]
GO
USE [master]
GO
ALTER DATABASE [S.U.T.U.R_Krsic] SET  READ_WRITE 
GO

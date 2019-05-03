USE [master]
GO
/****** Object:  Database [Payment]    Script Date: 5/3/2019 2:29:15 PM ******/
CREATE DATABASE [Payment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Payment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Payment.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Payment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Payment_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Payment] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Payment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Payment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Payment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Payment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Payment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Payment] SET ARITHABORT OFF 
GO
ALTER DATABASE [Payment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Payment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Payment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Payment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Payment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Payment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Payment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Payment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Payment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Payment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Payment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Payment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Payment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Payment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Payment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Payment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Payment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Payment] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Payment] SET  MULTI_USER 
GO
ALTER DATABASE [Payment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Payment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Payment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Payment] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Payment] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Payment]
GO
/****** Object:  Table [dbo].[Account_Balance]    Script Date: 5/3/2019 2:29:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account_Balance](
	[CVV] [int] NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[Bank] [varchar](50) NOT NULL,
	[Card] [varchar](50) NOT NULL,
	[Money] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Account_Balance] PRIMARY KEY CLUSTERED 
(
	[CVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CreditCard]    Script Date: 5/3/2019 2:29:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CreditCard](
	[CardType] [varchar](50) NOT NULL,
	[CardNumber] [varchar](16) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[ExpirationDate] [varchar](5) NOT NULL,
	[CVV] [int] NOT NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[CVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (141, N'Emmanuel.H', N'Principal Bank Inc.', N'AmericanExpress', 150.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (310, N'Conner.S', N'Gold Credit Bancshares', N'MasterCard', 2500.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (372, N'Saige.P', N'Grand Market Trust', N'VisaCard', 269.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (391, N'Amber.L', N'Grand Market Trust', N'VisaCard', 1750.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (475, N'Madison.W', N'Principal Bank Inc.', N'AmericanExpress', 1562.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (482, N'Noah.C', N'Grand Market Trust', N'VisaCard', 1853.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (549, N'Ryleigh.R', N'Gold Credit Bancshares', N'MasterCard', 7862.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (567, N'Aditya.J', N'Gold Credit Bancshares', N'MasterCard', -50.0000)
INSERT [dbo].[Account_Balance] ([CVV], [Account], [Bank], [Card], [Money]) VALUES (674, N'Brooklyn.L', N'Principal Bank Inc.', N'AmericanExpress', -850.0000)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'AmericanExpress', N'377333620264515', N'Emmanuel', N'Harris', N'12/25', 141)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'MasterCard', N'5551764569770236', N'Conner', N'Salas', N'02/28', 310)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'VisaCard', N'4477503358419181', N'Saige', N'Parker', N'06/19', 372)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'VisaCard', N'4740813614701251', N'Amber', N'Lewis', N'05/23', 391)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'AmericanExpress', N'345456838433371', N'Madison', N'Walker', N'04/27', 475)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'VisaCard', N'4089042164598698', N'Noah', N'Clark', N'01/28', 482)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'MasterCard', N'5246997400974028', N'Ryleigh', N'Robinson', N'02/28', 549)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'MasterCard', N'5241990319676045', N'Aditya', N'Jackson', N'02/24', 567)
INSERT [dbo].[CreditCard] ([CardType], [CardNumber], [FirstName], [LastName], [ExpirationDate], [CVV]) VALUES (N'AmericanExpress', N'378213882068888', N'Brooklyn', N'Lee', N'06/24', 674)
ALTER TABLE [dbo].[Account_Balance]  WITH CHECK ADD  CONSTRAINT [FK_Account_Balance_CreditCard] FOREIGN KEY([CVV])
REFERENCES [dbo].[CreditCard] ([CVV])
GO
ALTER TABLE [dbo].[Account_Balance] CHECK CONSTRAINT [FK_Account_Balance_CreditCard]
GO
USE [master]
GO
ALTER DATABASE [Payment] SET  READ_WRITE 
GO

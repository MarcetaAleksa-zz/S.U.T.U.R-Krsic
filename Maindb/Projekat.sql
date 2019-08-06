USE [master]
GO
/****** Object:  Database [Projekat]    Script Date: 5/8/2019 8:28:42 PM ******/
CREATE DATABASE [Projekat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Projekat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Projekat.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Projekat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Projekat_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Projekat] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Projekat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Projekat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Projekat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Projekat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Projekat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Projekat] SET ARITHABORT OFF 
GO
ALTER DATABASE [Projekat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Projekat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Projekat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Projekat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Projekat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Projekat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Projekat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Projekat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Projekat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Projekat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Projekat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Projekat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Projekat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Projekat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Projekat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Projekat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Projekat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Projekat] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Projekat] SET  MULTI_USER 
GO
ALTER DATABASE [Projekat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Projekat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Projekat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Projekat] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Projekat] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Projekat]
GO
/****** Object:  UserDefinedFunction [dbo].[GetDaysInMonth]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetDaysInMonth]
(
    @TestDT datetime
)
RETURNS INT
AS
BEGIN

    DECLARE @Result int 
    DECLARE @MonthNo int

    Set @MonthNo = datepart(m,@TestDT)

    Set @Result = 
    case @MonthNo
        when  1 then 31
        when  2 then 
            case 
                when dbo.IsLeapYear(datepart(yyyy,@TestDT)) = 0
                then 28
                else 29
            end
        when  3 then 31
        when  4 then 30
        when  5 then 31
        when  6 then 30
        when  7 then 31
        when  8 then 31
        when  9 then 30 
        when 10 then 31
        when 11 then 30 
        when 12 then 31
    end

    RETURN @Result
END

GO
/****** Object:  UserDefinedFunction [dbo].[IsLeapYear]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[IsLeapYear]
(
    @TestYear int
)
RETURNS bit
AS
BEGIN
    declare @Result bit
    set @Result = 
    cast(
        case when ((@TestYear % 4 = 0) and (@testYear % 100 != 0)) or (@TestYear % 400 = 0)
        then 1
        else 0
        end
    as bit )
    return @Result
END

GO
/****** Object:  UserDefinedFunction [dbo].[ufn_GetDaysInMonth]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufn_GetDaysInMonth] ( @pDate    DATETIME )

RETURNS INT
AS
BEGIN

    SET @pDate = CONVERT(VARCHAR(10), @pDate, 101)
    SET @pDate = @pDate - DAY(@pDate) + 1

    RETURN DATEDIFF(DD, @pDate, DATEADD(MM, 1, @pDate))
END


GO
/****** Object:  Table [dbo].[Login]    Script Date: 5/8/2019 8:28:42 PM ******/
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
/****** Object:  Table [dbo].[Month]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Month](
	[MonthID] [int] NOT NULL,
	[Month] [varchar](50) NOT NULL,
	[DaysInMonth] [int] NOT NULL,
 CONSTRAINT [PK_Month] PRIMARY KEY CLUSTERED 
(
	[MonthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Position]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Position](
	[NameOfPosition] [varchar](50) NOT NULL,
	[SalaryPerhour] [int] NOT NULL,
	[WorkHoursPerDay] [int] NOT NULL,
	[BaseSalary]  AS ([WorkHoursPerDay]*[SalaryPerhour]),
	[WorkDaysInWeek] [smallint] NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[NameOfPosition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[WorkerID] [int] NOT NULL,
	[MonthID] [int] NOT NULL,
	[WorkDays] [int] NULL,
	[Salary] [int] NULL,
	[DaysWorked] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Workers]    Script Date: 5/8/2019 8:28:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Workers](
	[ID] [int] NOT NULL CONSTRAINT [DF_Workers_ID]  DEFAULT ((1)),
	[Name] [varchar](25) NOT NULL,
	[Surname] [varchar](25) NULL,
	[Email] [varchar](50) NOT NULL,
	[Birth] [date] NULL,
	[Username] [varchar](50) NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[Phone] [char](11) NULL,
	[Gender] [varchar](6) NOT NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (1, 1, N'Aleksa', N'C53E479B03B3220D3D56DA88C4CACE20')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (2, 1, N'Aleksandar', N'C53E479B03B3220D3D56DA88C4CACE20')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (3, 0, N'Joe', N'292C36B86220435947D492794CBCA50F')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (4, 0, N'Nick', N'425AAEEBE7B0DDB18E1AC0FFC59FA62A')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (5, 1, N'Edvin', N'E2F60289C2C94201A4090B20B8CD5822')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (6, 1, N'Rickon', N'26A10E82C687BFBA02AFF0F59C42AC6C')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (7, 1, N'Severick', N'FDC3C398D67615C64F200910C45C2D98')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (8, 0, N'Jon Snow', N'1DA2427004FF563B076DA4AEA6DF8F98')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (9, 0, N'Nikolaj', N'831116ADDD26FF4C21E2720CBB82DFBA')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (10, 0, N'Simens', N'0FC3A668B8F1945C10694EAEF5D2F797')
INSERT [dbo].[Login] ([ID], [Account_Type], [Username], [Password]) VALUES (11, 0, N'NNikolica', N'0568B6CD0670A95948B390B9412E84A7')
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (1, N'January', 31)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (2, N'February', 28)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (3, N'March', 31)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (4, N'April', 30)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (5, N'May', 31)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (6, N'June', 30)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (7, N'July', 31)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (8, N'August', 31)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (9, N'September', 30)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (10, N'October', 31)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (11, N'November', 30)
INSERT [dbo].[Month] ([MonthID], [Month], [DaysInMonth]) VALUES (12, N'December', 31)
INSERT [dbo].[Position] ([Name], [SalaryPerhour], [WorkHoursPerDay]) VALUES (N'Accounting', 27, 8)
INSERT [dbo].[Position] ([Name], [SalaryPerhour], [WorkHoursPerDay]) VALUES (N'Administrator', 16, 8)
INSERT [dbo].[Position] ([Name], [SalaryPerhour], [WorkHoursPerDay]) VALUES (N'Driver', 7, 4)
INSERT [dbo].[Position] ([Name], [SalaryPerhour], [WorkHoursPerDay]) VALUES (N'Gravedigger', 3, 10)
INSERT [dbo].[Position] ([Name], [SalaryPerhour], [WorkHoursPerDay]) VALUES (N'Manager', 30, 5)
INSERT [dbo].[Position] ([Name], [SalaryPerhour], [WorkHoursPerDay]) VALUES (N'Owner', 35, 4)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (1, 1, 22, 2640, 22)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (1, 2, 19, 2280, 19)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (1, 3, 21, 2520, 21)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (1, 4, 22, 2640, 22)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (2, 1, 22, 2640, 22)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (2, 2, 19, 2280, 19)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (2, 3, 21, 2520, 21)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (2, 4, 22, 2640, 22)
INSERT [dbo].[Salary] ([WorkerID], [MonthID], [WorkDays], [Salary], [DaysWorked]) VALUES (1, 5, NULL, NULL, NULL)
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (1, N'Aleksa', N'Marceta', N'marceta.aleksa@sahrane.grob', CAST(N'1998-01-23' AS Date), N'Aleksa', N'Administrator', N'38766311227', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (2, N'Aleksandar', N'Panzalovic', N'panzalovic.aleksandar@sahrane.grob', CAST(N'1998-05-22' AS Date), N'Aleksandar', N'Administrator', N'38766257486', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (3, N'Joe', N'Jonson', N'jonson.joe@sahrane.grob', CAST(N'1985-05-25' AS Date), N'Joe', N'Gravedigger', N'38765447882', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (4, N'Nick', N'Smith', N'smith.nick@sahrane.grob', CAST(N'1994-03-15' AS Date), N'Nick', N'Gravedigger', N'38763457836', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (5, N'Edvin', N'Rockefeller', N'rockefeller.edvin@sahrane.grob', CAST(N'1981-08-11' AS Date), N'Edvin', N'Accounting', N'38764400053', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (6, N'Rickon', N'Goldenberg', N'goldenberg.rickon@sahrane.grob', CAST(N'1976-11-28' AS Date), N'Rickon', N'Owner', N'38764444444', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (7, N'Severick', N'Uller', N'uller.severick@sahrane.grob', CAST(N'1977-09-02' AS Date), N'Severick', N'Manager', N'38766789425', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (8, N'Jon', N'Snow', N'snow.jon@sahrane.grob', CAST(N'1996-05-27' AS Date), N'Jon Snow', N'Gravedigger', N'38766587824', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (9, N'Nikolaj', N'Raskjevich', N'raskjevich.nikolaj@grobari.grob', CAST(N'1973-05-12' AS Date), N'Nikolaj', N'Gravedigger', N'38766985124', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (10, N'Simens', N'Lokovich', N'lokovich.simens@grobari.grob', CAST(N'1988-12-25' AS Date), N'Simens', N'Gravedigger', N'38766452258', N'Male')
INSERT [dbo].[Workers] ([ID], [Name], [Surname], [Email], [Birth], [Username], [Position], [Phone], [Gender]) VALUES (11, N'Nikola', N'Stankovic', N'nikola.nbv@grobari.grob', CAST(N'1998-03-04' AS Date), N'NNikolica', N'Gravedigger', N'38765027997', N'Male')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UsernameUnique_Login]    Script Date: 5/8/2019 8:28:42 PM ******/
ALTER TABLE [dbo].[Login] ADD  CONSTRAINT [UsernameUnique_Login] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailUnique_Workers]    Script Date: 5/8/2019 8:28:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [EmailUnique_Workers] ON [dbo].[Workers]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UsernameUnique_Workers]    Script Date: 5/8/2019 8:28:42 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UsernameUnique_Workers] ON [dbo].[Workers]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Workers] FOREIGN KEY([ID])
REFERENCES [dbo].[Workers] ([ID])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Workers]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Month] FOREIGN KEY([MonthID])
REFERENCES [dbo].[Month] ([MonthID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Month]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Workers] FOREIGN KEY([WorkerID])
REFERENCES [dbo].[Workers] ([ID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Workers]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Workers_Position] FOREIGN KEY([Position])
REFERENCES [dbo].[Position] ([NameOfPosition])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_Workers_Position]
GO
USE [master]
GO
ALTER DATABASE [Projekat] SET  READ_WRITE 
GO

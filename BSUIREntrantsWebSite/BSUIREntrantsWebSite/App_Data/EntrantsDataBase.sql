USE [master]
GO
/****** Object:  Database [EntrantsDataBase]    Script Date: 29.12.2017 22:11:52 ******/
CREATE DATABASE [EntrantsDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntrantsDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EntrantsDataBase.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EntrantsDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EntrantsDataBase_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EntrantsDataBase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntrantsDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EntrantsDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EntrantsDataBase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EntrantsDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EntrantsDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EntrantsDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EntrantsDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EntrantsDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EntrantsDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [EntrantsDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EntrantsDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EntrantsDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EntrantsDataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EntrantsDataBase]
GO
/****** Object:  User [IIS APPPOOL\DefaultAppPool]    Script Date: 29.12.2017 22:11:52 ******/
CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool] WITH DEFAULT_SCHEMA=[.dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
/****** Object:  Table [dbo].[Entrants]    Script Date: 29.12.2017 22:11:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrants](
	[EntrantId] [int] IDENTITY(1,1) NOT NULL,
	[SelectedEntrant] [bit] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[DateOfTheBirth] [datetime2](7) NOT NULL,
	[Speciality] [nvarchar](50) NOT NULL,
	[HomeAddress] [nvarchar](150) NOT NULL,
	[MobilePhone] [nvarchar](15) NOT NULL,
	[HasPrivileges] [bit] NOT NULL,
	[Privileges] [nvarchar](250) NULL,
	[NeedsDormitory] [bit] NOT NULL,
	[School] [nvarchar](100) NOT NULL,
	[YearOfFinishingTheSchool] [int] NOT NULL,
	[AverageSchoolScore] [float] NOT NULL,
	[ForeignLanguage] [nvarchar](30) NOT NULL,
	[HasMother] [bit] NOT NULL,
	[MotherName] [nvarchar](50) NULL,
	[MotherSecondName] [nvarchar](50) NULL,
	[MotherSurname] [nvarchar](50) NULL,
	[MotherDateofTheBirth] [datetime2](7) NULL,
	[MotherHomeAddress] [nvarchar](150) NULL,
	[MotherMobilePhone] [nvarchar](15) NULL,
	[MotherPlaceOfWork] [nvarchar](100) NULL,
	[HasFather] [bit] NOT NULL,
	[FatherName] [nvarchar](50) NULL,
	[FatherSecondName] [nvarchar](50) NULL,
	[FatherSurname] [nvarchar](50) NULL,
	[FatherDateofTheBirth] [datetime2](7) NULL,
	[FatherHomeAddress] [nvarchar](150) NULL,
	[FatherMobilePhone] [nvarchar](15) NULL,
	[FatherPlaceOfWork] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[EntrantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Entrants] ON 

INSERT [dbo].[Entrants] ([EntrantId], [SelectedEntrant], [Name], [SecondName], [Surname], [DateOfTheBirth], [Speciality], [HomeAddress], [MobilePhone], [HasPrivileges], [Privileges], [NeedsDormitory], [School], [YearOfFinishingTheSchool], [AverageSchoolScore], [ForeignLanguage], [HasMother], [MotherName], [MotherSecondName], [MotherSurname], [MotherDateofTheBirth], [MotherHomeAddress], [MotherMobilePhone], [MotherPlaceOfWork], [HasFather], [FatherName], [FatherSecondName], [FatherSurname], [FatherDateofTheBirth], [FatherHomeAddress], [FatherMobilePhone], [FatherPlaceOfWork]) VALUES (1, 0, N'Rena', N'Genie', N'Dorokh', CAST(0x07000000000030230B AS DateTime2), N'IaTP', N'pr.Dzerzhinskogo, 95', N'+375291258419', 0, NULL, 1, N'Gymnasia #1', 2016, 9.9, N'English', 1, N'Tatie', N'Lyla', N'Dorokh', CAST(0x070000000000B1F90A AS DateTime2), N'Komsomolskaya, 16', N'+375296164067', N'Gymnasia #1', 1, N'Gen', N'Alex', N'Dorokh', CAST(0x07000000000017230B AS DateTime2), N'Komsomolskaya, 16', N'+375296164067', N'BiS')
INSERT [dbo].[Entrants] ([EntrantId], [SelectedEntrant], [Name], [SecondName], [Surname], [DateOfTheBirth], [Speciality], [HomeAddress], [MobilePhone], [HasPrivileges], [Privileges], [NeedsDormitory], [School], [YearOfFinishingTheSchool], [AverageSchoolScore], [ForeignLanguage], [HasMother], [MotherName], [MotherSecondName], [MotherSurname], [MotherDateofTheBirth], [MotherHomeAddress], [MotherMobilePhone], [MotherPlaceOfWork], [HasFather], [FatherName], [FatherSecondName], [FatherSurname], [FatherDateofTheBirth], [FatherHomeAddress], [FatherMobilePhone], [FatherPlaceOfWork]) VALUES (2, 0, N'Jack', N'Fred', N'Richardson', CAST(0x07000000000003250B AS DateTime2), N'POIT', N'Somewhere', N'+4354656757', 1, N'An orphan', 1, N'SA', 2017, 9.7, N'Spanish', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Entrants] ([EntrantId], [SelectedEntrant], [Name], [SecondName], [Surname], [DateOfTheBirth], [Speciality], [HomeAddress], [MobilePhone], [HasPrivileges], [Privileges], [NeedsDormitory], [School], [YearOfFinishingTheSchool], [AverageSchoolScore], [ForeignLanguage], [HasMother], [MotherName], [MotherSecondName], [MotherSurname], [MotherDateofTheBirth], [MotherHomeAddress], [MotherMobilePhone], [MotherPlaceOfWork], [HasFather], [FatherName], [FatherSecondName], [FatherSurname], [FatherDateofTheBirth], [FatherHomeAddress], [FatherMobilePhone], [FatherPlaceOfWork]) VALUES (3, 0, N'Bella', N'Alice', N'Queen', CAST(0x0700000000005D260B AS DateTime2), N'KHX', N'Somewhere', N'+345345356', 0, NULL, 0, N'MN School', 2018, 7.9, N'French', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Carl', N'Sean', N'Queen', CAST(0x07000000000058030B AS DateTime2), N'Somewhere', N'+5645645343', N'Somewhere')
SET IDENTITY_INSERT [dbo].[Entrants] OFF
ALTER TABLE [dbo].[Entrants] ADD  DEFAULT ((0)) FOR [SelectedEntrant]
GO
USE [master]
GO
ALTER DATABASE [EntrantsDataBase] SET  READ_WRITE 
GO

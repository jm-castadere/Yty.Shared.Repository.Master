USE [master]
GO
/****** Object:  Database [Yti_RepositoryMaster]    Script Date: 21.01.2022 14:46:15 ******/
CREATE DATABASE [Yti_RepositoryMaster]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Yti_RepositoryMaster', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Yti_RepositoryMaster.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Yti_RepositoryMaster_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Yti_RepositoryMaster_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Yti_RepositoryMaster] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Yti_RepositoryMaster].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Yti_RepositoryMaster] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET ARITHABORT OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET  MULTI_USER 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Yti_RepositoryMaster] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Yti_RepositoryMaster] SET QUERY_STORE = OFF
GO
USE [Yti_RepositoryMaster]
GO
/****** Object:  Table [dbo].[Aggregate]    Script Date: 21.01.2022 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aggregate](
	[Id] [uniqueidentifier] NOT NULL,
	[PolicyId] [uniqueidentifier] NULL,
	[EntityId] [uniqueidentifier] NULL,
	[Name] [varchar](50) NOT NULL,
	[ValueEntityId] [uniqueidentifier] NULL,
	[ValueStandPropertyId] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntityDefinition]    Script Date: 21.01.2022 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntityDefinition](
	[Id] [uniqueidentifier] NOT NULL,
	[PolicyId] [uniqueidentifier] NULL,
	[Namespace] [varchar](50) NULL,
	[Repository] [varchar](50) NOT NULL,
	[Version] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_EntityDefinition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StandardProperty]    Script Date: 21.01.2022 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StandardProperty](
	[Id] [uniqueidentifier] NOT NULL,
	[PolicyId] [uniqueidentifier] NULL,
	[EntityId] [uniqueidentifier] NULL,
	[Name] [varchar](50) NOT NULL,
	[TypValue] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ValueTyp]    Script Date: 21.01.2022 14:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValueTyp](
	[Id] [int] NULL,
	[Typ] [varchar](50) NULL,
	[CanNul] [bit] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Yti_RepositoryMaster] SET  READ_WRITE 
GO

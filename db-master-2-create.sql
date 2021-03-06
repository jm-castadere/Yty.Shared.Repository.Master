USE [Repository_Master]
GO
/****** Object:  User [JMC]    Script Date: 21.01.2022 15:05:15 ******/
CREATE USER [JMC] FOR LOGIN [nexxtsoft] WITH DEFAULT_SCHEMA=[db_owner]
GO
/****** Object:  User [nexxtsoftlog]    Script Date: 21.01.2022 15:05:15 ******/
CREATE USER [nexxtsoftlog] FOR LOGIN [nexxtsoftlog] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [JMC]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [JMC]
GO
ALTER ROLE [db_owner] ADD MEMBER [nexxtsoftlog]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [nexxtsoftlog]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21.01.2022 15:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aggregate]    Script Date: 21.01.2022 15:05:15 ******/
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
/****** Object:  Table [dbo].[Entities]    Script Date: 21.01.2022 15:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entities](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[CreateDate] [datetime2](7) NULL,
	[EntityStatus] [int] NOT NULL,
	[VersionMasterMaxVersion] [bigint] NULL,
	[VersonMasterIsCheckedOut] [bit] NULL,
	[VersonMasterId] [uniqueidentifier] NOT NULL,
	[Version] [bigint] NULL,
	[SystemName] [nvarchar](max) NULL,
	[Namespace] [nvarchar](max) NULL,
	[PolicyId] [uniqueidentifier] NOT NULL,
	[ForeignId] [nvarchar](max) NULL,
	[Repository] [nvarchar](max) NULL,
	[LastModifiedDate] [datetime2](7) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Entities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntityDefinition]    Script Date: 21.01.2022 15:05:15 ******/
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
/****** Object:  Table [dbo].[Pictures]    Script Date: 21.01.2022 15:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Url] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Selfie]    Script Date: 21.01.2022 15:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Selfie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[WookieId] [int] NOT NULL,
	[PictureId] [int] NOT NULL,
 CONSTRAINT [PK_Selfie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StandardProperty]    Script Date: 21.01.2022 15:05:15 ******/
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
/****** Object:  Table [dbo].[ValueTyp]    Script Date: 21.01.2022 15:05:15 ******/
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
/****** Object:  Table [dbo].[Wookie]    Script Date: 21.01.2022 15:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wookie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](max) NULL,
 CONSTRAINT [PK_Wookie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Selfie]  WITH CHECK ADD  CONSTRAINT [FK_Selfie_Pictures_PictureId] FOREIGN KEY([PictureId])
REFERENCES [dbo].[Pictures] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Selfie] CHECK CONSTRAINT [FK_Selfie_Pictures_PictureId]
GO
ALTER TABLE [dbo].[Selfie]  WITH CHECK ADD  CONSTRAINT [FK_Selfie_Wookie_WookieId] FOREIGN KEY([WookieId])
REFERENCES [dbo].[Wookie] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Selfie] CHECK CONSTRAINT [FK_Selfie_Wookie_WookieId]
GO

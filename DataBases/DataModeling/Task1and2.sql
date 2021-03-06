USE [master]
GO
/****** Object:  Database [World]    Script Date: 21.8.2014 г. 15:22:28 ч. ******/
CREATE DATABASE [World]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'World', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\World.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'World_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\World_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [World] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [World].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [World] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [World] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [World] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [World] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [World] SET ARITHABORT OFF 
GO
ALTER DATABASE [World] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [World] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [World] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [World] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [World] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [World] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [World] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [World] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [World] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [World] SET  DISABLE_BROKER 
GO
ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [World] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [World] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [World] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [World] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [World] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [World] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [World] SET RECOVERY FULL 
GO
ALTER DATABASE [World] SET  MULTI_USER 
GO
ALTER DATABASE [World] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [World] SET DB_CHAINING OFF 
GO
ALTER DATABASE [World] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [World] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'World', N'ON'
GO
USE [World]
GO
/****** Object:  Table [dbo].[Adresses]    Script Date: 21.8.2014 г. 15:22:28 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresses](
	[AdressId] [int] IDENTITY(1,1) NOT NULL,
	[AdressText] [nvarchar](70) NOT NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Adresses] PRIMARY KEY CLUSTERED 
(
	[AdressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 21.8.2014 г. 15:22:28 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countrys]    Script Date: 21.8.2014 г. 15:22:28 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countrys](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Countrys] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 21.8.2014 г. 15:22:28 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AdressId] [int] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 21.8.2014 г. 15:22:28 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Adresses] ON 

INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (1, N'Vitosha 11', 1)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (2, N'Rakovska 33', 1)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (3, N'Pozitano 20', 1)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (4, N'Vasil Levski 12', 2)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (5, N'Hristo Botev 14', 2)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (6, N'Vasil Levski 21', 3)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (7, N'Vasil Levski 21', 4)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (16, N'Hristo Botev 11', 5)
INSERT [dbo].[Adresses] ([AdressId], [AdressText], [TownId]) VALUES (17, N'Hristo Botev 16', 5)
SET IDENTITY_INSERT [dbo].[Adresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([Id], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (3, N'Asia')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (4, N'Australia')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (5, N'North America')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (6, N'South America')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countrys] ON 

INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (2, N'Germany', 1)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (3, N'Italy', 1)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (4, N'Spain', 1)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (5, N'USA', 5)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (6, N'Canada', 5)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (7, N'China', 3)
INSERT [dbo].[Countrys] ([CountryId], [Name], [ContinentId]) VALUES (8, N'Mexico', 6)
SET IDENTITY_INSERT [dbo].[Countrys] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (1, N'Pesho', N'Peshev', 1)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (2, N'Gosho', N'Goshev', 2)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (3, N'Kiro', N'Kirev', 2)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (4, N'Petkan', N'Petkanov', 3)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (5, N'Ivan', N'Ivanov', 6)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (6, N'Georgi', N'Georgiev', 7)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (7, N'Peter', N'Petrov', 4)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (8, N'Atanas', N'Atanasov', 5)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (9, N'Pavel', N'Pavlov', 1)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (10, N'Ivan', N'Georgiev', 3)
INSERT [dbo].[Persons] ([PersonId], [FirstName], [LastName], [AdressId]) VALUES (11, N'Georgi', N'Ivanov', 4)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (2, N'Varna', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (3, N'Burgas', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (4, N'Sandanski', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (5, N'Blagoevgrad', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (6, N'Munich', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (7, N'Nurnberg', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (8, N'Hamburg', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (9, N'Milan', 3)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (10, N'Rome', 3)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (11, N'Madrid', 4)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (12, N'New York', 5)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (13, N'Toronto', 6)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Adresses]  WITH CHECK ADD  CONSTRAINT [FK_Adresses_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([TownId])
GO
ALTER TABLE [dbo].[Adresses] CHECK CONSTRAINT [FK_Adresses_Towns]
GO
ALTER TABLE [dbo].[Countrys]  WITH CHECK ADD  CONSTRAINT [FK_Countrys_Continents] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continents] ([Id])
GO
ALTER TABLE [dbo].[Countrys] CHECK CONSTRAINT [FK_Countrys_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Adresses] FOREIGN KEY([AdressId])
REFERENCES [dbo].[Adresses] ([AdressId])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Adresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countrys] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countrys] ([CountryId])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countrys]
GO
USE [master]
GO
ALTER DATABASE [World] SET  READ_WRITE 
GO

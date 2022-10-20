USE [master]
GO
/****** Object:  Database [ConsoleWorld]    Script Date: 20/10/2022 08:57:15 ******/
CREATE DATABASE [ConsoleWorld]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ConsoleWorld', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ConsoleWorld.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ConsoleWorld_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ConsoleWorld_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ConsoleWorld] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ConsoleWorld].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ConsoleWorld] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ConsoleWorld] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ConsoleWorld] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ConsoleWorld] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ConsoleWorld] SET ARITHABORT OFF 
GO
ALTER DATABASE [ConsoleWorld] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ConsoleWorld] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ConsoleWorld] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ConsoleWorld] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ConsoleWorld] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ConsoleWorld] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ConsoleWorld] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ConsoleWorld] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ConsoleWorld] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ConsoleWorld] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ConsoleWorld] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ConsoleWorld] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ConsoleWorld] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ConsoleWorld] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ConsoleWorld] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ConsoleWorld] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ConsoleWorld] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ConsoleWorld] SET RECOVERY FULL 
GO
ALTER DATABASE [ConsoleWorld] SET  MULTI_USER 
GO
ALTER DATABASE [ConsoleWorld] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ConsoleWorld] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ConsoleWorld] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ConsoleWorld] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ConsoleWorld] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ConsoleWorld', N'ON'
GO
ALTER DATABASE [ConsoleWorld] SET QUERY_STORE = OFF
GO
USE [ConsoleWorld]
GO
/****** Object:  User [alumno]    Script Date: 20/10/2022 08:57:15 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Consola]    Script Date: 20/10/2022 08:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consola](
	[idConsola] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaSalida] [datetime] NOT NULL,
	[Empresa] [varchar](50) NOT NULL,
	[Informacion] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Consola] PRIMARY KEY CLUSTERED 
(
	[idConsola] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Juego]    Script Date: 20/10/2022 08:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Juego](
	[idJuego] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[idConsola] [int] NOT NULL,
	[FechaSalida] [datetime] NOT NULL,
	[Desarrolladora] [varchar](50) NOT NULL,
	[Favorito] [bit] NULL,
	[Informacion] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Juego] PRIMARY KEY CLUSTERED 
(
	[idJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/10/2022 08:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Foto] [varchar](50) NOT NULL,
	[FechaCreacion] [varchar](50) NOT NULL,
	[Informacion] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Consola] ON 

INSERT [dbo].[Consola] ([idConsola], [Nombre], [FechaSalida], [Empresa], [Informacion]) VALUES (1, N'PlayStation 1', CAST(N'1994-12-03T00:00:00.000' AS DateTime), N'Sony', N'PlayStation es la primera videoconsola de Sony, y la primera de dicha compañía en ser diseñada por Ken Kutaragi, y es una videoconsola de sobremesa de 32 bits lanzada por Sony Computer Entertainment. Se considera la videoconsola más exitosa de la quinta generación tanto en ventas como en popularidad. Además de la original. Se estima que Sony pudo vender 102,4 millones de consolas en diez años. La consola fue retirada oficialmente del mercado el 23 de marzo de 2006')
INSERT [dbo].[Consola] ([idConsola], [Nombre], [FechaSalida], [Empresa], [Informacion]) VALUES (2, N'PlayStation 2', CAST(N'2000-03-04T00:00:00.000' AS DateTime), N'Sony', N'La PlayStation 2 es la segunda videoconsola de sobremesa producida por Sony Computer Entertainment, y la tercera consola de Sony en ser diseñada por Ken Kutaragi. Además de ser la sucesora de la PlayStation. Es la videoconsola más vendida de la historia, con más de 155 millones de unidades vendidas.? Esta consola es también la que más juegos posee, aproximadamente 3870, seguida por su predecesora la PlayStation con unos 2500. Esta cantidad de juegos se debe a la extraordinaria acogida por parte del público en general hacia la misma, lo que incluso la consolidó como la consola con más tiempo en el mercado y a su vez la consola con más duración en el mismo, hasta que el 3 de enero del año 2013 se decide detener su fabricación tras 13 años de actividad.A pesar del anuncio, se continuaron produciendo nuevos juegos para la consola hasta finales de 2013.')
SET IDENTITY_INSERT [dbo].[Consola] OFF
GO
USE [master]
GO
ALTER DATABASE [ConsoleWorld] SET  READ_WRITE 
GO

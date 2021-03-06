USE [master]
GO
/****** Object:  Database [hastane]    Script Date: 1.01.2021 04:58:49 ******/
CREATE DATABASE [hastane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hastane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\hastane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'hastane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\hastane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [hastane] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hastane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hastane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hastane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hastane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hastane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hastane] SET ARITHABORT OFF 
GO
ALTER DATABASE [hastane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hastane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hastane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hastane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hastane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hastane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hastane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hastane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hastane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hastane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hastane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hastane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hastane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hastane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hastane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hastane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hastane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hastane] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [hastane] SET  MULTI_USER 
GO
ALTER DATABASE [hastane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hastane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hastane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hastane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [hastane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [hastane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [hastane] SET QUERY_STORE = OFF
GO
USE [hastane]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 1.01.2021 04:58:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 1.01.2021 04:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointment](
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[tc] [nchar](11) NULL,
	[doctor_name] [nvarchar](50) NULL,
	[doctor_surname] [nvarchar](50) NULL,
	[doctor_tc] [nchar](11) NULL,
	[description] [nvarchar](200) NULL,
	[section] [nvarchar](50) NULL,
	[status] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 1.01.2021 04:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[department_id] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 1.01.2021 04:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[tc] [nchar](11) NULL,
	[phone] [varchar](10) NULL,
	[mail] [varchar](320) NULL,
	[department] [nvarchar](50) NULL,
	[password] [nvarchar](14) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 1.01.2021 04:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[tc] [nchar](11) NULL,
	[phone] [nchar](10) NULL,
	[mail] [varchar](320) NULL,
	[password] [nvarchar](14) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [hastane] SET  READ_WRITE 
GO

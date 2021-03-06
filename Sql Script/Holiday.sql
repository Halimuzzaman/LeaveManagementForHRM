USE [master]
GO
/****** Object:  Database [Leave]    Script Date: 3/29/2016 9:45:02 PM ******/
CREATE DATABASE [Leave]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Leave', FILENAME = N'C:\Users\shubh\Leave.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Leave_log', FILENAME = N'C:\Users\shubh\Leave_log.ldf' , SIZE = 560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Leave] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Leave].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Leave] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Leave] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Leave] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Leave] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Leave] SET ARITHABORT OFF 
GO
ALTER DATABASE [Leave] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Leave] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Leave] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Leave] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Leave] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Leave] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Leave] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Leave] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Leave] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Leave] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Leave] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Leave] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Leave] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Leave] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Leave] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Leave] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Leave] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Leave] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Leave] SET  MULTI_USER 
GO
ALTER DATABASE [Leave] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Leave] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Leave] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Leave] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Leave] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Leave]
GO
/****** Object:  Table [dbo].[Holidays]    Script Date: 3/29/2016 9:45:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Holidays](
	[Name] [varchar](20) NULL,
	[Start Date] [date] NULL,
	[End Date] [date] NULL,
	[Holiday Type] [varchar](12) NOT NULL,
	[Repeats Annually] [varchar](3) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Leave] SET  READ_WRITE 
GO

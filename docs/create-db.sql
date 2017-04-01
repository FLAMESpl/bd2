USE [master]
GO

/****** Object:  Database [clinic]    Script Date: 01.04.2017 13:04:05 ******/
CREATE DATABASE [clinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'clinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\clinic.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'clinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\clinic_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [clinic] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [clinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [clinic] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [clinic] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [clinic] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [clinic] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [clinic] SET ARITHABORT OFF 
GO

ALTER DATABASE [clinic] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [clinic] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [clinic] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [clinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [clinic] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [clinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [clinic] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [clinic] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [clinic] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [clinic] SET  DISABLE_BROKER 
GO

ALTER DATABASE [clinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [clinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [clinic] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [clinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [clinic] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [clinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [clinic] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [clinic] SET RECOVERY FULL 
GO

ALTER DATABASE [clinic] SET  MULTI_USER 
GO

ALTER DATABASE [clinic] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [clinic] SET DB_CHAINING OFF 
GO

ALTER DATABASE [clinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [clinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [clinic] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [clinic] SET QUERY_STORE = OFF
GO

USE [clinic]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [clinic] SET  READ_WRITE 
GO



USE [clinic]
GO

/****** Object:  Table [dbo].[Address]    Script Date: 01.04.2017 13:03:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Address](
	[city] [bigint] NOT NULL,
	[street] [nvarchar](50) NOT NULL,
	[house_no] [int] NOT NULL,
	[flat_no] [int] NOT NULL,
	[id_pat] [bigint] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Patient] FOREIGN KEY([id_pat])
REFERENCES [dbo].[Patient] ([id_pat])
GO

ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Patient]
GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Doctor]    Script Date: 01.04.2017 13:04:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Doctor](
	[id_doc] [bigint] NOT NULL,
	[licence_no] [nchar](10) NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[id_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Lab_assistant]    Script Date: 01.04.2017 13:04:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lab_assistant](
	[id_lab_ass] [bigint] NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lab_assistant] PRIMARY KEY CLUSTERED 
(
	[id_lab_ass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Lab_manager]    Script Date: 01.04.2017 13:04:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lab_manager](
	[id_lab_manag] [bigint] NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lab_manager] PRIMARY KEY CLUSTERED 
(
	[id_lab_manag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Patient]    Script Date: 01.04.2017 13:05:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patient](
	[id_pat] [bigint] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[PESEL] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[id_pat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Registrator]    Script Date: 01.04.2017 13:05:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Registrator](
	[id_reg] [bigint] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Registrator] PRIMARY KEY CLUSTERED 
(
	[id_reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Registrator]  WITH CHECK ADD  CONSTRAINT [FK_Registrator_User] FOREIGN KEY([name])
REFERENCES [dbo].[User] ([id_user])
GO

ALTER TABLE [dbo].[Registrator] CHECK CONSTRAINT [FK_Registrator_User]
GO

USE [clinic]
GO

/****** Object:  Table [dbo].[test_dict]    Script Date: 01.04.2017 13:05:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[test_dict](
	[code] [bigint] NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_test_dict_1] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Test_laboratory]    Script Date: 01.04.2017 13:05:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_laboratory](
	[id_test_lab] [bigint] NOT NULL,
	[doc_notes] [nvarchar](max) NULL,
	[dt_commis] [datetime] NOT NULL,
	[result] [nvarchar](50) NULL,
	[dt_exe] [datetime] NULL,
	[manag_notes] [nvarchar](max) NOT NULL,
	[dt_conf|canc] [datetime] NULL,
	[status] [nvarchar](50) NOT NULL,
	[id_visit] [bigint] NOT NULL,
	[id_lab_manag] [bigint] NOT NULL,
	[id_lab_ass] [bigint] NULL,
	[code] [bigint] NOT NULL,
 CONSTRAINT [PK_Test_laboratory] PRIMARY KEY CLUSTERED 
(
	[id_test_lab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Test_laboratory]  WITH CHECK ADD  CONSTRAINT [FK_Test_laboratory_Lab_assistant] FOREIGN KEY([id_lab_ass])
REFERENCES [dbo].[Lab_assistant] ([id_lab_ass])
GO

ALTER TABLE [dbo].[Test_laboratory] CHECK CONSTRAINT [FK_Test_laboratory_Lab_assistant]
GO

ALTER TABLE [dbo].[Test_laboratory]  WITH CHECK ADD  CONSTRAINT [FK_Test_laboratory_Lab_manager] FOREIGN KEY([id_lab_manag])
REFERENCES [dbo].[Lab_manager] ([id_lab_manag])
GO

ALTER TABLE [dbo].[Test_laboratory] CHECK CONSTRAINT [FK_Test_laboratory_Lab_manager]
GO

ALTER TABLE [dbo].[Test_laboratory]  WITH CHECK ADD  CONSTRAINT [FK_Test_laboratory_test_dict] FOREIGN KEY([code])
REFERENCES [dbo].[test_dict] ([code])
GO

ALTER TABLE [dbo].[Test_laboratory] CHECK CONSTRAINT [FK_Test_laboratory_test_dict]
GO

ALTER TABLE [dbo].[Test_laboratory]  WITH CHECK ADD  CONSTRAINT [FK_Test_laboratory_Visit] FOREIGN KEY([id_visit])
REFERENCES [dbo].[Visit] ([id_visit])
GO

ALTER TABLE [dbo].[Test_laboratory] CHECK CONSTRAINT [FK_Test_laboratory_Visit]
GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Test_physical]    Script Date: 01.04.2017 13:05:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_physical](
	[id_test_phys] [bigint] NOT NULL,
	[result] [nvarchar](max) NULL,
	[id_visit] [bigint] NOT NULL,
	[code] [bigint] NOT NULL,
 CONSTRAINT [PK_Test_physical] PRIMARY KEY CLUSTERED 
(
	[id_test_phys] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Test_physical]  WITH CHECK ADD  CONSTRAINT [FK_Test_physical_test_dict1] FOREIGN KEY([code])
REFERENCES [dbo].[test_dict] ([code])
GO

ALTER TABLE [dbo].[Test_physical] CHECK CONSTRAINT [FK_Test_physical_test_dict1]
GO

ALTER TABLE [dbo].[Test_physical]  WITH CHECK ADD  CONSTRAINT [FK_Test_physical_Visit] FOREIGN KEY([id_visit])
REFERENCES [dbo].[Visit] ([id_visit])
GO

ALTER TABLE [dbo].[Test_physical] CHECK CONSTRAINT [FK_Test_physical_Visit]
GO

USE [clinic]
GO

/****** Object:  Table [dbo].[User]    Script Date: 01.04.2017 13:05:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[id_user] [nvarchar](50) NULL
) ON [PRIMARY]

GO

USE [clinic]
GO

/****** Object:  Table [dbo].[Visit]    Script Date: 01.04.2017 13:05:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Visit](
	[id_visit] [bigint] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[diagnosis] [nvarchar](max) NULL,
	[status] [nvarchar](50) NOT NULL,
	[dt_registry] [datetime] NOT NULL,
	[dt_conf|canc] [datetime] NULL,
	[id_reg] [bigint] NOT NULL,
	[id_pat] [bigint] NOT NULL,
	[id_doc] [bigint] NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[id_visit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Doctor] FOREIGN KEY([id_doc])
REFERENCES [dbo].[Doctor] ([id_doc])
GO

ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Doctor]
GO

ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Patient] FOREIGN KEY([id_pat])
REFERENCES [dbo].[Patient] ([id_pat])
GO

ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Patient]
GO

ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Registrator] FOREIGN KEY([id_reg])
REFERENCES [dbo].[Registrator] ([id_reg])
GO

ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Registrator]
GO


USE [master]
GO
/****** Object:  Database [Clinic]    Script Date: 2017-04-09 17:43:38 ******/
/****** Dont forget to change the ldf and mdf filepaths!!! ******/
/****** Check out generate_db_readme.txt for more info ******/
CREATE DATABASE [Clinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinic', FILENAME = N'C:\DATA\filepath.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Clinic_log', FILENAME = N'C:\DATA\filepath.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Clinic] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Clinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinic] SET RECOVERY FULL 
GO
ALTER DATABASE [Clinic] SET  MULTI_USER 
GO
ALTER DATABASE [Clinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Clinic] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Clinic', N'ON'
GO
USE [Clinic]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[id_add] [bigint] IDENTITY(1,1) NOT NULL,
	[id_pat] [bigint] NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[street] [nvarchar](50) NOT NULL,
	[house_no] [int] NOT NULL,
	[flat_no] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id_add] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 2017-04-09 17:43:38 ******/
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
/****** Object:  Table [dbo].[Lab_assistant]    Script Date: 2017-04-09 17:43:38 ******/
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
/****** Object:  Table [dbo].[Lab_manager]    Script Date: 2017-04-09 17:43:38 ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id_pat] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[PESEL] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[id_pat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registrator]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registrator](
	[id_reg] [bigint] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Registrator_1] PRIMARY KEY CLUSTERED 
(
	[id_reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[test_dict]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test_dict](
	[code] [bigint] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_test_dict_1] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Test_laboratory]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test_laboratory](
	[id_test_lab] [bigint] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Test_physical]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test_physical](
	[id_test_phys] [bigint] IDENTITY(1,1) NOT NULL,
	[result] [nvarchar](max) NULL,
	[id_visit] [bigint] NOT NULL,
	[code] [bigint] NOT NULL,
 CONSTRAINT [PK_Test_physical] PRIMARY KEY CLUSTERED 
(
	[id_test_phys] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[username] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[dt_registry] [datetime] NOT NULL,
	[role] [nvarchar](50) NOT NULL,
	[id_user] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visit]    Script Date: 2017-04-09 17:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[id_visit] [bigint] IDENTITY(1,1) NOT NULL,
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
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Address]    Script Date: 2017-04-09 17:43:38 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Address] ON [dbo].[Address]
(
	[id_pat] ASC,
	[flat_no] ASC,
	[house_no] ASC,
	[street] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Lab_assistant]    Script Date: 2017-04-09 17:43:38 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Lab_assistant] ON [dbo].[Lab_assistant]
(
	[id_lab_ass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Lab_manager]    Script Date: 2017-04-09 17:43:38 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Lab_manager] ON [dbo].[Lab_manager]
(
	[id_lab_manag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Patient] FOREIGN KEY([id_pat])
REFERENCES [dbo].[Patient] ([id_pat])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Patient]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_User1] FOREIGN KEY([id_doc])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_User1]
GO
ALTER TABLE [dbo].[Lab_assistant]  WITH CHECK ADD  CONSTRAINT [FK_Lab_assistant_User] FOREIGN KEY([id_lab_ass])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Lab_assistant] CHECK CONSTRAINT [FK_Lab_assistant_User]
GO
ALTER TABLE [dbo].[Lab_manager]  WITH CHECK ADD  CONSTRAINT [FK_Lab_manager_User] FOREIGN KEY([id_lab_manag])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Lab_manager] CHECK CONSTRAINT [FK_Lab_manager_User]
GO
ALTER TABLE [dbo].[Registrator]  WITH CHECK ADD  CONSTRAINT [FK_Registrator_User1] FOREIGN KEY([id_reg])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Registrator] CHECK CONSTRAINT [FK_Registrator_User1]
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
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Doctor1] FOREIGN KEY([id_doc])
REFERENCES [dbo].[Doctor] ([id_doc])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Doctor1]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Patient] FOREIGN KEY([id_pat])
REFERENCES [dbo].[Patient] ([id_pat])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Patient]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Registrator1] FOREIGN KEY([id_reg])
REFERENCES [dbo].[Registrator] ([id_reg])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Registrator1]
GO
USE [master]
GO
ALTER DATABASE [Clinic] SET  READ_WRITE 
GO

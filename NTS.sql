USE [master]
GO
/****** Object:  Database [NTS]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE DATABASE [NTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NTS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\NTS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NTS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\NTS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [NTS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [NTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NTS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NTS] SET RECOVERY FULL 
GO
ALTER DATABASE [NTS] SET  MULTI_USER 
GO
ALTER DATABASE [NTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NTS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NTS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NTS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NTS', N'ON'
GO
ALTER DATABASE [NTS] SET QUERY_STORE = ON
GO
ALTER DATABASE [NTS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [NTS]
GO
/****** Object:  User [Admin]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/15/2024 8:35:53 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 5/15/2024 8:35:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[DepartamentoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](128) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[DepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 5/15/2024 8:35:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](128) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[FechaContratacion] [datetime2](7) NOT NULL,
	[DepartamentoID] [int] NOT NULL,
	[SubDepartamentoID] [int] NOT NULL,
	[RolEmpleadoID] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolesEmpleados]    Script Date: 5/15/2024 8:35:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesEmpleados](
	[RolEmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](128) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RolesEmpleados] PRIMARY KEY CLUSTERED 
(
	[RolEmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subdepartamentos]    Script Date: 5/15/2024 8:35:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subdepartamentos](
	[SubDepartamentoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](128) NOT NULL,
	[DepartamentoID] [int] NOT NULL,
 CONSTRAINT [PK_Subdepartamentos] PRIMARY KEY CLUSTERED 
(
	[SubDepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sueldos]    Script Date: 5/15/2024 8:35:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sueldos](
	[SueldoID] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[FechaFin] [datetime2](7) NULL,
 CONSTRAINT [PK_Sueldos] PRIMARY KEY CLUSTERED 
(
	[SueldoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empleados_DepartamentoID]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE NONCLUSTERED INDEX [IX_Empleados_DepartamentoID] ON [dbo].[Empleados]
(
	[DepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empleados_RolEmpleadoID]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE NONCLUSTERED INDEX [IX_Empleados_RolEmpleadoID] ON [dbo].[Empleados]
(
	[RolEmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empleados_SubDepartamentoID]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE NONCLUSTERED INDEX [IX_Empleados_SubDepartamentoID] ON [dbo].[Empleados]
(
	[SubDepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Subdepartamentos_DepartamentoID]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE NONCLUSTERED INDEX [IX_Subdepartamentos_DepartamentoID] ON [dbo].[Subdepartamentos]
(
	[DepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sueldos_EmpleadoID]    Script Date: 5/15/2024 8:35:53 PM ******/
CREATE NONCLUSTERED INDEX [IX_Sueldos_EmpleadoID] ON [dbo].[Sueldos]
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Departamentos_DepartamentoID] FOREIGN KEY([DepartamentoID])
REFERENCES [dbo].[Departamentos] ([DepartamentoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Departamentos_DepartamentoID]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_RolesEmpleados_RolEmpleadoID] FOREIGN KEY([RolEmpleadoID])
REFERENCES [dbo].[RolesEmpleados] ([RolEmpleadoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_RolesEmpleados_RolEmpleadoID]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Subdepartamentos_SubDepartamentoID] FOREIGN KEY([SubDepartamentoID])
REFERENCES [dbo].[Subdepartamentos] ([SubDepartamentoID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Subdepartamentos_SubDepartamentoID]
GO
ALTER TABLE [dbo].[Subdepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_Subdepartamentos_Departamentos_DepartamentoID] FOREIGN KEY([DepartamentoID])
REFERENCES [dbo].[Departamentos] ([DepartamentoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Subdepartamentos] CHECK CONSTRAINT [FK_Subdepartamentos_Departamentos_DepartamentoID]
GO
ALTER TABLE [dbo].[Sueldos]  WITH CHECK ADD  CONSTRAINT [FK_Sueldos_Empleados_EmpleadoID] FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sueldos] CHECK CONSTRAINT [FK_Sueldos_Empleados_EmpleadoID]
GO
USE [master]
GO
ALTER DATABASE [NTS] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [Condominio]    Script Date: 28/08/2017 18:38:52 ******/
CREATE DATABASE [Condominio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Condominio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Condominio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Condominio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Condominio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Condominio] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Condominio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Condominio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Condominio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Condominio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Condominio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Condominio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Condominio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Condominio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Condominio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Condominio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Condominio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Condominio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Condominio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Condominio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Condominio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Condominio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Condominio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Condominio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Condominio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Condominio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Condominio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Condominio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Condominio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Condominio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Condominio] SET  MULTI_USER 
GO
ALTER DATABASE [Condominio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Condominio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Condominio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Condominio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Condominio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Condominio] SET QUERY_STORE = OFF
GO
USE [Condominio]
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
USE [Condominio]
GO
/****** Object:  Table [dbo].[AreaDeLazer]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreaDeLazer](
	[IdAreaDeLazer] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](max) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_AreaDeLazer] PRIMARY KEY CLUSTERED 
(
	[IdAreaDeLazer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[IdCargo] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descrição] [varchar](max) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[IdCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[IdFornecedor] [int] NOT NULL,
	[IdFuncionario] [int] NOT NULL,
	[Nome] [varchar](80) NOT NULL,
	[Cnpj] [char](11) NOT NULL,
	[Telefone] [char](10) NOT NULL,
	[Celular] [char](11) NULL,
	[Email] [varchar](100) NOT NULL,
	[Descricao] [varchar](max) NOT NULL,
	[Ativo] [char](8) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[IdFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[IdFuncionario] [int] NOT NULL,
	[IdCargo] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[DataDeNascimento] [datetime] NOT NULL,
	[Telefone] [char](10) NULL,
	[Celular] [char](10) NULL,
	[Email] [varchar](100) NULL,
	[Cpf] [char](11) NOT NULL,
	[Ativo] [char](8) NOT NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[IdFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Informativo]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informativo](
	[IdInformativo] [int] NOT NULL,
	[IdEntidade] [int] NULL,
	[TipoInformante] [nchar](10) NOT NULL,
	[Descricao] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Informativo] PRIMARY KEY CLUSTERED 
(
	[IdInformativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Morador]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Morador](
	[IdMorador] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[DataDeNascimento] [datetime] NOT NULL,
	[Telefone] [char](10) NULL,
	[Celular] [char](11) NULL,
	[Email] [varchar](150) NULL,
	[Cpf] [char](11) NOT NULL,
	[Ativo] [char](8) NOT NULL,
 CONSTRAINT [PK_Morador] PRIMARY KEY CLUSTERED 
(
	[IdMorador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Regimento]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regimento](
	[IdRegimento] [int] NOT NULL,
	[IdFuncionario] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](max) NULL,
	[Documento] [varbinary](max) NULL,
 CONSTRAINT [PK_Regimento] PRIMARY KEY CLUSTERED 
(
	[IdRegimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReservaAreaDeLazer]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaAreaDeLazer](
	[IdReservaAreaDeLazer] [int] NOT NULL,
	[IdMorador] [int] NOT NULL,
	[IdAreaDeLazer] [int] NOT NULL,
	[Descricao] [varchar](max) NULL,
	[Reservado] [bit] NOT NULL,
 CONSTRAINT [PK_ReservaAreaDeLazer] PRIMARY KEY CLUSTERED 
(
	[IdReservaAreaDeLazer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioFuncionario]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioFuncionario](
	[IdUsuario] [int] NOT NULL,
	[IdFuncionario] [int] NOT NULL,
	[Login] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[Ativo] [char](8) NOT NULL,
 CONSTRAINT [PK_UsuarioFuncionario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioMorador]    Script Date: 28/08/2017 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioMorador](
	[IdUsuario] [int] NOT NULL,
	[IdMorador] [int] NOT NULL,
	[Login] [varchar](20) NOT NULL,
	[senha] [nchar](20) NOT NULL,
	[Ativo] [char](8) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Funcionario] FOREIGN KEY([IdFuncionario])
REFERENCES [dbo].[Funcionario] ([IdFuncionario])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_Funcionario]
GO
ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD  CONSTRAINT [FK_Funcionario_Cargo1] FOREIGN KEY([IdCargo])
REFERENCES [dbo].[Cargo] ([IdCargo])
GO
ALTER TABLE [dbo].[Funcionario] CHECK CONSTRAINT [FK_Funcionario_Cargo1]
GO
ALTER TABLE [dbo].[Informativo]  WITH CHECK ADD  CONSTRAINT [FK_Informativo_Funcionario] FOREIGN KEY([IdEntidade])
REFERENCES [dbo].[Funcionario] ([IdFuncionario])
GO
ALTER TABLE [dbo].[Informativo] CHECK CONSTRAINT [FK_Informativo_Funcionario]
GO
ALTER TABLE [dbo].[Informativo]  WITH CHECK ADD  CONSTRAINT [FK_Informativo_Morador] FOREIGN KEY([IdEntidade])
REFERENCES [dbo].[Morador] ([IdMorador])
GO
ALTER TABLE [dbo].[Informativo] CHECK CONSTRAINT [FK_Informativo_Morador]
GO
ALTER TABLE [dbo].[Regimento]  WITH CHECK ADD  CONSTRAINT [FK_Regimento_Funcionario] FOREIGN KEY([IdRegimento])
REFERENCES [dbo].[Funcionario] ([IdFuncionario])
GO
ALTER TABLE [dbo].[Regimento] CHECK CONSTRAINT [FK_Regimento_Funcionario]
GO
ALTER TABLE [dbo].[ReservaAreaDeLazer]  WITH CHECK ADD  CONSTRAINT [FK_ReservaAreaDeLazer_AreaDeLazer] FOREIGN KEY([IdMorador])
REFERENCES [dbo].[AreaDeLazer] ([IdAreaDeLazer])
GO
ALTER TABLE [dbo].[ReservaAreaDeLazer] CHECK CONSTRAINT [FK_ReservaAreaDeLazer_AreaDeLazer]
GO
ALTER TABLE [dbo].[ReservaAreaDeLazer]  WITH CHECK ADD  CONSTRAINT [FK_ReservaAreaDeLazer_Morador] FOREIGN KEY([IdMorador])
REFERENCES [dbo].[Morador] ([IdMorador])
GO
ALTER TABLE [dbo].[ReservaAreaDeLazer] CHECK CONSTRAINT [FK_ReservaAreaDeLazer_Morador]
GO
ALTER TABLE [dbo].[UsuarioFuncionario]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioFuncionario_Funcionario] FOREIGN KEY([IdFuncionario])
REFERENCES [dbo].[Funcionario] ([IdFuncionario])
GO
ALTER TABLE [dbo].[UsuarioFuncionario] CHECK CONSTRAINT [FK_UsuarioFuncionario_Funcionario]
GO
ALTER TABLE [dbo].[UsuarioMorador]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioMorador_Morador1] FOREIGN KEY([IdMorador])
REFERENCES [dbo].[Morador] ([IdMorador])
GO
ALTER TABLE [dbo].[UsuarioMorador] CHECK CONSTRAINT [FK_UsuarioMorador_Morador1]
GO
USE [master]
GO
ALTER DATABASE [Condominio] SET  READ_WRITE 
GO

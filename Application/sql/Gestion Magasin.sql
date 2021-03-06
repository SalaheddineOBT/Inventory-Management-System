USE [master]
GO
/****** Object:  Database [GestionMagasin]    Script Date: 02/06/2021 09:04:08 ******/
CREATE DATABASE [GestionMagasin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionMagasin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestionMagasin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionMagasin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestionMagasin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestionMagasin] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionMagasin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionMagasin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionMagasin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionMagasin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionMagasin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionMagasin] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionMagasin] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GestionMagasin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionMagasin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionMagasin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionMagasin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionMagasin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionMagasin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionMagasin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionMagasin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionMagasin] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestionMagasin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionMagasin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionMagasin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionMagasin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionMagasin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionMagasin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionMagasin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionMagasin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionMagasin] SET  MULTI_USER 
GO
ALTER DATABASE [GestionMagasin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionMagasin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionMagasin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionMagasin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionMagasin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionMagasin] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionMagasin] SET QUERY_STORE = OFF
GO
USE [GestionMagasin]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 02/06/2021 09:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[CodeArticle] [varchar](20) NOT NULL,
	[Designation] [varchar](500) NULL,
	[Unite] [char](2) NULL,
	[Famile] [char](2) NULL,
	[CodeCategorie] [char](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authentification]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authentification](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](500) NULL,
	[Password] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorie]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorie](
	[CODE] [char](3) NOT NULL,
	[LIBELLE] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commandes]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commandes](
	[CodeCommande] [int] IDENTITY(1,1) NOT NULL,
	[CodeFournisseur] [int] NULL,
	[DateCommande] [datetime] NULL,
	[dateLivraison] [datetime] NULL,
	[EtatCommande] [varchar](500) NULL,
	[MontantTTC] [float] NULL,
	[Remise] [float] NULL,
	[MontantNet] [float] NULL,
	[TVA] [float] NULL,
	[PortEmballage] [float] NULL,
	[MTVA] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrée]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrée](
	[CodeEntrée] [int] NOT NULL,
	[DateEntrée] [datetime] NULL,
	[QTEEntrée] [int] NULL,
	[CodeMagasin] [int] NULL,
	[CodeFournisseur] [int] NULL,
	[Observation] [varchar](500) NULL,
	[CodeArticle] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeEntrée] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etablissement]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etablissement](
	[codeEtab] [varchar](10) NOT NULL,
	[designation] [varchar](500) NULL,
	[Adresse] [varchar](500) NULL,
	[TEL] [varchar](500) NULL,
	[Ville] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codeEtab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familles]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familles](
	[CodeFamile] [char](2) NOT NULL,
	[Designation] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeFamile] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornisseurs]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornisseurs](
	[IdFornisseur] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](500) NULL,
	[Adress] [varchar](500) NULL,
	[RaisonSocial] [varchar](500) NULL,
	[Tele] [varchar](500) NULL,
	[Fax] [varchar](500) NULL,
	[Ville] [varchar](500) NULL,
	[Email] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFornisseur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LigneCommandes]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LigneCommandes](
	[CodeLign] [int] IDENTITY(1,1) NOT NULL,
	[CodeCommande] [int] NULL,
	[CodeArticle] [varchar](20) NULL,
	[MontantHT] [float] NULL,
	[Observation] [varchar](500) NULL,
	[QteCommandé] [int] NULL,
	[Prix] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeLign] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LignesTransfere]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LignesTransfere](
	[codeLigne] [int] IDENTITY(1,1) NOT NULL,
	[CodeArticle] [varchar](20) NULL,
	[CodeTrans] [int] NULL,
	[QuantityNeuve] [int] NULL,
	[QuantityReemploi] [int] NULL,
	[ValeurTransfert] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[codeLigne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Magasins]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Magasins](
	[CodeMagasin] [int] IDENTITY(1,1) NOT NULL,
	[Libellé] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeMagasin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PointConsommation]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PointConsommation](
	[NumCons] [int] NOT NULL,
	[Libellé] [varchar](500) NULL,
	[Enseignant] [varchar](500) NULL,
	[dateC] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[NumCons] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receptions]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receptions](
	[numReception] [int] IDENTITY(1,1) NOT NULL,
	[CodeCommande] [int] NULL,
	[CodeArticle] [varchar](20) NULL,
	[CodeFournisseur] [int] NULL,
	[DateReception] [datetime] NULL,
	[QTELivree] [int] NULL,
	[R_A_L] [int] NULL,
	[Montant] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[numReception] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sortie]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sortie](
	[CodeSortie] [int] NOT NULL,
	[DateSortie] [datetime] NULL,
	[CodeArticle] [varchar](20) NULL,
	[CodePointConsommation] [int] NULL,
	[CodeMagasin] [int] NULL,
	[QTESortie] [int] NULL,
	[Observation] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeSortie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stocks]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stocks](
	[CodeArticle] [varchar](20) NOT NULL,
	[Prix] [float] NULL,
	[QteActuel] [float] NULL,
	[QteEntré] [float] NULL,
	[QteSortie] [float] NULL,
	[ValeurEntré] [float] NULL,
	[ValeurSortie] [float] NULL,
	[RemainingStock] [float] NULL,
	[Statut] [bit] NULL,
	[CodeMagasin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transferts]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transferts](
	[CodeTrans] [int] IDENTITY(1,1) NOT NULL,
	[DateTrans] [datetime] NULL,
	[TypeTransfer] [int] NULL,
	[C_Magasin] [int] NULL,
	[C_PointCons] [int] NULL,
	[C_Etablissement] [varchar](10) NULL,
	[MontantHT] [float] NULL,
	[C_PointCons_Autre] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeTrans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypesTransferts]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypesTransferts](
	[CodeType] [int] IDENTITY(1,1) NOT NULL,
	[Libellé] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitéMesures]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitéMesures](
	[CodeUnite] [char](2) NOT NULL,
	[Désignation] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeUnite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Villes]    Script Date: 02/06/2021 09:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Villes](
	[CodeV] [int] IDENTITY(1,1) NOT NULL,
	[NomV] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Articles] ([CodeArticle], [Designation], [Unite], [Famile], [CodeCategorie]) VALUES (N'cdArt01', N'des.....', N'UN', N'PO', N'ALT')
INSERT [dbo].[Articles] ([CodeArticle], [Designation], [Unite], [Famile], [CodeCategorie]) VALUES (N'cdArt02', N'des..222222...', N'UN', N'PO', N'ALT')
GO
SET IDENTITY_INSERT [dbo].[Authentification] ON 

INSERT [dbo].[Authentification] ([Code], [Email], [Password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Authentification] OFF
GO
INSERT [dbo].[Categorie] ([CODE], [LIBELLE]) VALUES (N'ALC', N'ACIER LAMINE CARRE')
INSERT [dbo].[Categorie] ([CODE], [LIBELLE]) VALUES (N'ALP', N'ACIER LAMINE PLAT')
INSERT [dbo].[Categorie] ([CODE], [LIBELLE]) VALUES (N'ALR', N'ACIER LAMINE ROND HEXAGONAUX FERS A BETON')
INSERT [dbo].[Categorie] ([CODE], [LIBELLE]) VALUES (N'ALT', N'ACIER LAMINE TOLE')
GO
SET IDENTITY_INSERT [dbo].[Commandes] ON 

INSERT [dbo].[Commandes] ([CodeCommande], [CodeFournisseur], [DateCommande], [dateLivraison], [EtatCommande], [MontantTTC], [Remise], [MontantNet], [TVA], [PortEmballage], [MTVA]) VALUES (3, 1, CAST(N'2021-06-01T23:53:11.930' AS DateTime), NULL, N'Validé', NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Commandes] OFF
GO
INSERT [dbo].[Familles] ([CodeFamile], [Designation]) VALUES (N'MO', N'Matière D’oeuvre')
INSERT [dbo].[Familles] ([CodeFamile], [Designation]) VALUES (N'PO', N'Petit Outillage')
GO
SET IDENTITY_INSERT [dbo].[Fornisseurs] ON 

INSERT [dbo].[Fornisseurs] ([IdFornisseur], [Nom], [Adress], [RaisonSocial], [Tele], [Fax], [Ville], [Email]) VALUES (1, N'designation', N'Adresse Entreprise', N'Informatique', N'0696177562', N'0512163298', N'Kènitra', N'Div3Soft@gmail.com')
INSERT [dbo].[Fornisseurs] ([IdFornisseur], [Nom], [Adress], [RaisonSocial], [Tele], [Fax], [Ville], [Email]) VALUES (2, N'design', N'adresse', N'Ressaux', N'0696177520', N'', N'Errachidia', N'')
INSERT [dbo].[Fornisseurs] ([IdFornisseur], [Nom], [Adress], [RaisonSocial], [Tele], [Fax], [Ville], [Email]) VALUES (3, N'dix', N'dix', N'rs', N'0602', N'0502322556', N'Fnideq', N'')
INSERT [dbo].[Fornisseurs] ([IdFornisseur], [Nom], [Adress], [RaisonSocial], [Tele], [Fax], [Ville], [Email]) VALUES (8, N'Top SoftWar', N'adresse', N'', N'0655844166', N'', N'Safi', N'Top02@gmail.com')
SET IDENTITY_INSERT [dbo].[Fornisseurs] OFF
GO
SET IDENTITY_INSERT [dbo].[LignesTransfere] ON 

INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (8, N'cdArt01', 19, 20, 0, 10006)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (10, N'cdArt01', 22, 30, 0, 15009)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (11, N'cdArt01', 23, 30, 0, 15009)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (12, N'cdArt02', 23, 50, 0, 37515)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (13, N'cdArt01', 24, 100, 0, 50030)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (14, N'cdArt02', 24, 200, 0, 150060)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (15, N'cdArt01', 27, 8, 0, 4002.39990234375)
INSERT [dbo].[LignesTransfere] ([codeLigne], [CodeArticle], [CodeTrans], [QuantityNeuve], [QuantityReemploi], [ValeurTransfert]) VALUES (16, N'cdArt02', 27, 8, 0, 6002.39990234375)
SET IDENTITY_INSERT [dbo].[LignesTransfere] OFF
GO
SET IDENTITY_INSERT [dbo].[Magasins] ON 

INSERT [dbo].[Magasins] ([CodeMagasin], [Libellé]) VALUES (1, N'OFPPT TEXTILE TANGER')
SET IDENTITY_INSERT [dbo].[Magasins] OFF
GO
INSERT [dbo].[PointConsommation] ([NumCons], [Libellé], [Enseignant], [dateC]) VALUES (10, N'kjhkjh', N'klhkjh', CAST(N'2021-05-20T20:57:40.460' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Transferts] ON 

INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (19, CAST(N'2021-05-21T01:05:12.323' AS DateTime), 1, 1, 10, NULL, 25012, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (21, CAST(N'2021-05-21T01:10:05.697' AS DateTime), 2, 1, 10, NULL, 30015, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (22, CAST(N'2021-05-21T01:11:45.317' AS DateTime), 2, 1, 10, NULL, 22512, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (23, CAST(N'2021-05-21T01:14:51.797' AS DateTime), 1, 1, 10, NULL, 52524, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (24, CAST(N'2021-05-21T11:01:25.443' AS DateTime), 2, 1, 10, NULL, 200090, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (25, CAST(N'2021-05-21T14:42:51.803' AS DateTime), 2, 1, 10, NULL, 10004.2, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (26, CAST(N'2021-05-21T14:49:31.787' AS DateTime), 2, 1, 10, NULL, 2501.2, NULL)
INSERT [dbo].[Transferts] ([CodeTrans], [DateTrans], [TypeTransfer], [C_Magasin], [C_PointCons], [C_Etablissement], [MontantHT], [C_PointCons_Autre]) VALUES (27, CAST(N'2021-05-21T14:51:50.643' AS DateTime), 1, 1, 10, NULL, 10004.8, NULL)
SET IDENTITY_INSERT [dbo].[Transferts] OFF
GO
SET IDENTITY_INSERT [dbo].[TypesTransferts] ON 

INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (1, N'TRANSFERT MAGASIN POINT DE CONSOMMATION')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (2, N'TRANSFERT POINT DE CONSOMMATION VERS MAGASIN')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (3, N'TRANSFERT POINT DE CONSOMMATION VERS UN AUTRE')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (4, N'TRANSFERT INTER MAGASINS')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (5, N'DEFICIT DE STOCK')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (6, N'BONI D`NVENTAIRE')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (7, N'TRANSFERT INTER ETABLISSEMENTS')
INSERT [dbo].[TypesTransferts] ([CodeType], [Libellé]) VALUES (8, N'TRANSFERT APRES INVENTAIRE')
SET IDENTITY_INSERT [dbo].[TypesTransferts] OFF
GO
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'CT', N'CENT')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'KG', N'KILOGRAMME')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'LT', N'LITRE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'M2', N'METRE CARRE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'M3', N'METRE CUBE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'ME', N'MILLE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'ML', N'METRE LINEAIRE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'P2', N'PIED CARRE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'TN', N'TONNE')
INSERT [dbo].[UnitéMesures] ([CodeUnite], [Désignation]) VALUES (N'UN', N'UNITE')
GO
SET IDENTITY_INSERT [dbo].[Villes] ON 

INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (1, N'Casablaca')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (2, N'Marrakech')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (3, N'Rabat')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (4, N'Fès')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (5, N'Agadir')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (6, N'Meknès')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (7, N'Essouira')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (8, N'Tétouan')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (9, N'Oujda')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (10, N'Salè')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (11, N'Safi')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (12, N'Chefchaouen')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (13, N'El-Jadida')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (14, N'Mohamédia')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (15, N'Taza')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (16, N'Kènitra')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (17, N'Errachidia')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (18, N'Khènifra')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (19, N'Fnideq')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (20, N'Zagora')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (21, N'Guelmim')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (22, N'Oualidia')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (23, N'Mehdia')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (24, N'El-Hajeb')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (25, N'Tan-Tan')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (26, N'Ifrane')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (27, N'Tarfaya')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (28, N'Skhirat')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (29, N'Sidi-Ifni')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (30, N'Nador')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (31, N'Ourzazate')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (32, N'Assilah')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (33, N'Saidia')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (34, N'Al Hoceima')
INSERT [dbo].[Villes] ([CodeV], [NomV]) VALUES (35, N'Settat')
SET IDENTITY_INSERT [dbo].[Villes] OFF
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD FOREIGN KEY([CodeCategorie])
REFERENCES [dbo].[Categorie] ([CODE])
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD FOREIGN KEY([Famile])
REFERENCES [dbo].[Familles] ([CodeFamile])
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD FOREIGN KEY([Unite])
REFERENCES [dbo].[UnitéMesures] ([CodeUnite])
GO
ALTER TABLE [dbo].[Commandes]  WITH CHECK ADD FOREIGN KEY([CodeFournisseur])
REFERENCES [dbo].[Fornisseurs] ([IdFornisseur])
GO
ALTER TABLE [dbo].[Entrée]  WITH CHECK ADD FOREIGN KEY([CodeFournisseur])
REFERENCES [dbo].[Fornisseurs] ([IdFornisseur])
GO
ALTER TABLE [dbo].[Entrée]  WITH CHECK ADD FOREIGN KEY([CodeMagasin])
REFERENCES [dbo].[Magasins] ([CodeMagasin])
GO
ALTER TABLE [dbo].[Entrée]  WITH CHECK ADD  CONSTRAINT [FK_Ent_Art] FOREIGN KEY([CodeArticle])
REFERENCES [dbo].[Articles] ([CodeArticle])
GO
ALTER TABLE [dbo].[Entrée] CHECK CONSTRAINT [FK_Ent_Art]
GO
ALTER TABLE [dbo].[LigneCommandes]  WITH CHECK ADD FOREIGN KEY([CodeArticle])
REFERENCES [dbo].[Articles] ([CodeArticle])
GO
ALTER TABLE [dbo].[LigneCommandes]  WITH CHECK ADD FOREIGN KEY([CodeCommande])
REFERENCES [dbo].[Commandes] ([CodeCommande])
GO
ALTER TABLE [dbo].[LignesTransfere]  WITH CHECK ADD FOREIGN KEY([CodeArticle])
REFERENCES [dbo].[Articles] ([CodeArticle])
GO
ALTER TABLE [dbo].[LignesTransfere]  WITH CHECK ADD FOREIGN KEY([CodeTrans])
REFERENCES [dbo].[Transferts] ([CodeTrans])
GO
ALTER TABLE [dbo].[Receptions]  WITH CHECK ADD FOREIGN KEY([CodeArticle])
REFERENCES [dbo].[Articles] ([CodeArticle])
GO
ALTER TABLE [dbo].[Receptions]  WITH CHECK ADD FOREIGN KEY([CodeCommande])
REFERENCES [dbo].[Commandes] ([CodeCommande])
GO
ALTER TABLE [dbo].[Receptions]  WITH CHECK ADD FOREIGN KEY([CodeFournisseur])
REFERENCES [dbo].[Fornisseurs] ([IdFornisseur])
GO
ALTER TABLE [dbo].[Sortie]  WITH CHECK ADD FOREIGN KEY([CodeArticle])
REFERENCES [dbo].[Articles] ([CodeArticle])
GO
ALTER TABLE [dbo].[Sortie]  WITH CHECK ADD FOREIGN KEY([CodeMagasin])
REFERENCES [dbo].[Magasins] ([CodeMagasin])
GO
ALTER TABLE [dbo].[Sortie]  WITH CHECK ADD FOREIGN KEY([CodePointConsommation])
REFERENCES [dbo].[PointConsommation] ([NumCons])
GO
ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD FOREIGN KEY([CodeArticle])
REFERENCES [dbo].[Articles] ([CodeArticle])
GO
ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD  CONSTRAINT [fk_mag_stck] FOREIGN KEY([CodeMagasin])
REFERENCES [dbo].[Magasins] ([CodeMagasin])
GO
ALTER TABLE [dbo].[Stocks] CHECK CONSTRAINT [fk_mag_stck]
GO
ALTER TABLE [dbo].[Transferts]  WITH CHECK ADD FOREIGN KEY([C_Etablissement])
REFERENCES [dbo].[Etablissement] ([codeEtab])
GO
ALTER TABLE [dbo].[Transferts]  WITH CHECK ADD FOREIGN KEY([C_Magasin])
REFERENCES [dbo].[Magasins] ([CodeMagasin])
GO
ALTER TABLE [dbo].[Transferts]  WITH CHECK ADD FOREIGN KEY([C_PointCons])
REFERENCES [dbo].[PointConsommation] ([NumCons])
GO
ALTER TABLE [dbo].[Transferts]  WITH CHECK ADD FOREIGN KEY([TypeTransfer])
REFERENCES [dbo].[TypesTransferts] ([CodeType])
GO
ALTER TABLE [dbo].[Transferts]  WITH CHECK ADD  CONSTRAINT [FK_PoitAutre] FOREIGN KEY([C_PointCons_Autre])
REFERENCES [dbo].[PointConsommation] ([NumCons])
GO
ALTER TABLE [dbo].[Transferts] CHECK CONSTRAINT [FK_PoitAutre]
GO
ALTER TABLE [dbo].[Commandes]  WITH CHECK ADD  CONSTRAINT [ch_ck] CHECK  (([EtatCommande]='Reseptioné' OR [EtatCommande]='Validé' OR [EtatCommande]='En Préparation'))
GO
ALTER TABLE [dbo].[Commandes] CHECK CONSTRAINT [ch_ck]
GO
USE [master]
GO
ALTER DATABASE [GestionMagasin] SET  READ_WRITE 
GO

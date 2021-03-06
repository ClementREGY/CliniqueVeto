USE [CliniqueVeto]
GO
/****** Object:  Table [dbo].[Vaccins]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vaccins](
	[CodeVaccin] [uniqueidentifier] NOT NULL,
	[NomVaccin] [varchar](30) NOT NULL,
	[QuantiteStock] [int] NOT NULL,
	[PeriodeValidite] [int] NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_Vaccins] PRIMARY KEY NONCLUSTERED 
(
	[CodeVaccin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'de1d881e-1254-4ddc-97b0-8ff3e4767c46', N'Vache folle', 6, 12, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'f30bb17f-4c50-4f9a-9822-875729b44c34', N'ZK36', 15, 18, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'1578360b-a7cd-4fa1-98c4-9803a031c2aa', N'Rage', 0, 12, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'd600b143-f685-4b9c-ba47-6fe842a62d82', N'DT', 3, 12, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'2d7f9d53-fab3-4017-b903-34ef72c02137', N'Antirabique', 10, 12, 0)
/****** Object:  Table [dbo].[Races]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Races](
	[Race] [varchar](20) NOT NULL,
	[Espece] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Races] PRIMARY KEY NONCLUSTERED 
(
	[Race] ASC,
	[Espece] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Angora', N'Chat')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Batard', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Berger Allemand', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Bourgogne', N'Escargot')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Canari', N'Oiseau')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Caniche', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Chihuahua', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Chinchila', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Cochon d''Inde', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Colombe', N'Oiseau')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Écureuil', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Européen', N'Chat')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Gerbille', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Hamster Angora', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Hamster Russe', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Iguane', N'Reptile')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Labrador', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Lapin', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Maine Coon', N'Chat')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Marine', N'Tortue')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Normand', N'Escargot')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Octodon', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Perroquet', N'Oiseau')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Perruche', N'Oiseau')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Persan', N'Chat')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Rat', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Serpent', N'Reptile')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Setter', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Siamois', N'Chat')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Souris', N'Rongeur')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Terrestre', N'Tortue')
/****** Object:  Table [dbo].[Logins]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__Logins__3214EC2738996AB5] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Logins] ON
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (1, N'test', N'test')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (2, N'BOSAPIN', N'PIN')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (3, N'DE CAJOU', N'NOIX')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (4, N'MALALANICH', N'DOG')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (5, N'AIMONE', N'FLEUR')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (6, N'TOURNE', N'EOLE')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (7, N'SION', N'PARDON')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (13, N'REGY', N'regy')
INSERT [dbo].[Logins] ([ID], [Login], [Password]) VALUES (14, N'L''HÉRAULT', N'lute')
SET IDENTITY_INSERT [dbo].[Logins] OFF
/****** Object:  Table [dbo].[Clients]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clients](
	[CodeClient] [uniqueidentifier] NOT NULL,
	[NomClient] [varchar](20) NOT NULL,
	[PrenomClient] [varchar](20) NOT NULL,
	[Adresse1] [varchar](30) NULL,
	[Adresse2] [varchar](30) NULL,
	[CodePostal] [char](6) NULL,
	[Ville] [varchar](25) NULL,
	[NumTel] [varchar](15) NULL,
	[Assurance] [varchar](30) NULL,
	[Email] [varchar](20) NULL,
	[Remarque] [text] NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY NONCLUSTERED 
(
	[CodeClient] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'dcef48b7-1460-4ea4-b619-6ae6e5986078', N'Dupond', N'Jean', N'20 rue de la paix', NULL, N'44000 ', N'Nantes', N'02.40.41.42.43', N'MAAF', N'JDupont@free.fr', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'aad6a853-20a9-482e-9064-ec77751edb18', N'Durand', N'Albert', N'17 rue des pins', NULL, N'44300 ', N'La Baule', N'02.51.12.45.63', N'GMF', N'', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'bb556151-0ab5-401d-b1db-0ca4db11c736', N'Dupond', N'Paul', N'22 rue de la mer', NULL, N'29000 ', N'Brest', N'02.99.27.45.62', N'MAIF', N'', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', N'Duboulon', N'Franck', N'84 rue de Paris', NULL, N'44000 ', N'Nantes', N'', N'', N'', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'184a67d0-fe10-4136-8e74-415019577a27', N'Bonnet', N'Jean', N'18 rue des fleurs', NULL, N'17000 ', N'La Rochelle', N'', N'', N'', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'4696af33-cfb5-4b4c-8609-bfe23a2da5b2', N'Clinton', N'Bill', N'1 rue des Fraises', NULL, N'75000 ', N'Paris', N'', N'', N'', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'a02d8b86-77c3-412f-9e45-7622316576bf', N'ARCHIVE', N'Client', N'1 rue des archives', NULL, N'75000 ', N'Paris', N'', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', N'A ARCHIVER', N'Client avec animaux', N'1 rue des archives', NULL, N'75000 ', N'Paris', N'', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'9d2f8dd9-c7a7-4446-b05b-371f9d81c06d', N'A ARCHIVER 2', N'Client avec animaux', N'1 rue des archives', NULL, N'75000 ', N'Paris', N'', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'9a6203a5-040b-411b-8e58-457deb959d02', N'REGY', N'Clément', N'15 Rue de la Jute', N'', N'44640 ', N'Guet de Davon', N'06.45.78.32.20', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'f6dce7e2-fa12-4d28-89d1-51e499050450', N'TEST', N'Test', N'Test', N'', N'46520 ', N'Test', N'12.45.78.98.65', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'6954c334-952b-4cbc-ace5-7a08256d201b', N'P', N'pp', N'pppp', N'', N'45621 ', N'pp', N'....', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'5b65ab25-a492-4412-bfe0-1f7746bad05a', N'L''HÉRAULT', N'Julie', N'10 Rue', N'', N'44640 ', N'Test', N'45.78.56.32.45', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'1d03d831-0853-4ee7-aba7-539bd872a7cf', N'AA', N'aa', N'aa', N'a', N'45780 ', N'aaa', N'....', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'e0ba8b52-5cf8-4d6b-b505-ddba299898df', N'AA', N'aa', N'aa', N'', N'45871 ', N'aa', N'....', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'263a648b-8f98-43e3-aa32-c744fcff275f', N'RR', N'ee', N'ee', N'', N'45785 ', N'aaaaa', N'....', N'', N'', NULL, 1)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', N'L''HÉRAULT', N'Julie', N'1 Rue Principale', N'', N'44640 ', N'Guet de Davon', N'06.45.78.65.32', N'MMA', N'julie.lherault@ici.f', NULL, 0)
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'e6f829f9-8c23-4771-aaf2-5ba447cec53c', N'PP', N'p', N'pp', N'', N'45874 ', N'pp', N'....', N'', N'', NULL, 1)
/****** Object:  StoredProcedure [dbo].[ajout_vaccin]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un vaccin      **********************************/
/***************************************************************************************/
/*	nom du vaccin
	periode de validite
	quantite en stock
*/
CREATE PROCEDURE [dbo].[ajout_vaccin] 
	@nomvaccin varchar(30),
	@periodevalidite int,
	@quantite int
 AS
DECLARE @id uniqueidentifier;
SET @id = newid();
insert into vaccins (CodeVaccin,nomvaccin,periodevalidite,quantitestock,archive) values(@id,@nomvaccin,@periodevalidite,@quantite,0);
SELECT @id;
GO
/****** Object:  StoredProcedure [dbo].[ajout_race]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un couple race/espece           *****************/
/***************************************************************************************/
CREATE PROCEDURE [dbo].[ajout_race] @race varchar(20),@espece varchar(20)
 AS
insert into races (race,espece) values(@race,@espece)
GO
/****** Object:  StoredProcedure [dbo].[ajout_login]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ajout_login]
    @login VARCHAR(30), 
    @password VARCHAR(20),
    @UserId int OUTPUT
AS
BEGIN
	INSERT INTO Logins (Login, Password) VALUES (@login, @password);        
	SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[ajout_client]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un client ***************************************/
/***************************************************************************************/
/*	nom
	prenom
	adresse
	code postal
	ville
	tel
	assurance
	mail
	archive
*/
CREATE PROCEDURE [dbo].[ajout_client]  
	@nom varchar(20),
	@prenom varchar(20),
	@add varchar(30),
	@add2 varchar(30),
	@cp varchar(6),
	@ville varchar(25),
	@tel varchar(15),
	@ass varchar(30),
	@mail varchar(20),
	@arch int
AS
DECLARE @id uniqueidentifier;
SET @id = newid();
insert into clients (CodeClient,nomclient,prenomclient,adresse1,adresse2,codepostal,ville,numtel,assurance,email,archive) 
              values(@id,@nom,@prenom,@add,@add2,@cp,@ville,@tel,@ass,@mail,@arch);
SELECT @id;
GO
/****** Object:  Table [dbo].[Factures]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factures](
	[NumFacture] [uniqueidentifier] NOT NULL,
	[DateFacture] [datetime] NOT NULL,
	[CodeClient] [uniqueidentifier] NOT NULL,
	[TotalFacture] [money] NULL,
	[Archive] [bit] NOT NULL,
	[Etat] [int] NOT NULL,
	[RappelEnvoye] [datetime] NULL,
 CONSTRAINT [PK_Factures] PRIMARY KEY NONCLUSTERED 
(
	[NumFacture] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'891e88f0-684a-4c7c-bf8d-ac9f5f5f77f5', CAST(0x0000A42F00A4CB80 AS DateTime), N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', 22.0000, 0, 2, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'4c722da4-996f-4d67-b765-dc5f00766b8b', CAST(0x0000A2A800B54640 AS DateTime), N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', 22.0000, 0, 2, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'2bfc7fbd-f31f-4526-960c-2d1d83fcf702', CAST(0x0000A39B00A4CB80 AS DateTime), N'9d2f8dd9-c7a7-4446-b05b-371f9d81c06d', 22.0000, 0, 1, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'743eb361-cb76-47a0-88c9-b7254797792d', CAST(0x0000A43B0116BC40 AS DateTime), N'184a67d0-fe10-4136-8e74-415019577a27', 59.0000, 0, 0, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'41d9d7ac-33ac-40a7-864b-2998a1a15ce8', CAST(0x0000A43B011E2E28 AS DateTime), N'184a67d0-fe10-4136-8e74-415019577a27', 59.0000, 0, 1, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'63e20846-0354-4d2e-8da8-63e5a01f289e', CAST(0x0000A43C00BB41F7 AS DateTime), N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', 102.0000, 0, 0, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'c4cfad46-aa82-4a4b-93dd-105ebe124ed7', CAST(0x0000A43C00BBA8FD AS DateTime), N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', 30.0000, 0, 1, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'f6af22aa-5066-4b4c-a8d6-b0d5f97952b3', CAST(0x0000A43C00BC1FF7 AS DateTime), N'dcef48b7-1460-4ea4-b619-6ae6e5986078', 84.0000, 0, 0, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'600a2624-ed39-4845-9d1b-46f25be8b63b', CAST(0x0000A43D00B62B26 AS DateTime), N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', 18.0000, 0, 0, NULL)
/****** Object:  Table [dbo].[Baremes]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Baremes](
	[CodeGroupement] [char](3) NOT NULL,
	[DateVigueur] [char](8) NOT NULL,
	[TypeActe] [varchar](4) NOT NULL,
	[Libelle] [varchar](30) NULL,
	[TarifFixe] [money] NOT NULL,
	[TarifMini] [money] NULL,
	[TarifMaxi] [money] NULL,
	[CodeVaccin] [uniqueidentifier] NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_Baremes] PRIMARY KEY NONCLUSTERED 
(
	[CodeGroupement] ASC,
	[DateVigueur] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'103', N'03/01/14', N'VACC', N'Vaccination DT', 10.0000, NULL, NULL, N'd600b143-f685-4b9c-ba47-6fe842a62d82', 1)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'104', N'03/01/14', N'VACC', N'Vaccination vache folle', 13.0000, NULL, NULL, N'de1d881e-1254-4ddc-97b0-8ff3e4767c46', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'105', N'03/01/14', N'VACC', N'Vaccination rage', 22.0000, NULL, NULL, N'1578360b-a7cd-4fa1-98c4-9803a031c2aa', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'106', N'03/01/14', N'VACC', N'Vaccination ZK36', 22.0000, NULL, NULL, N'f30bb17f-4c50-4f9a-9822-875729b44c34', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'010', N'03/08/14', N'CONS', N'Scanner chien', 75.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'011', N'03/08/14', N'CONS', N'Echographie', 0.0000, 50.0000, 75.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'012', N'03/08/14', N'CONS', N'Bobologie', 30.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'080', N'03/08/14', N'CONS', N'Révision', 29.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'403', N'03/08/14', N'TATO', N'Tatouage', 0.0000, 15.0000, 20.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'201', N'01/02/14', N'GYCA', N'Stérilisation', 27.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'202', N'01/02/14', N'GYCA', N'Avortement', 44.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'203', N'01/02/14', N'GYCA', N'Castration', 0.0000, 120.0000, 150.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'204', N'01/02/14', N'GYCA', N'Contraception', 20.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'301', N'04/05/14', N'CHIR', N'Anesthésie Locale', 7.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'302', N'04/05/14', N'CHIR', N'Anesthésie Générale', 25.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'303', N'04/05/14', N'CHIR', N'Amputation', 0.0000, 120.0000, 180.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'304', N'04/05/14', N'CHIR', N'Cardiologie', 0.0000, 150.0000, 205.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'305', N'04/05/14', N'CHIR', N'Caudectomie', 0.0000, 22.0000, 30.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'901', N'03/12/13', N'DIVE', N'Plâtrement', 0.0000, 15.0000, 25.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'902', N'03/12/13', N'DIVE', N'Purge', 10.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'903', N'03/12/13', N'DIVE', N'Nettoyage', 5.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'103', N'12/10/15', N'VACC', N'Vaccination DT                ', 12.0000, 0.0000, 0.0000, N'd600b143-f685-4b9c-ba47-6fe842a62d82', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'107', N'12/38/15', N'VACC', N'Vaccination Antirabique       ', 14.0000, 0.0000, 0.0000, N'2d7f9d53-fab3-4017-b903-34ef72c02137', 0)
/****** Object:  Table [dbo].[Animaux]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Animaux](
	[CodeAnimal] [uniqueidentifier] NOT NULL,
	[NomAnimal] [varchar](30) NOT NULL,
	[Sexe] [char](1) NOT NULL,
	[Couleur] [varchar](20) NULL,
	[Race] [varchar](20) NOT NULL,
	[Espece] [varchar](20) NOT NULL,
	[CodeClient] [uniqueidentifier] NOT NULL,
	[Tatouage] [varchar](10) NULL,
	[Antecedents] [text] NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_Animaux] PRIMARY KEY NONCLUSTERED 
(
	[CodeAnimal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'6b67330c-9724-418e-aefe-c5c18848ee5d', N'Toby', N'M', N'Noir', N'Batard', N'Chien', N'dcef48b7-1460-4ea4-b619-6ae6e5986078', N'', NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'82107b46-e306-4a9e-bc4c-ce4c827264dc', N'Kiki', N'M', N'Jaune', N'Batard', N'Chien', N'dcef48b7-1460-4ea4-b619-6ae6e5986078', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'0cb32d80-a5c4-43e1-8923-74b7627a28d9', N'Kiki 1/2', N'M', N'Jaune', N'Batard', N'Chien', N'dcef48b7-1460-4ea4-b619-6ae6e5986078', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'c4b7bbef-3439-468b-9e7c-323fdc380289', N'Rex', N'M', N'Marron', N'Batard', N'Chien', N'aad6a853-20a9-482e-9064-ec77751edb18', N'', NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'74db1027-36e4-49f1-91ab-22155ef95cb6', N'Caroline', N'F', N'Vert', N'Marine', N'Tortue', N'bb556151-0ab5-401d-b1db-0ca4db11c736', N'', NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'5db8e33b-b427-4855-86a8-238ba8178494', N'Médor', N'M', N'Blanc', N'Batard', N'Chien', N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'508d2873-96fc-4ed0-a4da-310ae021599e', N'Dormé', N'M', N'Noir', N'Batard', N'Chien', N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'b1fde826-3153-4010-8942-92d68b02d32d', N'Milou', N'M', N'Blanc', N'Batard', N'Chien', N'184a67d0-fe10-4136-8e74-415019577a27', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'24390c84-b5f9-4530-8959-e26b9b9c94f1', N'Titi', N'M', N'Jaune', N'Canari', N'Oiseau', N'4696af33-cfb5-4b4c-8609-bfe23a2da5b2', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'30bf24b3-d47a-41ee-8102-c8b39ac26f85', N'Miaou II', N'M', N'', N'Siamois', N'Chat', N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'56cbf161-950f-451a-85cd-a01d3d9bd795', N'Miaou', N'M', N'', N'Siamois', N'Chat', N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'47b830f0-c9a8-4e52-9430-97e5eb8d58e2', N'Meow', N'M', N'', N'Siamois', N'Chat', N'9d2f8dd9-c7a7-4446-b05b-371f9d81c06d', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'86fc35d0-75a2-4978-8591-23b265662a16', N'Gnocchi', N'M', N'Blanc et Noir', N'Européen', N'Chat', N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', N'', NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'54d7fbdd-a3b7-4b38-aab0-d7c088971a9a', N'Quake', N'M', N'Beige', N'Caniche', N'Chien', N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', N'455-48-541', NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'77b783b5-fccd-4cbd-84a5-1e1ddc0695f8', N'Test', N'F', N'Test', N'Siamois', N'Chat', N'157b9143-cb0f-4078-9cd6-8f2f45d0a2c3', N'', NULL, 1)
/****** Object:  Table [dbo].[Veterinaires]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Veterinaires](
	[CodeVeto] [uniqueidentifier] NOT NULL,
	[NomVeto] [varchar](30) NOT NULL,
	[Archive] [bit] NOT NULL,
	[RefLogin] [int] NOT NULL,
 CONSTRAINT [PK_Veterinaire] PRIMARY KEY NONCLUSTERED 
(
	[CodeVeto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'0a4e385d-6ad4-4806-9935-2661191429ab', N'BOSAPIN Edmond', 0, 2)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', N'DE CAJOU Benoît', 0, 3)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'MALALANICH Mélanie', 0, 4)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', N'AIMONE Anne', 0, 5)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'bfbea98d-35ee-43ec-8a2c-c340c6b367af', N'TOURNE Sylvan', 0, 6)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'15044b32-ac70-4c43-a4bd-3cda42c2c351', N'SION Rémy', 1, 7)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'3ac44f1b-794d-448d-9ec9-2dae9b6eb5db', N'REGY Clément', 1, 13)
INSERT [dbo].[Veterinaires] ([CodeVeto], [NomVeto], [Archive], [RefLogin]) VALUES (N'bc8e2d1c-1303-4570-9e93-e23502697982', N'L''HÉRAULT Julie', 0, 14)
/****** Object:  Table [dbo].[Agendas]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agendas](
	[CodeVeto] [uniqueidentifier] NOT NULL,
	[DateRdv] [smalldatetime] NOT NULL,
	[CodeAnimal] [uniqueidentifier] NOT NULL,
	[Urgence] [bit] NOT NULL,
 CONSTRAINT [PK_Agendas] PRIMARY KEY NONCLUSTERED 
(
	[CodeVeto] ASC,
	[CodeAnimal] ASC,
	[DateRdv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bfbea98d-35ee-43ec-8a2c-c340c6b367af', CAST(0xA4340258 AS SmallDateTime), N'c4b7bbef-3439-468b-9e7c-323fdc380289', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', CAST(0xA42F0258 AS SmallDateTime), N'508d2873-96fc-4ed0-a4da-310ae021599e', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', CAST(0xA39B0294 AS SmallDateTime), N'30bf24b3-d47a-41ee-8102-c8b39ac26f85', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', CAST(0xA39B0258 AS SmallDateTime), N'47b830f0-c9a8-4e52-9430-97e5eb8d58e2', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA4340384 AS SmallDateTime), N'74db1027-36e4-49f1-91ab-22155ef95cb6', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', CAST(0xA435021C AS SmallDateTime), N'82107b46-e306-4a9e-bc4c-ce4c827264dc', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', CAST(0xA435023A AS SmallDateTime), N'6b67330c-9724-418e-aefe-c5c18848ee5d', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', CAST(0xA4350357 AS SmallDateTime), N'74db1027-36e4-49f1-91ab-22155ef95cb6', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bfbea98d-35ee-43ec-8a2c-c340c6b367af', CAST(0xA4350384 AS SmallDateTime), N'b1fde826-3153-4010-8942-92d68b02d32d', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bfbea98d-35ee-43ec-8a2c-c340c6b367af', CAST(0xA43503C0 AS SmallDateTime), N'5db8e33b-b427-4855-86a8-238ba8178494', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', CAST(0xA4350258 AS SmallDateTime), N'24390c84-b5f9-4530-8959-e26b9b9c94f1', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bc8e2d1c-1303-4570-9e93-e23502697982', CAST(0xA43702A6 AS SmallDateTime), N'30bf24b3-d47a-41ee-8102-c8b39ac26f85', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', CAST(0xA4350294 AS SmallDateTime), N'b1fde826-3153-4010-8942-92d68b02d32d', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA4370291 AS SmallDateTime), N'74db1027-36e4-49f1-91ab-22155ef95cb6', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bc8e2d1c-1303-4570-9e93-e23502697982', CAST(0xA43A0240 AS SmallDateTime), N'b1fde826-3153-4010-8942-92d68b02d32d', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'044c7923-2c2c-4e61-aa59-0c84015575d6', CAST(0xA43A0294 AS SmallDateTime), N'74db1027-36e4-49f1-91ab-22155ef95cb6', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'0a4e385d-6ad4-4806-9935-2661191429ab', CAST(0xA43A0294 AS SmallDateTime), N'82107b46-e306-4a9e-bc4c-ce4c827264dc', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'0a4e385d-6ad4-4806-9935-2661191429ab', CAST(0xA43A0240 AS SmallDateTime), N'5db8e33b-b427-4855-86a8-238ba8178494', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA43B0258 AS SmallDateTime), N'b1fde826-3153-4010-8942-92d68b02d32d', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA43B023E AS SmallDateTime), N'82107b46-e306-4a9e-bc4c-ce4c827264dc', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA43C02AC AS SmallDateTime), N'82107b46-e306-4a9e-bc4c-ce4c827264dc', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bc8e2d1c-1303-4570-9e93-e23502697982', CAST(0xA437023A AS SmallDateTime), N'508d2873-96fc-4ed0-a4da-310ae021599e', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'0a4e385d-6ad4-4806-9935-2661191429ab', CAST(0xA43B038E AS SmallDateTime), N'86fc35d0-75a2-4978-8591-23b265662a16', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'0a4e385d-6ad4-4806-9935-2661191429ab', CAST(0xA43B03C0 AS SmallDateTime), N'54d7fbdd-a3b7-4b38-aab0-d7c088971a9a', 0)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA43C03AC AS SmallDateTime), N'54d7fbdd-a3b7-4b38-aab0-d7c088971a9a', 1)
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', CAST(0xA43D02D0 AS SmallDateTime), N'86fc35d0-75a2-4978-8591-23b265662a16', 0)
/****** Object:  Table [dbo].[LignesFactures]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LignesFactures](
	[NumFacture] [uniqueidentifier] NOT NULL,
	[NumLigne] [uniqueidentifier] NOT NULL,
	[CodeGroupement] [char](3) NOT NULL,
	[Prix] [money] NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_LignesFactures] PRIMARY KEY NONCLUSTERED 
(
	[NumFacture] ASC,
	[NumLigne] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'891e88f0-684a-4c7c-bf8d-ac9f5f5f77f5', N'790e026d-cbc8-4712-8547-7f74644dab3d', N'105', 22.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'4c722da4-996f-4d67-b765-dc5f00766b8b', N'001e3bbe-fa64-4442-911b-bbc0dec2c350', N'105', 22.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'2bfc7fbd-f31f-4526-960c-2d1d83fcf702', N'e1476e00-8125-40db-8123-2d01879439cb', N'105', 22.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'743eb361-cb76-47a0-88c9-b7254797792d', N'a88ce5bd-6242-468c-bfbc-3f24f3d5c901', N'080', 29.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'743eb361-cb76-47a0-88c9-b7254797792d', N'44679098-3404-42c9-8471-087338e79073', N'012', 30.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'41d9d7ac-33ac-40a7-864b-2998a1a15ce8', N'f6ba1843-0d75-4f72-bd94-9aa0658914bc', N'080', 29.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'41d9d7ac-33ac-40a7-864b-2998a1a15ce8', N'e7bf35f9-6f20-488d-8816-a45381496624', N'012', 30.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'63e20846-0354-4d2e-8da8-63e5a01f289e', N'03bd16a1-bdf5-41bd-95eb-64e81b4dbe94', N'103', 10.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'63e20846-0354-4d2e-8da8-63e5a01f289e', N'9c033a15-5dd2-410e-9e85-ef8f7c4196dd', N'012', 30.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'63e20846-0354-4d2e-8da8-63e5a01f289e', N'b0bfffc2-5d5b-4306-99be-7785236a614c', N'011', 62.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'c4cfad46-aa82-4a4b-93dd-105ebe124ed7', N'b391223a-f1f0-40b6-8155-0f26d6e70877', N'012', 30.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'f6af22aa-5066-4b4c-a8d6-b0d5f97952b3', N'ea2ad001-fc35-401d-9fdc-7d1265e0bd3f', N'012', 30.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'f6af22aa-5066-4b4c-a8d6-b0d5f97952b3', N'12b17396-d72c-4a67-bb0a-99c8a7dfae1b', N'011', 54.0000, 0)
INSERT [dbo].[LignesFactures] ([NumFacture], [NumLigne], [CodeGroupement], [Prix], [Archive]) VALUES (N'600a2624-ed39-4845-9d1b-46f25be8b63b', N'6d03faad-2497-42da-8c0d-bfdcc306b03e', N'403', 18.0000, 0)
/****** Object:  StoredProcedure [dbo].[ajout_veterinaire]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un veterinaire       ****************************/
/***************************************************************************************/
/* nom du veterinaire
*/
CREATE PROCEDURE [dbo].[ajout_veterinaire] 
	@nomveto varchar(30),
	@archive int,
	@reflogin int
 AS
insert into veterinaires values(newID(),@nomveto, @archive, @reflogin);
GO
/****** Object:  Table [dbo].[Consultations]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Consultations](
	[CodeConsultation] [uniqueidentifier] NOT NULL,
	[DateConsultation] [datetime] NOT NULL,
	[CodeVeto] [uniqueidentifier] NOT NULL,
	[CodeAnimal] [uniqueidentifier] NOT NULL,
	[Commentaire] [varchar](50) NULL,
	[Etat] [int] NOT NULL,
	[NumFacture] [uniqueidentifier] NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_Consultations] PRIMARY KEY NONCLUSTERED 
(
	[CodeConsultation] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'1c6d8eb3-6830-445c-88b1-efa9547c4818', CAST(0x0000A43400A4CB80 AS DateTime), N'bfbea98d-35ee-43ec-8a2c-c340c6b367af', N'c4b7bbef-3439-468b-9e7c-323fdc380289', NULL, 0, NULL, 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'5f36b546-6a06-47c3-a83e-904697fde817', CAST(0x0000A42F00A4CB80 AS DateTime), N'044c7923-2c2c-4e61-aa59-0c84015575d6', N'508d2873-96fc-4ed0-a4da-310ae021599e', N'consultation enregistree le 29/01/2015', 2, N'891e88f0-684a-4c7c-bf8d-ac9f5f5f77f5', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'380eef0b-adb0-420b-a3e1-1b17b4272ee8', CAST(0x0000A4160107AC00 AS DateTime), N'044c7923-2c2c-4e61-aa59-0c84015575d6', N'b1fde826-3153-4010-8942-92d68b02d32d', N'consultation enregistree le 04/01/2015', 2, N'41d9d7ac-33ac-40a7-864b-2998a1a15ce8', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'c9d2a873-d837-47c8-8efb-2dd8800f3f41', CAST(0x0000A42000986F70 AS DateTime), N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'b1fde826-3153-4010-8942-92d68b02d32d', N'consultation enregistree le 14/01/2015', 1, NULL, 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'453cc540-dd84-4212-bcc7-4042af1658c5', CAST(0x0000A42A00A4CB80 AS DateTime), N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', N'b1fde826-3153-4010-8942-92d68b02d32d', N'consultation enregistree le 24/01/2015', 2, N'743eb361-cb76-47a0-88c9-b7254797792d', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'4a2cb03a-c6fb-4b60-b3fe-96c87b56543d', CAST(0x0000A39B00B54640 AS DateTime), N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'30bf24b3-d47a-41ee-8102-c8b39ac26f85', N'consultation enregistree le 03/09/2014', 2, N'4c722da4-996f-4d67-b765-dc5f00766b8b', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'79606ada-938c-4816-89e3-ff5431ce7101', CAST(0x0000A39B00A4CB80 AS DateTime), N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'47b830f0-c9a8-4e52-9430-97e5eb8d58e2', N'consultation enregistree le 03/09/2014', 2, N'2bfc7fbd-f31f-4526-960c-2d1d83fcf702', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'bf699553-0f9e-4533-9125-0976c5e87f92', CAST(0x0000A43B00FD6B8F AS DateTime), N'0a4e385d-6ad4-4806-9935-2661191429ab', N'86fc35d0-75a2-4978-8591-23b265662a16', N'Poids à surveiller', 2, N'63e20846-0354-4d2e-8da8-63e5a01f289e', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'0eccd68b-3134-43b8-97e4-ed9350e59400', CAST(0x0000A43B00FF21FC AS DateTime), N'0a4e385d-6ad4-4806-9935-2661191429ab', N'54d7fbdd-a3b7-4b38-aab0-d7c088971a9a', N'', 2, N'c4cfad46-aa82-4a4b-93dd-105ebe124ed7', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'b98a2a14-e27d-41e1-87f5-4c742e88fa5b', CAST(0x0000A43C00BC049D AS DateTime), N'0a4e385d-6ad4-4806-9935-2661191429ab', N'82107b46-e306-4a9e-bc4c-ce4c827264dc', N'', 2, N'f6af22aa-5066-4b4c-a8d6-b0d5f97952b3', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'115de0b6-b472-4331-ba6d-28485ecb36e5', CAST(0x0000A43C0102500E AS DateTime), N'0a4e385d-6ad4-4806-9935-2661191429ab', N'54d7fbdd-a3b7-4b38-aab0-d7c088971a9a', N'', 2, N'600a2624-ed39-4845-9d1b-46f25be8b63b', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'cd1a7c5f-8ac8-422d-a717-ac3d45e19b9a', CAST(0x0000A43D00B5F55E AS DateTime), N'0a4e385d-6ad4-4806-9935-2661191429ab', N'86fc35d0-75a2-4978-8591-23b265662a16', N'', 1, NULL, 0)
/****** Object:  StoredProcedure [dbo].[ajout_bareme]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un bareme       *********************************/
/******************* dans le cas d'un vaccin il doit etre cree avant *******************/
/***************************************************************************************/
/*	code groupement
	date de vigueur
	type d'acte
	libelle
	tarif fixe
	tarif maxi
	tarif mini
	nom du vaccin
*/
CREATE PROCEDURE [dbo].[ajout_bareme] 	
	@codegroupement char(3),
	@datevigueur char(8),
	@typeacte char(4),
	@libelle char(30),
	@tfixe money,
	@tmini money,
	@tmaxi money,
	@codevaccin uniqueidentifier
 AS
insert into baremes values(@codegroupement,@datevigueur,@typeacte,@libelle,@tfixe,@tmini,@tmaxi,@codevaccin,0);
GO
/****** Object:  StoredProcedure [dbo].[ajout_animal]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un animal       *********************************/
/**************** le client et le couple race/espece doivent etre cree avant    ********/
/***************************************************************************************/
/*	nom client
	prenom client
	nom animal
	sexe
	couleur
	espece
	race
	archive
*/
CREATE PROCEDURE  [dbo].[ajout_animal] 
	@nomclient varchar(20),
	@prenomclient varchar(20),
	@nomani varchar(30),
	@sexe char(1),
	@couleur varchar(20),
	@espece varchar(20),
	@race varchar(20),
	@tatouage varchar(10),
	@archive int
 AS
declare @cc uniqueidentifier
select @cc=codeclient from clients where nomclient=@nomclient and prenomclient=@prenomclient;
insert into animaux (CodeAnimal,nomanimal,sexe,couleur,espece,race,codeclient,tatouage, archive) values(newid(),@nomani,@sexe,@couleur,@espece,@race,@cc,@tatouage, @archive);
GO
/****** Object:  StoredProcedure [dbo].[ajout_agenda]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'un rendez vous      *****************************/
/******************* le client animal et veto doivent etre crees avant *****************/
/***************************************************************************************/
/*	nom du client
	prenom du client
	nom de l'animal
	nom du veto
	date du rendez vous
*/
CREATE PROCEDURE [dbo].[ajout_agenda] 
	@nomclient varchar(20),
	@prenomclient varchar(20),
	@nomanimal varchar(30),
	@nomveto varchar(30),
	@daterdv datetime,
	@urgence bit
 AS
declare @cc uniqueidentifier --code client
declare @ca uniqueidentifier --code animal
declare @cv uniqueidentifier --code vétérinaire

select @cc=codeclient from clients where nomclient=@nomclient and prenomclient=@prenomclient;
select @ca=codeanimal from animaux where nomanimal=@nomanimal and codeclient=@cc;
select @cv=codeveto from veterinaires where nomveto=@nomveto;
insert into agendas (codeveto,codeanimal,daterdv, Urgence) values(@cv,@ca,@daterdv, @urgence);
GO
/****** Object:  Table [dbo].[LignesConsultations]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LignesConsultations](
	[CodeConsultation] [uniqueidentifier] NOT NULL,
	[NumLigne] [uniqueidentifier] NOT NULL,
	[CodeGroupement] [char](3) NOT NULL,
	[DateVigueur] [char](8) NULL,
	[Prix] [money] NOT NULL,
	[RappelEnvoye] [bit] NOT NULL,
	[Archive] [bit] NOT NULL,
 CONSTRAINT [PK_LignesConsultations] PRIMARY KEY NONCLUSTERED 
(
	[CodeConsultation] ASC,
	[NumLigne] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'1c6d8eb3-6830-445c-88b1-efa9547c4818', N'465417a0-0ae5-4d46-9b95-89e706ad90d6', N'080', N'03/08/14', 29.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'5f36b546-6a06-47c3-a83e-904697fde817', N'790e026d-cbc8-4712-8547-7f74644dab3d', N'105', N'03/01/14', 22.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'380eef0b-adb0-420b-a3e1-1b17b4272ee8', N'f6ba1843-0d75-4f72-bd94-9aa0658914bc', N'080', N'03/08/14', 29.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'380eef0b-adb0-420b-a3e1-1b17b4272ee8', N'e7bf35f9-6f20-488d-8816-a45381496624', N'012', N'03/08/14', 30.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'c9d2a873-d837-47c8-8efb-2dd8800f3f41', N'a1efdc51-697d-4c46-a459-cf1ee0a834e1', N'080', N'03/08/14', 29.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'c9d2a873-d837-47c8-8efb-2dd8800f3f41', N'771509e1-6d08-4ecb-a639-6918b90fc574', N'012', N'03/08/14', 30.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'453cc540-dd84-4212-bcc7-4042af1658c5', N'a88ce5bd-6242-468c-bfbc-3f24f3d5c901', N'080', N'03/08/14', 29.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'453cc540-dd84-4212-bcc7-4042af1658c5', N'44679098-3404-42c9-8471-087338e79073', N'012', N'03/08/14', 30.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'4a2cb03a-c6fb-4b60-b3fe-96c87b56543d', N'001e3bbe-fa64-4442-911b-bbc0dec2c350', N'105', N'03/01/14', 22.0000, 1, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'79606ada-938c-4816-89e3-ff5431ce7101', N'e1476e00-8125-40db-8123-2d01879439cb', N'105', N'03/01/14', 22.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'bf699553-0f9e-4533-9125-0976c5e87f92', N'03bd16a1-bdf5-41bd-95eb-64e81b4dbe94', N'103', N'03/01/14', 10.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'bf699553-0f9e-4533-9125-0976c5e87f92', N'9c033a15-5dd2-410e-9e85-ef8f7c4196dd', N'012', N'03/08/14', 30.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'b98a2a14-e27d-41e1-87f5-4c742e88fa5b', N'ea2ad001-fc35-401d-9fdc-7d1265e0bd3f', N'012', N'03/08/14', 30.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'b98a2a14-e27d-41e1-87f5-4c742e88fa5b', N'12b17396-d72c-4a67-bb0a-99c8a7dfae1b', N'011', N'03/08/14', 54.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'bf699553-0f9e-4533-9125-0976c5e87f92', N'b0bfffc2-5d5b-4306-99be-7785236a614c', N'011', N'03/08/14', 62.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'0eccd68b-3134-43b8-97e4-ed9350e59400', N'b391223a-f1f0-40b6-8155-0f26d6e70877', N'012', N'03/08/14', 30.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'115de0b6-b472-4331-ba6d-28485ecb36e5', N'6d03faad-2497-42da-8c0d-bfdcc306b03e', N'403', N'03/08/14', 18.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'cd1a7c5f-8ac8-422d-a717-ac3d45e19b9a', N'e52cf345-22f0-4388-b606-69ddb03a43ad', N'902', N'03/12/13', 10.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'cd1a7c5f-8ac8-422d-a717-ac3d45e19b9a', N'64f67e88-03d9-40b8-b9af-72df9f015657', N'203', N'01/02/14', 122.0000, 0, 0)
/****** Object:  StoredProcedure [dbo].[ajout_consultation]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ajout_consultation] 
	@dateconsultation datetime,
	@codeVeto uniqueidentifier,
	@codeAnimal uniqueidentifier,
	@commentaire varchar(50)	
AS
BEGIN
	DECLARE @idConsult uniqueidentifier
	SET @idConsult = newid();
	INSERT INTO consultations (CodeConsultation, dateconsultation, codeveto, codeanimal, commentaire, etat, archive)
	VALUES(@idConsult, @dateconsultation, @codeVeto, @codeAnimal, @commentaire, 1, 0);
	SELECT @idConsult;	
END
GO
/****** Object:  View [dbo].[VueRelance]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VueRelance]
AS
SELECT     dbo.LignesConsultations.CodeConsultation, dbo.LignesConsultations.NumLigne, dbo.LignesConsultations.RappelEnvoye, dbo.Animaux.NomAnimal, 
                      dbo.Clients.NomClient, dbo.Clients.PrenomClient, dbo.Vaccins.NomVaccin, dbo.Vaccins.PeriodeValidite, dbo.Baremes.DateVigueur
FROM         dbo.Vaccins INNER JOIN
                      dbo.LignesConsultations INNER JOIN
                      dbo.Baremes ON dbo.LignesConsultations.CodeGroupement = dbo.Baremes.CodeGroupement AND 
                      dbo.LignesConsultations.DateVigueur = dbo.Baremes.DateVigueur ON dbo.Vaccins.CodeVaccin = dbo.Baremes.CodeVaccin INNER JOIN
                      dbo.Consultations ON dbo.LignesConsultations.CodeConsultation = dbo.Consultations.CodeConsultation INNER JOIN
                      dbo.Clients INNER JOIN
                      dbo.Animaux ON dbo.Clients.CodeClient = dbo.Animaux.CodeClient ON dbo.Consultations.CodeAnimal = dbo.Animaux.CodeAnimal
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LignesConsultations"
            Begin Extent = 
               Top = 6
               Left = 263
               Bottom = 114
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Vaccins"
            Begin Extent = 
               Top = 192
               Left = 235
               Bottom = 300
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Animaux"
            Begin Extent = 
               Top = 152
               Left = 739
               Bottom = 260
               Right = 930
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clients"
            Begin Extent = 
               Top = 209
               Left = 481
               Bottom = 317
               Right = 672
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Baremes"
            Begin Extent = 
               Top = 35
               Left = 13
               Bottom = 143
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Consultations"
            Begin Extent = 
               Top = 7
               Left = 517
               Bottom = 115
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueRelance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueRelance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueRelance'
GO
/****** Object:  StoredProcedure [dbo].[ajout_facture]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/***************************************************************************************/
/*******************           Ajout d'une facture      ********************************/
/******************* la consultation doit etre creee avant *****************************/
/***************************************************************************************/
/*  	nom du veto
	nom de l'animal
	date de la consulation
*/
CREATE PROCEDURE [dbo].[ajout_facture]
	@DateFact datetime,
	@nomVeto varchar(30),
	@nomanimal varchar(30),
	@dateConsultation Datetime,
	@etat int
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @cc uniqueidentifier
declare @tc money
declare @cg char(3)
declare @prix money
declare @ccons uniqueidentifier
declare @nf uniqueidentifier
SET @nf = NEWID()

SELECT @cv=codeveto FROM veterinaires WHERE nomveto=@nomVeto
SELECT @ca=codeanimal,@cc=codeclient FROM animaux WHERE nomanimal=@nomAnimal
SELECT @tc=sum(prix),@ccons=consultations.codeconsultation FROM consultations,lignesconsultations 
	WHERE codeveto=@cv and codeanimal=@ca and dateconsultation=@dateConsultation and consultations.codeconsultation=lignesconsultations.codeconsultation group by consultations.codeconsultation

INSERT INTO factures (NumFacture,datefacture,codeclient,totalfacture,archive,etat) VALUES(@nf,@DateFact,@cc,@tc,0,@etat)
SELECT @nf;

INSERT INTO lignesfactures (numfacture,numligne,codegroupement,prix,archive)(SELECT @nf,numligne,codegroupement,prix,0 FROM lignesconsultations WHERE codeconsultation=@ccons)
/*Met à jour la consultation correspondante en  lui attribuant le n° de la facture créée */
UPDATE consultations SET numfacture=@nf WHERE codeconsultation=@ccons
UPDATE consultations SET etat=2 WHERE codeconsultation=@ccons
GO
/****** Object:  StoredProcedure [dbo].[ajout_consultation3]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*************************************************************************************************/
/*******************           Ajout d'une consultation d'une ligne + vaccin facturée    *********/
/*******************           le rendez vous doit etre cree avant                   *************/
/*************************************************************************************************/
/*	date de la consultation
	nom du veterinaire
	nom de l'animal
	etat
*/
CREATE PROCEDURE  [dbo].[ajout_consultation3] 
	@dateconsultation datetime,
	@nomveto varchar(30),
	@nomanimal varchar(30)
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @dv char(8)
declare @cc uniqueidentifier
set @cc=newid()
select @cv=codeveto from veterinaires where nomveto=@nomveto
select @ca=codeanimal from animaux where nomanimal=@nomanimal 
select @dv=datevigueur from baremes where codegroupement='105' and archive=0

insert into consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive)
values(@cc,@dateconsultation,@cv,@ca, 'consultation enregistree le ' + convert(char(10),@dateconsultation,103),2,0)


insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'105',@dv,22,0,0)
GO
/****** Object:  StoredProcedure [dbo].[ajout_consultation2]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************************************************/
/****************           Ajout d'une consultation de deux lignes terminée, non facturée        *************/
/****************           le rendez vous doit etre cree avant                        ************************/
/**************************************************************************************************************/
/*	date de la consultation
	nom du veterinaire
	nom de l'animal
	etat
*/
CREATE PROCEDURE  [dbo].[ajout_consultation2] 
	@dateconsultation datetime,
	@nomveto varchar(30),
	@nomanimal varchar(30)
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @dv char(8)
declare @cc uniqueidentifier
set @cc=newid()
select @cv=codeveto from veterinaires where nomveto=@nomveto
select @ca=codeanimal from animaux where nomanimal=@nomanimal 


insert into consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive) 
values(@cc,@dateconsultation,@cv,@ca, 'consultation enregistree le ' + convert(char(10),@dateconsultation,103),1,0)

select @dv=datevigueur from baremes where codegroupement='080' and archive=0
insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'080',@dv,29,0,0)
select @dv=datevigueur from baremes where codegroupement='012' and archive=0
insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'012',@dv,30,0,0)
GO
/****** Object:  StoredProcedure [dbo].[ajout_consultation1]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************************************************************/
/*******************           Ajout d'une consultation en cours d'une ligne        *************/
/*******************           le rendez vous doit etre cree avant                  *************/
/************************************************************************************************/
/*	date de la consultation
	nom du veterinaire
	nom de l'animal
	etat
*/
CREATE PROCEDURE  [dbo].[ajout_consultation1] 
	@dateconsultation datetime,
	@nomveto varchar(30),
	@nomanimal varchar(30)
 AS
declare @cv uniqueidentifier
declare @ca uniqueidentifier
declare @dv char(8)
declare @cc uniqueidentifier
set @cc=newid()
select @cv=codeveto from veterinaires where nomveto=@nomveto
select @ca=codeanimal from animaux where nomanimal=@nomanimal 
select @dv=datevigueur from baremes where codegroupement='080' and archive=0

insert into consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive)
values(@cc,@dateconsultation,@cv,@ca,null,0,0)


insert into lignesconsultations(codeconsultation,numligne,codegroupement,datevigueur,prix,archive,rappelenvoye)
values (@cc,newid(),'080',@dv,29,0,0)
GO
/****** Object:  StoredProcedure [dbo].[ajout_acte]    Script Date: 02/12/2015 12:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ajout_acte] 
	@codeConsultation uniqueidentifier,
	@codeGroupement char(3),
	@datevigueur char(8),
	@prix money
AS
BEGIN
	DECLARE @numLigne uniqueidentifier
	SET @numLigne = newid();
	INSERT INTO LignesConsultations(CodeConsultation, NumLigne, CodeGroupement, DateVigueur, Prix, RappelEnvoye, Archive)
	VALUES(@codeConsultation, @numLigne, @codeGroupement, @datevigueur, @prix, 0, 0);
END
GO
/****** Object:  Default [DF_Agendas_Urgence]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Agendas] ADD  CONSTRAINT [DF_Agendas_Urgence]  DEFAULT ((0)) FOR [Urgence]
GO
/****** Object:  Default [DF__Veterinai__RefLo__4F7CD00D]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Veterinaires] ADD  DEFAULT ((1)) FOR [RefLogin]
GO
/****** Object:  ForeignKey [FK_Agendas]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Agendas]  WITH CHECK ADD  CONSTRAINT [FK_Agendas] FOREIGN KEY([CodeAnimal])
REFERENCES [dbo].[Animaux] ([CodeAnimal])
GO
ALTER TABLE [dbo].[Agendas] CHECK CONSTRAINT [FK_Agendas]
GO
/****** Object:  ForeignKey [FK_Animaux]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_Animaux] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_Animaux]
GO
/****** Object:  ForeignKey [FK_ANIMAUX_RACES]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAUX_RACES] FOREIGN KEY([Race], [Espece])
REFERENCES [dbo].[Races] ([Race], [Espece])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_ANIMAUX_RACES]
GO
/****** Object:  ForeignKey [FK_Baremes]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Baremes]  WITH CHECK ADD  CONSTRAINT [FK_Baremes] FOREIGN KEY([CodeVaccin])
REFERENCES [dbo].[Vaccins] ([CodeVaccin])
GO
ALTER TABLE [dbo].[Baremes] CHECK CONSTRAINT [FK_Baremes]
GO
/****** Object:  ForeignKey [FK_Consultations_Animaux]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Animaux] FOREIGN KEY([CodeAnimal])
REFERENCES [dbo].[Animaux] ([CodeAnimal])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Animaux]
GO
/****** Object:  ForeignKey [FK_Consultations_Factures]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Factures] FOREIGN KEY([NumFacture])
REFERENCES [dbo].[Factures] ([NumFacture])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Factures]
GO
/****** Object:  ForeignKey [FK_Consultations_Veterinaires]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Veterinaires] FOREIGN KEY([CodeVeto])
REFERENCES [dbo].[Veterinaires] ([CodeVeto])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Veterinaires]
GO
/****** Object:  ForeignKey [FK_Factures_clients]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Factures]  WITH CHECK ADD  CONSTRAINT [FK_Factures_clients] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Factures] CHECK CONSTRAINT [FK_Factures_clients]
GO
/****** Object:  ForeignKey [FK_LignesConsultations_baremes]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[LignesConsultations]  WITH CHECK ADD  CONSTRAINT [FK_LignesConsultations_baremes] FOREIGN KEY([CodeGroupement], [DateVigueur])
REFERENCES [dbo].[Baremes] ([CodeGroupement], [DateVigueur])
GO
ALTER TABLE [dbo].[LignesConsultations] CHECK CONSTRAINT [FK_LignesConsultations_baremes]
GO
/****** Object:  ForeignKey [FK_LignesConsultations_Consultations]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[LignesConsultations]  WITH CHECK ADD  CONSTRAINT [FK_LignesConsultations_Consultations] FOREIGN KEY([CodeConsultation])
REFERENCES [dbo].[Consultations] ([CodeConsultation])
GO
ALTER TABLE [dbo].[LignesConsultations] CHECK CONSTRAINT [FK_LignesConsultations_Consultations]
GO
/****** Object:  ForeignKey [FK_LignesFactures_facture]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[LignesFactures]  WITH CHECK ADD  CONSTRAINT [FK_LignesFactures_facture] FOREIGN KEY([NumFacture])
REFERENCES [dbo].[Factures] ([NumFacture])
GO
ALTER TABLE [dbo].[LignesFactures] CHECK CONSTRAINT [FK_LignesFactures_facture]
GO
/****** Object:  ForeignKey [fk_Veterinaires_Login]    Script Date: 02/12/2015 12:42:46 ******/
ALTER TABLE [dbo].[Veterinaires]  WITH CHECK ADD  CONSTRAINT [fk_Veterinaires_Login] FOREIGN KEY([RefLogin])
REFERENCES [dbo].[Logins] ([ID])
GO
ALTER TABLE [dbo].[Veterinaires] CHECK CONSTRAINT [fk_Veterinaires_Login]
GO

USE [CliniqueVeto]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Clients] ([CodeClient], [NomClient], [PrenomClient], [Adresse1], [Adresse2], [CodePostal], [Ville], [NumTel], [Assurance], [Email], [Remarque], [Archive]) VALUES (N'e6f829f9-8c23-4771-aaf2-5ba447cec53c', N'PP', N'p', N'pp', N'', N'45874 ', N'pp', N'....', N'', N'', NULL, 1)
/****** Object:  Table [dbo].[Vaccins]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'de1d881e-1254-4ddc-97b0-8ff3e4767c46', N'Vache folle', 4, 12, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'f30bb17f-4c50-4f9a-9822-875729b44c34', N'ZK36', 14, 18, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'1578360b-a7cd-4fa1-98c4-9803a031c2aa', N'Rage', 0, 12, 0)
INSERT [dbo].[Vaccins] ([CodeVaccin], [NomVaccin], [QuantiteStock], [PeriodeValidite], [Archive]) VALUES (N'd600b143-f685-4b9c-ba47-6fe842a62d82', N'DT', 3, 12, 0)
/****** Object:  Table [dbo].[Races]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Batard', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Bourgogne', N'Escargot')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Canari', N'Oiseau')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Marine', N'Tortue')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Setter', N'Chien')
INSERT [dbo].[Races] ([Race], [Espece]) VALUES (N'Siamois', N'Chat')
/****** Object:  Table [dbo].[Logins]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  Table [dbo].[Veterinaires]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_vaccin]    Script Date: 02/10/2015 10:17:54 ******/
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
insert into vaccins (CodeVaccin,nomvaccin,periodevalidite,quantitestock,archive) values(newid(),@nomvaccin,@periodevalidite,@quantite,0);
GO
/****** Object:  StoredProcedure [dbo].[ajout_race]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_login]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_client]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  Table [dbo].[Factures]    Script Date: 02/10/2015 10:17:54 ******/
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
	[Etat] [tinyint] NOT NULL,
	[RappelEnvoye] [datetime] NULL,
 CONSTRAINT [PK_Factures] PRIMARY KEY NONCLUSTERED 
(
	[NumFacture] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'891e88f0-684a-4c7c-bf8d-ac9f5f5f77f5', CAST(0x0000A42F00A4CB80 AS DateTime), N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', 22.0000, 0, 2, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'4c722da4-996f-4d67-b765-dc5f00766b8b', CAST(0x0000A39B00B54640 AS DateTime), N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', 22.0000, 0, 2, NULL)
INSERT [dbo].[Factures] ([NumFacture], [DateFacture], [CodeClient], [TotalFacture], [Archive], [Etat], [RappelEnvoye]) VALUES (N'2bfc7fbd-f31f-4526-960c-2d1d83fcf702', CAST(0x0000A39B00A4CB80 AS DateTime), N'9d2f8dd9-c7a7-4446-b05b-371f9d81c06d', 22.0000, 0, 1, NULL)
/****** Object:  Table [dbo].[Baremes]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'103', N'03/01/14', N'VACC', N'Vaccination DT', 10.0000, NULL, NULL, N'd600b143-f685-4b9c-ba47-6fe842a62d82', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'104', N'03/01/14', N'VACC', N'Vaccination vache folle', 13.0000, NULL, NULL, N'de1d881e-1254-4ddc-97b0-8ff3e4767c46', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'105', N'03/01/14', N'VACC', N'Vaccination rage', 22.0000, NULL, NULL, N'1578360b-a7cd-4fa1-98c4-9803a031c2aa', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'106', N'03/01/14', N'VACC', N'Vaccination ZK36', 22.0000, NULL, NULL, N'f30bb17f-4c50-4f9a-9822-875729b44c34', 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'010', N'03/08/14', N'CONS', N'Scanner chien', 75.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'011', N'03/08/14', N'CONS', N'Echographie', 0.0000, 50.0000, 75.0000, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'012', N'03/08/14', N'CONS', N'Bobologie', 30.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'080', N'03/08/14', N'CONS', N'Révision', 29.0000, NULL, NULL, NULL, 0)
INSERT [dbo].[Baremes] ([CodeGroupement], [DateVigueur], [TypeActe], [Libelle], [TarifFixe], [TarifMini], [TarifMaxi], [CodeVaccin], [Archive]) VALUES (N'403', N'03/08/14', N'TATO', N'Tatouage', 0.0000, 15.0000, 20.0000, NULL, 0)
/****** Object:  Table [dbo].[Animaux]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'6b67330c-9724-418e-aefe-c5c18848ee5d', N'Toby', N'M', N'noir', N'Batard', N'Chien', N'dcef48b7-1460-4ea4-b619-6ae6e5986078', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'82107b46-e306-4a9e-bc4c-ce4c827264dc', N'Kiki', N'M', N'Jaune', N'Batard', N'Chien', N'dcef48b7-1460-4ea4-b619-6ae6e5986078', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'0cb32d80-a5c4-43e1-8923-74b7627a28d9', N'Kiki 1/2', N'M', N'Jaune', N'Batard', N'Chien', N'dcef48b7-1460-4ea4-b619-6ae6e5986078', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'c4b7bbef-3439-468b-9e7c-323fdc380289', N'Rex', N'M', N'feu', N'Setter', N'Chien', N'aad6a853-20a9-482e-9064-ec77751edb18', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'74db1027-36e4-49f1-91ab-22155ef95cb6', N'Caroline', N'F', N'verte', N'Marine', N'Tortue', N'bb556151-0ab5-401d-b1db-0ca4db11c736', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'5db8e33b-b427-4855-86a8-238ba8178494', N'Médor', N'M', N'Blanc', N'Batard', N'Chien', N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'508d2873-96fc-4ed0-a4da-310ae021599e', N'Dormé', N'M', N'Noir', N'Batard', N'Chien', N'cb9398f9-3b49-4c9d-8e7e-71832d44ab88', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'b1fde826-3153-4010-8942-92d68b02d32d', N'Milou', N'M', N'Blanc', N'Batard', N'Chien', N'184a67d0-fe10-4136-8e74-415019577a27', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'24390c84-b5f9-4530-8959-e26b9b9c94f1', N'Titi', N'M', N'Jaune', N'Canari', N'Oiseau', N'4696af33-cfb5-4b4c-8609-bfe23a2da5b2', NULL, NULL, 0)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'30bf24b3-d47a-41ee-8102-c8b39ac26f85', N'Miaou II', N'M', N'', N'Siamois', N'Chat', N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'56cbf161-950f-451a-85cd-a01d3d9bd795', N'Miaou', N'M', N'', N'Siamois', N'Chat', N'1b4ac937-c4e2-4a36-936b-eac0f2b0c5f2', NULL, NULL, 1)
INSERT [dbo].[Animaux] ([CodeAnimal], [NomAnimal], [Sexe], [Couleur], [Race], [Espece], [CodeClient], [Tatouage], [Antecedents], [Archive]) VALUES (N'47b830f0-c9a8-4e52-9430-97e5eb8d58e2', N'Meow', N'M', N'', N'Siamois', N'Chat', N'9d2f8dd9-c7a7-4446-b05b-371f9d81c06d', NULL, NULL, 1)
/****** Object:  StoredProcedure [dbo].[ajout_veterinaire]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  Table [dbo].[Consultations]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'380eef0b-adb0-420b-a3e1-1b17b4272ee8', CAST(0x0000A4160107AC00 AS DateTime), N'044c7923-2c2c-4e61-aa59-0c84015575d6', N'b1fde826-3153-4010-8942-92d68b02d32d', N'consultation enregistree le 04/01/2015', 1, NULL, 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'c9d2a873-d837-47c8-8efb-2dd8800f3f41', CAST(0x0000A42000986F70 AS DateTime), N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'b1fde826-3153-4010-8942-92d68b02d32d', N'consultation enregistree le 14/01/2015', 1, NULL, 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'453cc540-dd84-4212-bcc7-4042af1658c5', CAST(0x0000A42A00A4CB80 AS DateTime), N'46f21d38-51c2-42cc-b39a-90d4146cf0cb', N'b1fde826-3153-4010-8942-92d68b02d32d', N'consultation enregistree le 24/01/2015', 1, NULL, 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'4a2cb03a-c6fb-4b60-b3fe-96c87b56543d', CAST(0x0000A39B00B54640 AS DateTime), N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'30bf24b3-d47a-41ee-8102-c8b39ac26f85', N'consultation enregistree le 03/09/2014', 2, N'4c722da4-996f-4d67-b765-dc5f00766b8b', 0)
INSERT [dbo].[Consultations] ([CodeConsultation], [DateConsultation], [CodeVeto], [CodeAnimal], [Commentaire], [Etat], [NumFacture], [Archive]) VALUES (N'79606ada-938c-4816-89e3-ff5431ce7101', CAST(0x0000A39B00A4CB80 AS DateTime), N'a7ee90d8-a319-4e4a-b592-9e2103448aaa', N'47b830f0-c9a8-4e52-9430-97e5eb8d58e2', N'consultation enregistree le 03/09/2014', 2, N'2bfc7fbd-f31f-4526-960c-2d1d83fcf702', 0)
/****** Object:  StoredProcedure [dbo].[ajout_bareme]    Script Date: 02/10/2015 10:17:54 ******/
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
	@nomvaccin char(30)
 AS
declare @cv uniqueidentifier
select @cv=codevaccin from vaccins where nomvaccin=@nomvaccin;
insert into baremes values(@codegroupement,@datevigueur,@typeacte,@libelle,@tfixe,@tmini,@tmaxi,@cv,0);
GO
/****** Object:  StoredProcedure [dbo].[ajout_animal]    Script Date: 02/10/2015 10:17:54 ******/
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
	@archive int
 AS
declare @cc uniqueidentifier
select @cc=codeclient from clients where nomclient=@nomclient and prenomclient=@prenomclient;
insert into animaux (CodeAnimal,nomanimal,sexe,couleur,espece,race,codeclient,archive) values(newid(),@nomani,@sexe,@couleur,@espece,@race,@cc,@archive);
GO
/****** Object:  Table [dbo].[Agendas]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[Agendas] ([CodeVeto], [DateRdv], [CodeAnimal], [Urgence]) VALUES (N'bc8e2d1c-1303-4570-9e93-e23502697982', CAST(0xA437023A AS SmallDateTime), N'508d2873-96fc-4ed0-a4da-310ae021599e', 0)
/****** Object:  Table [dbo].[LignesFactures]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  Table [dbo].[LignesConsultations]    Script Date: 02/10/2015 10:17:54 ******/
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
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'4a2cb03a-c6fb-4b60-b3fe-96c87b56543d', N'001e3bbe-fa64-4442-911b-bbc0dec2c350', N'105', N'03/01/14', 22.0000, 0, 0)
INSERT [dbo].[LignesConsultations] ([CodeConsultation], [NumLigne], [CodeGroupement], [DateVigueur], [Prix], [RappelEnvoye], [Archive]) VALUES (N'79606ada-938c-4816-89e3-ff5431ce7101', N'e1476e00-8125-40db-8123-2d01879439cb', N'105', N'03/01/14', 22.0000, 0, 0)
/****** Object:  StoredProcedure [dbo].[ajout_agenda]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_facture]    Script Date: 02/10/2015 10:17:54 ******/
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


select @cv=codeveto from veterinaires where nomveto=@nomVeto
select @ca=codeanimal,@cc=codeclient from animaux where nomanimal=@nomAnimal
select @tc=sum(prix),@ccons=consultations.codeconsultation from consultations,lignesconsultations 
	where codeveto=@cv and codeanimal=@ca and dateconsultation=@dateConsultation and consultations.codeconsultation=lignesconsultations.codeconsultation group by consultations.codeconsultation

insert into factures (NumFacture,datefacture,codeclient,totalfacture,archive,etat) 
	values(@nf,@DateFact,@cc,@tc,0,@etat)

INSERT INTO lignesfactures (numfacture,numligne,codegroupement,prix,archive)
  (SELECT @nf,numligne,codegroupement,prix,0 FROM lignesconsultations WHERE codeconsultation=@ccons)
/*Met à jour la consultation correspondante en  lui attribuant le n° de la facture créée */
update consultations set numfacture=@nf where codeconsultation=@ccons
GO
/****** Object:  StoredProcedure [dbo].[ajout_consultation3]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_consultation2]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_consultation1]    Script Date: 02/10/2015 10:17:54 ******/
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
/****** Object:  Default [DF_Agendas_Urgence]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Agendas] ADD  CONSTRAINT [DF_Agendas_Urgence]  DEFAULT ((0)) FOR [Urgence]
GO
/****** Object:  Default [DF__Veterinai__RefLo__4F7CD00D]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Veterinaires] ADD  DEFAULT ((1)) FOR [RefLogin]
GO
/****** Object:  ForeignKey [FK_Agendas]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Agendas]  WITH CHECK ADD  CONSTRAINT [FK_Agendas] FOREIGN KEY([CodeAnimal])
REFERENCES [dbo].[Animaux] ([CodeAnimal])
GO
ALTER TABLE [dbo].[Agendas] CHECK CONSTRAINT [FK_Agendas]
GO
/****** Object:  ForeignKey [FK_Animaux]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_Animaux] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_Animaux]
GO
/****** Object:  ForeignKey [FK_ANIMAUX_RACES]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAUX_RACES] FOREIGN KEY([Race], [Espece])
REFERENCES [dbo].[Races] ([Race], [Espece])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_ANIMAUX_RACES]
GO
/****** Object:  ForeignKey [FK_Baremes]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Baremes]  WITH CHECK ADD  CONSTRAINT [FK_Baremes] FOREIGN KEY([CodeVaccin])
REFERENCES [dbo].[Vaccins] ([CodeVaccin])
GO
ALTER TABLE [dbo].[Baremes] CHECK CONSTRAINT [FK_Baremes]
GO
/****** Object:  ForeignKey [FK_Consultations_Animaux]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Animaux] FOREIGN KEY([CodeAnimal])
REFERENCES [dbo].[Animaux] ([CodeAnimal])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Animaux]
GO
/****** Object:  ForeignKey [FK_Consultations_Factures]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Factures] FOREIGN KEY([NumFacture])
REFERENCES [dbo].[Factures] ([NumFacture])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Factures]
GO
/****** Object:  ForeignKey [FK_Consultations_Veterinaires]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Veterinaires] FOREIGN KEY([CodeVeto])
REFERENCES [dbo].[Veterinaires] ([CodeVeto])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Veterinaires]
GO
/****** Object:  ForeignKey [FK_Factures_clients]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Factures]  WITH CHECK ADD  CONSTRAINT [FK_Factures_clients] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Factures] CHECK CONSTRAINT [FK_Factures_clients]
GO
/****** Object:  ForeignKey [FK_LignesConsultations_baremes]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[LignesConsultations]  WITH CHECK ADD  CONSTRAINT [FK_LignesConsultations_baremes] FOREIGN KEY([CodeGroupement], [DateVigueur])
REFERENCES [dbo].[Baremes] ([CodeGroupement], [DateVigueur])
GO
ALTER TABLE [dbo].[LignesConsultations] CHECK CONSTRAINT [FK_LignesConsultations_baremes]
GO
/****** Object:  ForeignKey [FK_LignesConsultations_Consultations]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[LignesConsultations]  WITH CHECK ADD  CONSTRAINT [FK_LignesConsultations_Consultations] FOREIGN KEY([CodeConsultation])
REFERENCES [dbo].[Consultations] ([CodeConsultation])
GO
ALTER TABLE [dbo].[LignesConsultations] CHECK CONSTRAINT [FK_LignesConsultations_Consultations]
GO
/****** Object:  ForeignKey [FK_LignesFactures_facture]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[LignesFactures]  WITH CHECK ADD  CONSTRAINT [FK_LignesFactures_facture] FOREIGN KEY([NumFacture])
REFERENCES [dbo].[Factures] ([NumFacture])
GO
ALTER TABLE [dbo].[LignesFactures] CHECK CONSTRAINT [FK_LignesFactures_facture]
GO
/****** Object:  ForeignKey [fk_Veterinaires_Login]    Script Date: 02/10/2015 10:17:54 ******/
ALTER TABLE [dbo].[Veterinaires]  WITH CHECK ADD  CONSTRAINT [fk_Veterinaires_Login] FOREIGN KEY([RefLogin])
REFERENCES [dbo].[Logins] ([ID])
GO
ALTER TABLE [dbo].[Veterinaires] CHECK CONSTRAINT [fk_Veterinaires_Login]
GO

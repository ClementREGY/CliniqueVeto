USE [CliniqueVeto]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[Vaccins]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[Races]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[Logins]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[Veterinaires]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_vaccin]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_race]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_login]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_client]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  Table [dbo].[Factures]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[Baremes]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[Animaux]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_veterinaire]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  Table [dbo].[Consultations]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_bareme]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_animal]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  Table [dbo].[Agendas]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[LignesFactures]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  Table [dbo].[LignesConsultations]    Script Date: 02/10/2015 10:02:13 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_agenda]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_facture]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_consultation3]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_consultation2]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  StoredProcedure [dbo].[ajout_consultation1]    Script Date: 02/10/2015 10:02:14 ******/
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
/****** Object:  Default [DF_Agendas_Urgence]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Agendas] ADD  CONSTRAINT [DF_Agendas_Urgence]  DEFAULT ((0)) FOR [Urgence]
GO
/****** Object:  Default [DF__Veterinai__RefLo__4F7CD00D]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Veterinaires] ADD  DEFAULT ((1)) FOR [RefLogin]
GO
/****** Object:  ForeignKey [FK_Agendas]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Agendas]  WITH CHECK ADD  CONSTRAINT [FK_Agendas] FOREIGN KEY([CodeAnimal])
REFERENCES [dbo].[Animaux] ([CodeAnimal])
GO
ALTER TABLE [dbo].[Agendas] CHECK CONSTRAINT [FK_Agendas]
GO
/****** Object:  ForeignKey [FK_Animaux]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_Animaux] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_Animaux]
GO
/****** Object:  ForeignKey [FK_ANIMAUX_RACES]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Animaux]  WITH CHECK ADD  CONSTRAINT [FK_ANIMAUX_RACES] FOREIGN KEY([Race], [Espece])
REFERENCES [dbo].[Races] ([Race], [Espece])
GO
ALTER TABLE [dbo].[Animaux] CHECK CONSTRAINT [FK_ANIMAUX_RACES]
GO
/****** Object:  ForeignKey [FK_Baremes]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Baremes]  WITH CHECK ADD  CONSTRAINT [FK_Baremes] FOREIGN KEY([CodeVaccin])
REFERENCES [dbo].[Vaccins] ([CodeVaccin])
GO
ALTER TABLE [dbo].[Baremes] CHECK CONSTRAINT [FK_Baremes]
GO
/****** Object:  ForeignKey [FK_Consultations_Animaux]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Animaux] FOREIGN KEY([CodeAnimal])
REFERENCES [dbo].[Animaux] ([CodeAnimal])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Animaux]
GO
/****** Object:  ForeignKey [FK_Consultations_Factures]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Factures] FOREIGN KEY([NumFacture])
REFERENCES [dbo].[Factures] ([NumFacture])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Factures]
GO
/****** Object:  ForeignKey [FK_Consultations_Veterinaires]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Consultations]  WITH CHECK ADD  CONSTRAINT [FK_Consultations_Veterinaires] FOREIGN KEY([CodeVeto])
REFERENCES [dbo].[Veterinaires] ([CodeVeto])
GO
ALTER TABLE [dbo].[Consultations] CHECK CONSTRAINT [FK_Consultations_Veterinaires]
GO
/****** Object:  ForeignKey [FK_Factures_clients]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Factures]  WITH CHECK ADD  CONSTRAINT [FK_Factures_clients] FOREIGN KEY([CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Factures] CHECK CONSTRAINT [FK_Factures_clients]
GO
/****** Object:  ForeignKey [FK_LignesConsultations_baremes]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[LignesConsultations]  WITH CHECK ADD  CONSTRAINT [FK_LignesConsultations_baremes] FOREIGN KEY([CodeGroupement], [DateVigueur])
REFERENCES [dbo].[Baremes] ([CodeGroupement], [DateVigueur])
GO
ALTER TABLE [dbo].[LignesConsultations] CHECK CONSTRAINT [FK_LignesConsultations_baremes]
GO
/****** Object:  ForeignKey [FK_LignesConsultations_Consultations]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[LignesConsultations]  WITH CHECK ADD  CONSTRAINT [FK_LignesConsultations_Consultations] FOREIGN KEY([CodeConsultation])
REFERENCES [dbo].[Consultations] ([CodeConsultation])
GO
ALTER TABLE [dbo].[LignesConsultations] CHECK CONSTRAINT [FK_LignesConsultations_Consultations]
GO
/****** Object:  ForeignKey [FK_LignesFactures_facture]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[LignesFactures]  WITH CHECK ADD  CONSTRAINT [FK_LignesFactures_facture] FOREIGN KEY([NumFacture])
REFERENCES [dbo].[Factures] ([NumFacture])
GO
ALTER TABLE [dbo].[LignesFactures] CHECK CONSTRAINT [FK_LignesFactures_facture]
GO
/****** Object:  ForeignKey [fk_Veterinaires_Login]    Script Date: 02/10/2015 10:02:13 ******/
ALTER TABLE [dbo].[Veterinaires]  WITH CHECK ADD  CONSTRAINT [fk_Veterinaires_Login] FOREIGN KEY([RefLogin])
REFERENCES [dbo].[Logins] ([ID])
GO
ALTER TABLE [dbo].[Veterinaires] CHECK CONSTRAINT [fk_Veterinaires_Login]
GO

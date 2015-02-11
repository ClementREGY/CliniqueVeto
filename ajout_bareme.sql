USE [CliniqueVeto]
GO
/****** Object:  StoredProcedure [dbo].[ajout_bareme]    Script Date: 02/11/2015 17:16:25 ******/
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
ALTER PROCEDURE [dbo].[ajout_bareme] 	
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

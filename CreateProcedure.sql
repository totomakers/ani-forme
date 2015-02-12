USE ani_forme;

/* Procedure d'ajout de compte utilisateur */
CREATE PROCEDURE [dbo].[ajout_account] 
	@username varchar(50), 
	@password varchar(160)
AS
BEGIN

	DECLARE @test int;
	DECLARE @id int;
	
	SELECT @test=COUNT(*)
	FROM ani_forme.dbo.Account 
	WHERE username=@username;
	
	IF(@test=0)
	BEGIN
		SELECT @id = MAX(id)+1 FROM ani_forme.dbo.Account;
		
		IF(@id is null)
		BEGIN
			SET @id = 1;
		END
		
		INSERT INTO ani_forme.dbo.Account 	(id, username, password, is_online) 
									VALUES 	(@id, @username, @password, 0);
	END
	
	SELECT @username, @password;
END

/* Precedure d'ajout d'un agenda (=rdv) */
CREATE PROCEDURE [dbo].[ajout_agenda] 
	@nomclient varchar(20),
	@prenomclient varchar(20),
	@nomanimal varchar(30),
	@codeveto uniqueidentifier,
	@daterdv datetime,
	@urgence bit
AS
BEGIN
	DECLARE @cc uniqueidentifier; --code client
	DECLARE @ca uniqueidentifier; --code animal

	SELECT @cc=codeclient FROM clients WHERE nomclient=@nomclient AND prenomclient=@prenomclient;
	SELECT @ca=codeanimal FROM animaux WHERE nomanimal=@nomanimal AND codeclient=@cc;
	
	INSERT INTO agendas (codeveto,codeanimal,daterdv, urgence) 
				VALUES 	(@codeveto,@ca,@daterdv, @urgence);
END

/* Procédure d'ajout d'un animal */
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
BEGIN
	DECLARE @cc uniqueidentifier;
	DECLARE @codeAnimal uniqueidentifier;
	
	SET @codeAnimal = NEWID();
	SELECT @cc=codeclient FROM clients WHERE nomclient=@nomclient AND prenomclient=@prenomclient;
	
	INSERT INTO animaux (CodeAnimal,nomanimal,sexe,couleur,espece,race,codeclient,archive) 
				VALUES	(@codeAnimal,@nomani,@sexe,@couleur,@espece,@race,@cc,@archive);
	
	SELECT @codeAnimal;
END

/* Procédure d'ajout de bareme */
CREATE PROCEDURE [dbo].[ajout_bareme] 	
	@codegroupement char(3),
	@datevigueur char(8),
	@typeacte char(4),
	@libelle varchar(30),
	@tfixe money,
	@tmini money,
	@tmaxi money,
	@nomvaccin char(30)
AS
BEGIN
	DECLARE @cv uniqueidentifier;
	
	SELECT @cv=codevaccin FROM vaccins WHERE nomvaccin=@nomvaccin;
	
	INSERT INTO baremes VALUES(@codegroupement,@datevigueur,@typeacte,@libelle,@tfixe,@tmini,@tmaxi,@cv,0);
END

/* Procédure d'ajout de client */
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
BEGIN
	DECLARE @id uniqueidentifier;
		
	SET @id = NEWID();
	
	INSERT INTO clients (CodeClient,nomclient,prenomclient,adresse1,adresse2,codepostal,ville,numtel,assurance,email,archive) 
				  VALUES(@id,@nom,@prenom,@add,@add2,@cp,@ville,@tel,@ass,@mail,@arch)
	
	SELECT @id;
END

/* Procédure de création d'une consultation */
CREATE PROCEDURE [dbo].[ajout_consultation] 
	@dateconsultation datetime,
	@codeveto uniqueidentifier,
	@cadeanimal uniqueidentifier,
	@commentaire varchar(50),
	@etat tinyint
AS
BEGIN
	DECLARE @cc uniqueidentifier;
	
	SET @cc=NEWID();

	INSERT INTO consultations (CodeConsultation,dateconsultation,codeveto,codeanimal,commentaire,etat,archive)
						VALUES(@cc,@dateconsultation,@codeveto,@cadeanimal, @commentaire,@etat,0)

	SELECT @cc;
END

/* Procédure de création d'une facture */
CREATE PROCEDURE [dbo].[ajout_facture]
	@DateFact datetime,
	@nomVeto varchar(30),
	@nomanimal varchar(30),
	@dateConsultation Datetime,
	@etat int
AS
BEGIN
	DECLARE @cv uniqueidentifier;
	DECLARE @ca uniqueidentifier;
	DECLARE @cc uniqueidentifier;
	DECLARE @tc money;
	DECLARE @cg char(3);
	DECLARE @prix money;
	DECLARE @ccons uniqueidentifier;
	DECLARE	 @nf uniqueidentifier;
	
	SET @nf = NEWID();

	SELECT @cv=codeveto FROM veterinaires WHERE nomveto=@nomVeto;
	SELECT @ca=codeanimal,@cc=codeclient FROM animaux WHERE nomanimal=@nomAnimal;
	
	SELECT @tc=sum(prix),@ccons=consultations.codeconsultation 
	FROM consultations,lignesconsultations
	WHERE codeveto=@cv 
	AND codeanimal=@ca 
	AND dateconsultation=@dateConsultation 
	AND consultations.codeconsultation=lignesconsultations.codeconsultation 
	GROUP BY consultations.codeconsultation;

	INSERT INTO factures 	(NumFacture,datefacture,codeclient,totalfacture,archive,etat) 
					VALUES	(@nf,@DateFact,@cc,@tc,0,@etat);

	INSERT INTO lignesfactures (numfacture,numligne,codegroupement,prix,archive)
						(SELECT @nf,numligne,codegroupement,prix,0 FROM lignesconsultations WHERE codeconsultation=@ccons);
	/*Met à jour la consultation correspondante en  lui attribuant le n° de la facture créée */
	UPDATE consultations SET numfacture=@nf WHERE codeconsultation=@ccons;
END

/* Procedure d'ajout de ligne consultation */
CREATE PROCEDURE [dbo].[ajout_ligne_consultation] 
	@codeconsult uniqueidentifier,
	@codegroupement char(3),
	@datevigueur char(8),
	@prix money

AS
BEGIN
	DECLARE @numligne uniqueidentifier;
	
	SET @numligne = newID();

	INSERT INTO LignesConsultations (CodeConsultation,NumLigne,CodeGroupement,DateVigueur,Prix,RappelEnvoye,Archive)
							VALUES	(@codeconsult,@numligne,@codegroupement,@datevigueur,@prix,0,0);

	SELECT @numligne;
END

/* Procédure d'ajout de race */
CREATE PROCEDURE [dbo].[ajout_race] 
	@race varchar(20),
	@espece varchar(20)
AS
BEGIN
	INSERT INTO races (race,espece) 
				VALUES(@race,@espece);
END

/* Procédure d'ajout de vaccin */
CREATE PROCEDURE [dbo].[ajout_vaccin] 
	@nomvaccin varchar(30),
	@periodevalidite int,
	@quantite int
AS
BEGIN
	INSERT INTO vaccins (CodeVaccin,nomvaccin,periodevalidite,quantitestock,archive) 
				VALUES	(newid(),@nomvaccin,@periodevalidite,@quantite,0);
END

/* Procédure d'ajout de vétérinaire */
CREATE PROCEDURE [dbo].[ajout_veterinaire] 
	@nomveto varchar(30),
	@archive int,
	@account int
AS
BEGIN
	DECLARE @id uniqueidentifier;
	
	SET @id = NEWID();
	
	INSERT INTO veterinaires VALUES(@id,@nomveto,@archive,@account);
	
	SELECT @id;
END
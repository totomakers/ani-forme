CREATE DATABASE ani_forme;
USE ani_forme;

/* Table de gestion des comptes utilisateurs */
CREATE TABLE dbo.Account(
	id integer NOT NULL,
	username varchar(50) NOT NULL,
	password varchar(160) NOT NULL,
	is_online integer NOT NULL
)

ALTER TABLE dbo.Account ADD CONSTRAINT PK_Account PRIMARY KEY NONCLUSTERED (
	id
) 

/* Table contenant la liste des veterinaires de la clinique */
CREATE TABLE dbo.Veterinaires(
 	CodeVeto uniqueidentifier NOT NULL ,
	NomVeto varchar(30) NOT NULL,
	Archive bit NOT NULL,
	AccountId integer NOT NULL
) 

ALTER TABLE dbo.Veterinaires ADD CONSTRAINT PK_Veterinaire PRIMARY KEY NONCLUSTERED (
	CodeVeto
) 

ALTER TABLE dbo.Veterinaires ADD CONSTRAINT FK_Veterinaires_Account 
FOREIGN KEY (AccountId)	REFERENCES Account (id)

/* Table contenant la liste des vaccins */
CREATE TABLE dbo.Vaccins (
 	CodeVaccin uniqueidentifier NOT NULL ,
	NomVaccin varchar(30) NOT NULL,
	QuantiteStock integer NOT NULL,
	PeriodeValidite integer NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.Vaccins ADD CONSTRAINT PK_Vaccins PRIMARY KEY NONCLUSTERED (
	CodeVaccin
) 

/* Table contenant la liste des barèmes*/
CREATE TABLE dbo.Baremes(
 	CodeGroupement char(3) NOT NULL,
	DateVigueur char(8) NOT NULL,
	TypeActe varchar(4) NOT NULL,
	Libelle varchar(30) NULL,
	TarifFixe money NOT NULL,
	TarifMini money NULL,
	TarifMaxi money NULL,
	CodeVaccin uniqueidentifier NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.Baremes ADD CONSTRAINT PK_Baremes PRIMARY KEY NONCLUSTERED (
	CodeGroupement,
	DateVigueur
) 

ALTER TABLE dbo.Baremes ADD CONSTRAINT FK_Baremes_Vaccins 
FOREIGN KEY ( CodeVaccin ) REFERENCES Vaccins (CodeVaccin )

/* Table contenant la liste des races et des espèces */
CREATE TABLE dbo.Races(
 	Race varchar(20) NOT NULL,
	Espece varchar(20) NOT NULL
) 

ALTER TABLE dbo.Races ADD CONSTRAINT PK_Races PRIMARY KEY NONCLUSTERED (
	Race,
	Espece
) 

-- /* Table contenant la liste des clients */
CREATE TABLE dbo.Clients (
 	CodeClient uniqueidentifier NOT NULL,
	NomClient varchar(20) NOT NULL,
	PrenomClient varchar(20) NOT NULL,
	Adresse1 varchar(30) NULL,
	Adresse2 varchar(30) NULL,
	CodePostal char(6) NULL,
	Ville varchar(25) NULL,
	NumTel varchar(15) NULL,
	Assurance varchar(30) NULL,
	Email varchar(20) NULL ,
	Remarque text NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.Clients ADD CONSTRAINT PK_Clients PRIMARY KEY NONCLUSTERED (
	codeClient
) 

/* Table contenant la liste des animaux */
CREATE TABLE dbo.Animaux (
 	CodeAnimal uniqueidentifier NOT NULL,
	NomAnimal varchar(30) NOT NULL ,
	Sexe char(1) NOT NULL ,
	Couleur varchar(20) NULL,
	Race varchar(20) NOT NULL,
	Espece varchar(20) NOT NULL,
	CodeClient uniqueidentifier NOT NULL,
	Tatouage varchar(10) NULL,
	Antecedents text NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.Animaux ADD CONSTRAINT PK_Animaux PRIMARY KEY NONCLUSTERED (
	CodeAnimal
)

ALTER TABLE dbo.Animaux ADD CONSTRAINT FK_Animaux_Clients 
FOREIGN KEY ( CodeClient ) REFERENCES Clients (CodeClient )

ALTER TABLE dbo.Animaux ADD CONSTRAINT FK_Animaux_Races 
FOREIGN KEY (Race,Espece) REFERENCES Races (Race,Espece)

/* Table contenant la liste des agendas (=rdv) */
CREATE TABLE dbo.Agendas (
 	CodeVeto uniqueidentifier NOT NULL,
	DateRdv smalldatetime NOT NULL,
	CodeAnimal uniqueidentifier NOT NULL,
	Urgence bit NOT NULL
) 

ALTER TABLE dbo.Agendas ADD CONSTRAINT PK_Agendas PRIMARY KEY NONCLUSTERED (
	CodeVeto,
	CodeAnimal,
	DateRdv
)

ALTER TABLE dbo.Agendas ADD CONSTRAINT FK_Agendas_Animaux 
FOREIGN KEY ( CodeAnimal ) REFERENCES Animaux (CodeAnimal ) 

/* Table contenant la liste des factures */
CREATE TABLE dbo.Factures (
 	NumFacture uniqueidentifier NOT NULL,
	DateFacture DateTime NOT NULL,
	CodeClient uniqueidentifier NOT NULL,
	TotalFacture money NULL,
	Archive bit NOT NULL,
	Etat tinyint NOT NULL,
	RappelEnvoye DateTime NULL
) 

ALTER TABLE dbo.Factures ADD CONSTRAINT PK_Factures PRIMARY KEY NONCLUSTERED (
	NumFacture
)

ALTER TABLE dbo.Factures ADD CONSTRAINT FK_Factures_clients 
FOREIGN KEY ( CodeClient ) REFERENCES Clients (CodeClient )

/* Table contenant la liste des lignes de chaque facture */
CREATE TABLE dbo.LignesFactures (
 	NumFacture uniqueidentifier NOT NULL,
	NumLigne uniqueidentifier NOT NULL,
	CodeGroupement char(3) NOT NULL,
	Prix money NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.LignesFactures ADD CONSTRAINT PK_LignesFactures PRIMARY KEY NONCLUSTERED (
	NumFacture,
	NumLigne
) 

ALTER TABLE dbo.LignesFactures ADD CONSTRAINT FK_LignesFactures_Facture 
FOREIGN KEY (NumFacture) REFERENCES Factures ( NumFacture ) 

/* Table contenant la liste des consultations */
CREATE TABLE dbo.Consultations (
 	CodeConsultation uniqueidentifier NOT NULL ,
	DateConsultation DateTime NOT NULL,
	CodeVeto uniqueidentifier NOT NULL,
	CodeAnimal uniqueidentifier NOT NULL,
	Commentaire varchar(max) NULL,
	Etat tinyint NOT NULL,
	NumFacture uniqueidentifier NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.Consultations ADD CONSTRAINT PK_Consultations PRIMARY KEY NONCLUSTERED (
	CodeConsultation
)

ALTER TABLE dbo.Consultations ADD CONSTRAINT FK_Consultations_Veterinaires 
FOREIGN KEY ( CodeVeto ) REFERENCES Veterinaires (CodeVeto )

ALTER TABLE dbo.Consultations ADD CONSTRAINT FK_Consultations_Animaux 
FOREIGN KEY ( CodeAnimal ) REFERENCES Animaux (CodeAnimal )

ALTER TABLE dbo.Consultations ADD CONSTRAINT FK_Consultations_Factures 
FOREIGN KEY ( NumFacture ) REFERENCES Factures (NumFacture )

/* Table contenant la liste des lignes de chaque consultation */
CREATE TABLE dbo.LignesConsultations (
 	CodeConsultation uniqueidentifier NOT NULL,
	NumLigne uniqueidentifier NOT NULL,
	CodeGroupement char(3) NOT NULL,
	DateVigueur char(8),
	Prix money NOT NULL,
	RappelEnvoye bit NOT NULL,
	Archive bit NOT NULL
) 

ALTER TABLE dbo.LignesConsultations ADD CONSTRAINT PK_LignesConsultations PRIMARY KEY NONCLUSTERED (
	CodeConsultation,
	NumLigne
) 

ALTER TABLE dbo.LignesConsultations ADD CONSTRAINT FK_LignesConsultations_Consultations 
FOREIGN KEY (CodeConsultation) REFERENCES Consultations ( CodeConsultation ) 

ALTER TABLE dbo.LignesConsultations ADD CONSTRAINT FK_LignesConsultations_baremes 
FOREIGN KEY (CodeGroupement,DateVigueur) REFERENCES Baremes ( CodeGroupement,DateVigueur ) 
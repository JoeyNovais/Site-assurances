DROP TABLE Client;
DROP TABLE Compagnie;
DROP TABLE Service;
DROP TABLE Representant;
DROP TABLE DemandeGest;
DROP TABLE DemandeIns;

CREATE TABLE Client
(
	NomClient VARCHAR(50) PRIMARY KEY,
	cli_MotPasse VARCHAR(50) not null,
	cli_Courriel VARCHAR(200) not null,
	cli_Nom VARCHAR(100) not null,
	cli_Prenom VARCHAR(50) not null,
	cli_DateNaiss DATE not null,
	cli_Type CHAR not null,
	cli_Telephone VARCHAR(13) not null,
	cli_CodePostal VARCHAR(6) not null,
	cli_StatutMarital CHAR not null,
	cli_Ville VARCHAR(40) not null,
	cli_Adresse VARCHAR(120) not null,
	cli_Pays VARCHAR(20) not null
);
CREATE TABLE Compagnie
(
	Com_Nom VARCHAR(50) primary key,
	Com_LienUrl VARCHAR(200) DEFAULT 'page404' not null,
	Com_Image VARCHAR(100) DEFAULT 'Image/Vide.png' not null
);

CREATE TABLE Service
(
	No_Ser INT PRIMARY KEY AUTO_INCREMENT,
	Com_Nom VARCHAR(50) REFERENCES Compagnie(Com_Nom),
	NomClient VARCHAR(50) REFERENCES Client(NomClient),
	Ser_Nom VARCHAR(100) not null,
	Ser_Categorie VARCHAR(100) not null
);

CREATE TABLE Representant
(
	NomRep VARCHAR(50) PRIMARY KEY,
	rep_MotPasse VARCHAR(50) not null,
	rep_Courriel VARCHAR(200) not null
);

CREATE TABLE DemandeGest
(
	No_DemGest INT PRIMARY KEY AUTO_INCREMENT,
	NomClient VARCHAR(50) REFERENCES Client(NomClient),
	DemGest_Courriel VARCHAR(200) not null,
	DemGest_Nom VARCHAR(100) not null,
	DemGest_Prenom VARCHAR(50) not null,
	DemGest_DateNaiss DATE not null,
	DemGest_TypeClient CHAR not null,
	DemGest_Telephone VARCHAR(13) not null,
	DemGest_CodePostal VARCHAR(6) not null,
	DemGest_StatutMarital CHAR not null,
	DemGest_Ville VARCHAR(40) not null,
	DemGest_Adresse VARCHAR(120) not null,
	DemGest_Pays VARCHAR(20) not null,
	DemGest_Statut VARCHAR(15) DEFAULT 'En attente' not null,
	DemGest_Texte VARCHAR(4000),
	DemGest_Date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE DemandeIns
(
	NomClient VARCHAR(50) PRIMARY KEY,
	DemIns_MotPasse VARCHAR(50) not null,
	DemIns_Courriel VARCHAR(200) not null,
	DemIns_Nom VARCHAR(100) not null,
	DemIns_Prenom VARCHAR(50) not null,
	DemIns_DateNaiss DATE not null,
	DemIns_TypeClient CHAR not null,
	DemIns_Telephone VARCHAR(13) not null,
	DemIns_CodePostal VARCHAR(6) not null,
	DemIns_StatutMarital CHAR not null,
	DemIns_Ville VARCHAR(40) not null,
	DemIns_Adresse VARCHAR(120) not null,
	DemIns_Pays VARCHAR(20) not null,
	DemIns_Statut VARCHAR(15) DEFAULT 'En attente' not null,
	DemIns_Texte VARCHAR(4000),
	DemIns_Date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

insert into Representant values ('admin', 'admin123','kojibobo@hotmail.com');
<<<<<<< HEAD:TablesProjet.SQL
insert into Client values('Axel','admin123','cestPlusFortQueMoi@ouiCestCommeCa.partoutAutourDeNous','Gauthier','Axel','2001-09-11', 'P', '418-836-0958','G621N3','M','St-Teets','6 rue Albert-le-prince','Hobo');
insert into Client values('Math','admin123','test@bilboa.com','Gauthier','Mathieu','2001-09-11', 'P', '418-836-1058','G621N2','M','Levis','103 Rue industrielle','Canada');
insert into Client values('Joey','admin123','novaisjoey@gmail.com','Novais','Joey','2001-09-11','p','418-836-1058','G621N2','M','Reichstett','104 Rue industrielle','France');
insert into Compagnie values (1,'http://hobo.com/','CACA Québec','Image/caa.jpg');
insert into Compagnie values (2, 'http://www.desjardins.com/fr/bienvenue.jsp','Desjardins', 'Image/desjardin.png');
insert into Compagnie values (3, 'http://mathieu.com/', 'Assurance Mathieu', DEFAULT);
insert into Service values (1, 1, 'Axel', 'T26', 'Assurance automobile');
insert into Service values (2, 1, 'Axel', 'T75', 'Assurance automobile');
insert into Service values (3, 2, 'Axel', 'F457 avec prêt à vie', 'Assurance Financière');
insert into Service values (4, 3, 'Axel', 'B54.5', 'Assurance maladie');
insert into DemandeGest values(1,1, 'Gauthier','Axel','2001-09-11', 'P', '418-777-7777','KBDJ67','M','St-Hobo','666 rue du Cancer','MEXICANO',DEFAULT,'Les fleurs sont violettes comme mon urêtre.');
insert into DemandeIns values(2, 'Hurd','Bat','1984-01-17', 'P', '418-666-6666','KOJIBO','M','St-BOBO','6 rue de la modération','Sauce',DEFAULT,'Je reçois toujours les jets de liquides et ça me gêne.');
=======
insert into Client values('Axel','admin123','cestPlusFortQueMoi@ouiCestCommeCa.com','Gauthier','Axel','2001-09-11', 'P', '418-836-0958','G621N3','M','St-Teets','6 rue Albert-le-prince','Hobo');
insert into Compagnie values ('CACA Québec','http://hobo.com/','Image/caa.jpg');
insert into Compagnie values ( 'Desjardins','http://www.desjardins.com/fr/bienvenue.jsp', 'Image/desjardin.png');
insert into Compagnie values ( 'Assurance Mathieu','http://mathieu.com/',  DEFAULT);
insert into Service values (null,'CACA Québec', 'Axel', 'T26', 'Assurance automobile');
insert into Service values (null,'Desjardins', 'Axel', 'T75', 'Assurance automobile');
insert into Service values (null,'Assurance Mathieu', 'Axel', 'F457 avec prêt à vie', 'Assurance Financière');
insert into Service values (null,'Assurance Mathieu', 'Axel', 'B54.5', 'Assurance maladie');
insert into DemandeGest values(null,'Axel', 'caa@outlook.com', 'Gauthier','Axel','2001-09-11', 'P', '418-777-7777','KBDJ67','M','St-Hobo','666 rue du Cancer','MEXICANO',DEFAULT,'Les fleurs sont violettes comme mon urêtre.',DEFAULT);
insert into DemandeIns values('Mat','admin123', 'caa@outlook.com','Hurd','Bat','1984-01-17', 'P', '418-666-6666','KOJIBO','M','St-BOBO','6 rue de la modération','Sauce',DEFAULT,'Je reçois toujours les jets de liquides et ça me gêne.',DEFAULT);
>>>>>>> Merge:TablesProjetv5.SQL

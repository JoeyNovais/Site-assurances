DROP TABLE Client;
DROP TABLE Compagnie;
DROP TABLE Service;
DROP TABLE Utilisateur;

CREATE TABLE Client
(
	NoClient INT PRIMARY KEY,
	Nom VARCHAR(100) not null,
	Prenom VARCHAR(50) not null,
	DateNaiss DATE not null,
	TypeClient CHAR not null,
	Telephone VARCHAR(13) not null,
	CodePostal VARCHAR(6) not null,
	StatutMarital CHAR not null,
	Ville VARCHAR(40) not null,
	Adresse VARCHAR(120) not null,
	Pays VARCHAR(20) not null
);
CREATE TABLE Compagnie
(
	NoCo INT PRIMARY KEY,
	LienUrl VARCHAR(200) DEFAULT 'page404',
	Nom VARCHAR(50) not null
);

CREATE TABLE Service
(
	NoService INT PRIMARY KEY,
	NoCo INT REFERENCES Compagnie(NoCo),
	NoClient INT REFERENCES Client(NoClient),
	TypePers CHAR not null,
	Nom VARCHAR(100) not null,
	Categorie VARCHAR(100) not null
);

CREATE TABLE Utilisateur
(
	NomUtil VARCHAR(50) PRIMARY KEY,
	NoClient INT REFERENCES Client(NoClient),
	MotPasse VARCHAR(50) not null,
	Courriel VARCHAR(200) not null
);

CREATE TABLE DemandeGere
(
	NoDem INT PRIMARY KEY,
	NoClient INT REFERENCES Client(NoClient),
	Nom VARCHAR(100) not null,
	Prenom VARCHAR(50) not null,
	DateNaiss DATE not null,
	TypeClient CHAR not null,
	Telephone VARCHAR(13) not null,
	CodePostal VARCHAR(6) not null,
	StatutMarital CHAR not null,
	Ville VARCHAR(40) not null,
	Adresse VARCHAR(120) not null,
	Pays VARCHAR(20) not null,
	Statut VARCHAR(15) DEFAULT 'En attente',
	Texte VARCHAR(4000)
);

insert into Client values(1,'Gauthier','Axel','2001-09-11', 'P', '418-836-0958','G621N3','M','St-Teets','6 rue Albert-le-prince','Hobo');
insert into Compagnie values(1,'http://hobo.com/','HOBO');
insert into Service values (1, 1, 1, 'P', 'Assurance merdique', 'Assurance protection de la merde');
insert into Utilisateur values('AxelTheHobo',1,'Please','youguys@outLOOK.com');
insert into DemandeGere values(1,1, 'Gauthier','Axel','2001-09-11', 'P', '418-777-7777','KBDJ67','M','St-Hobo','666 rue du Cancer','MEXICANO',null,'Les fleurs sont violettes comme mon urètre.');
insert into DemandeGere values(2,null, 'Hurd','Bat','1984-01-17', 'P', '418-666-6666','KOJIBO','M','St-BOBO','6 rue de la modération','Sauce',null,'Je reçois toujours les jets de liquides et ça me gêne.');

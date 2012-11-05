-- MySQL dump 10.13  Distrib 5.5.27, for Win32 (x86)
--
-- Host: localhost    Database: ass
-- ------------------------------------------------------
-- Server version	5.5.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `NomClient` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_MotPasse` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Courriel` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Prenom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_DateNaiss` date NOT NULL,
  `cli_Type` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Telephone` varchar(13) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_CodePostal` varchar(6) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_StatutMarital` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Ville` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Adresse` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_Pays` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`NomClient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES ('Axel','admin123','cestPlusFortQueMoi@ouiCestCommeCa.com','Gauthier','Axel','2001-09-11','P','418-836-0958','G621N3','M','St-Teets','6 rue Albert-le-prince','Hobo');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compagnie`
--

DROP TABLE IF EXISTS `compagnie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compagnie` (
  `Com_Nom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Com_LienUrl` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'page404',
  `Com_Image` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Image/Vide.png',
  PRIMARY KEY (`Com_Nom`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compagnie`
--

LOCK TABLES `compagnie` WRITE;
/*!40000 ALTER TABLE `compagnie` DISABLE KEYS */;
INSERT INTO `compagnie` VALUES ('Assurance Mathieu','http://mathieu.com/','Image/Vide.png'),('CACA Québec','http://hobo.com/','Image/caa.jpg'),('Desjardins','http://www.desjardins.com/fr/bienvenue.jsp','Image/desjardin.png');
/*!40000 ALTER TABLE `compagnie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `demandegest`
--

DROP TABLE IF EXISTS `demandegest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `demandegest` (
  `NomClient` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DemGest_Nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_Prenom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_DateNaiss` date NOT NULL,
  `DemGest_TypeClient` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_Telephone` varchar(13) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_CodePostal` varchar(6) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_StatutMarital` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_Ville` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_Adresse` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_Pays` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemGest_Statut` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'En attente',
  `DemGest_Texte` varchar(4000) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DemIns_Date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demandegest`
--

LOCK TABLES `demandegest` WRITE;
/*!40000 ALTER TABLE `demandegest` DISABLE KEYS */;
INSERT INTO `demandegest` VALUES ('Axel','Gauthier','Axel','2001-09-11','P','418-777-7777','KBDJ67','M','St-Hobo','666 rue du Cancer','MEXICANO','En attente','Les fleurs sont violettes comme mon urêtre.','2012-10-29 17:09:37');
/*!40000 ALTER TABLE `demandegest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `demandeins`
--

DROP TABLE IF EXISTS `demandeins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `demandeins` (
  `NomClient` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cli_MotPasse` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Prenom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_DateNaiss` date NOT NULL,
  `DemIns_TypeClient` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Telephone` varchar(13) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_CodePostal` varchar(6) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_StatutMarital` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Ville` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Adresse` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Pays` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DemIns_Statut` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'En attente',
  `DemIns_Texte` varchar(4000) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DemIns_Date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`NomClient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demandeins`
--

LOCK TABLES `demandeins` WRITE;
/*!40000 ALTER TABLE `demandeins` DISABLE KEYS */;
INSERT INTO `demandeins` VALUES ('Mat','admin123','Hurd','Bat','1984-01-17','P','418-666-6666','KOJIBO','M','St-BOBO','6 rue de la modération','Sauce','En attente','Je reçois toujours les jets de liquides et ça me gêne.','2012-10-29 17:09:37');
/*!40000 ALTER TABLE `demandeins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `representant`
--

DROP TABLE IF EXISTS `representant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `representant` (
  `NomRep` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `rep_MotPasse` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `rep_Courriel` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`NomRep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `representant`
--

LOCK TABLES `representant` WRITE;
/*!40000 ALTER TABLE `representant` DISABLE KEYS */;
INSERT INTO `representant` VALUES ('admin','admin123','kojibobo@hotmail.com');
/*!40000 ALTER TABLE `representant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `service` (
  `Com_Nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NomClient` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Ser_Nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Ser_Categorie` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` VALUES ('CACA Québec','Axel','T26','Assurance automobile'),('Desjardins','Axel','T75','Assurance automobile'),('Assurance Mathieu','Axel','F457 avec prêt à vie','Assurance Financière'),('Assurance Mathieu','Axel','B54.5','Assurance maladie');
/*!40000 ALTER TABLE `service` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-10-29 14:02:56

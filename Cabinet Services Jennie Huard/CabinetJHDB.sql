SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Client`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Client` (
  `NoUtil` INT NOT NULL ,
  `Nom` VARCHAR(100) NOT NULL ,
  `Prenom` VARCHAR(50) NOT NULL ,
  `DateNaiss` DATE NOT NULL ,
  `Type` CHAR NOT NULL ,
  `Telephone` VARCHAR(20) NOT NULL ,
  `CodePostal` VARCHAR(6) NOT NULL ,
  `StatutMarital` CHAR NOT NULL ,
  `Ville` VARCHAR(45) NOT NULL ,
  `Adresse` VARCHAR(120) NOT NULL ,
  `Pays` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`NoUtil`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Compagnie`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Compagnie` (
  `NoCo` INT NOT NULL ,
  `LienUrl` VARCHAR(200) NULL DEFAULT 'page404' ,
  `Nom` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`NoCo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Service`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Service` (
  `NoService` INT NOT NULL ,
  `NoCo` INT NOT NULL ,
  `Type` CHAR NOT NULL ,
  `Nom` VARCHAR(100) NOT NULL ,
  `Categorie` VARCHAR(100) NOT NULL ,
  `NoUtil` INT NOT NULL ,
  PRIMARY KEY (`NoService`) ,
  INDEX `NoCo_idx` (`NoCo` ASC) ,
  INDEX `NoUtil_idx` (`NoUtil` ASC) ,
  CONSTRAINT `NoCo`
    FOREIGN KEY (`NoCo` )
    REFERENCES `mydb`.`Compagnie` (`NoCo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `NoUtil`
    FOREIGN KEY (`NoUtil` )
    REFERENCES `mydb`.`Client` (`NoUtil` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Utilisateur`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`Utilisateur` (
  `NomUtil` VARCHAR(50) NOT NULL ,
  `NoUtil` INT NOT NULL ,
  `MotPasse` VARCHAR(50) NOT NULL ,
  `Courriel` VARCHAR(200) NOT NULL ,
  PRIMARY KEY (`NomUtil`) ,
  INDEX `NoUtil_idx` (`NoUtil` ASC) ,
  CONSTRAINT `NoUtil`
    FOREIGN KEY (`NoUtil` )
    REFERENCES `mydb`.`Client` (`NoUtil` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`DemandeModInfoPerso`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`DemandeModInfoPerso` (
  `NoDemMod` INT NOT NULL ,
  `NoUtil` INT NOT NULL ,
  `Statut` VARCHAR(45) NOT NULL DEFAULT 'En attente' ,
  `Texte` VARCHAR(4000) NOT NULL ,
  PRIMARY KEY (`NoDemMod`) ,
  INDEX `NoUtil_idx` (`NoUtil` ASC) ,
  CONSTRAINT `NoUtil`
    FOREIGN KEY (`NoUtil` )
    REFERENCES `mydb`.`Client` (`NoUtil` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`DemandeInscription`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`DemandeInscription` (
  `NoDemIns` INT NOT NULL ,
  `NoUtil` INT NOT NULL ,
  `Nom` VARCHAR(50) NOT NULL ,
  `Prenom` VARCHAR(100) NOT NULL ,
  `DateNaiss` DATE NOT NULL ,
  `Type` CHAR NOT NULL ,
  `Telephone` VARCHAR(20) NOT NULL ,
  `CodePostal` VARCHAR(6) NOT NULL ,
  `Adresse` VARCHAR(120) NOT NULL ,
  `Ville` VARCHAR(45) NOT NULL ,
  `Pays` VARCHAR(45) NOT NULL ,
  `StatutMarital` CHAR NOT NULL ,
  `Statut` VARCHAR(45) NOT NULL DEFAULT 'En attente' ,
  `Texte` VARCHAR(4000) NULL ,
  PRIMARY KEY (`NoDemIns`) ,
  INDEX `NoUtil_idx` (`NoUtil` ASC) ,
  CONSTRAINT `NoUtil`
    FOREIGN KEY (`NoUtil` )
    REFERENCES `mydb`.`Client` (`NoUtil` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

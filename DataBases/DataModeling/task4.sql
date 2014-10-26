SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema UniversitySystem
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `UniversitySystem` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `UniversitySystem` ;

-- -----------------------------------------------------
-- Table `UniversitySystem`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Titles` (
  `TitleId` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`TitleId`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `UniversitySystem`.`Professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Professors` (
  `ProfessorId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  `TitleId` INT NOT NULL,
  `Titles_TitleId` INT NOT NULL,
  PRIMARY KEY (`ProfessorId`, `Titles_TitleId`),
  INDEX `fk_Professors_Titles_idx` (`Titles_TitleId` ASC),
  CONSTRAINT `fk_Professors_Titles`
    FOREIGN KEY (`Titles_TitleId`)
    REFERENCES `UniversitySystem`.`Titles` (`TitleId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `UniversitySystem`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Courses` (
  `idCourses` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Professors_ProfessorId` INT NOT NULL,
  PRIMARY KEY (`idCourses`, `Professors_ProfessorId`),
  INDEX `fk_Courses_Professors1_idx` (`Professors_ProfessorId` ASC),
  CONSTRAINT `fk_Courses_Professors1`
    FOREIGN KEY (`Professors_ProfessorId`)
    REFERENCES `UniversitySystem`.`Professors` (`ProfessorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `UniversitySystem`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Faculties` (
  `idFaculties` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idFaculties`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `UniversitySystem`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Students` (
  `idStudents` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Faculties_idFaculties` INT NOT NULL,
  PRIMARY KEY (`idStudents`, `Faculties_idFaculties`),
  INDEX `fk_Students_Faculties1_idx` (`Faculties_idFaculties` ASC),
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`Faculties_idFaculties`)
    REFERENCES `UniversitySystem`.`Faculties` (`idFaculties`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `UniversitySystem`.`Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Departments` (
  `idDepartments` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Faculties_idFaculties` INT NOT NULL,
  PRIMARY KEY (`idDepartments`, `Faculties_idFaculties`),
  INDEX `fk_Departments_Faculties1_idx` (`Faculties_idFaculties` ASC),
  CONSTRAINT `fk_Departments_Faculties1`
    FOREIGN KEY (`Faculties_idFaculties`)
    REFERENCES `UniversitySystem`.`Faculties` (`idFaculties`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `UniversitySystem`.`Students_Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `UniversitySystem`.`Students_Courses` (
  `Students_idStudents` INT NOT NULL,
  `Courses_idCourses` INT NOT NULL,
  PRIMARY KEY (`Students_idStudents`, `Courses_idCourses`),
  INDEX `fk_Students_Courses_Students1_idx` (`Students_idStudents` ASC),
  INDEX `fk_Students_Courses_Courses1_idx` (`Courses_idCourses` ASC),
  CONSTRAINT `fk_Students_Courses_Students1`
    FOREIGN KEY (`Students_idStudents`)
    REFERENCES `UniversitySystem`.`Students` (`idStudents`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Students_Courses_Courses1`
    FOREIGN KEY (`Courses_idCourses`)
    REFERENCES `UniversitySystem`.`Courses` (`idCourses`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


CREATE DATABASE IF NOT EXISTS `mediatek86`;
USE `mediatek86`;

CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(2) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(2) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES (10, '2020-06-15 00:00:00', 4, '2020-11-02 00:00:00'), (4, '2020-06-27 00:00:00', 2, '2020-12-05 00:00:00'), (10, '2020-06-07 00:00:00', 2, '2021-02-23 00:00:00'), (1, '2020-06-09 00:00:00', 3, '2021-03-07 00:00:00'), (7, '2020-06-20 00:00:00', 1, '2021-05-24 00:00:00'), (1, '2020-06-11 00:00:00', 2, '2021-07-07 00:00:00'), (8, '2020-06-05 00:00:00', 3, '2020-06-24 00:00:00'), (8, '2020-06-23 00:00:00', 2, '2020-10-04 00:00:00'), (10, '2020-06-09 00:00:00', 1, '2021-09-14 00:00:00'), (8, '2020-06-04 00:00:00', 4, '2021-11-29 00:00:00'), (5, '2020-06-30 00:00:00', 1, '2021-12-18 00:00:00'), (5, '2020-06-25 00:00:00', 2, '2022-05-14 00:00:00'), (3, '2020-06-26 00:00:00', 4, '2022-03-20 00:00:00'), (6, '2020-06-20 00:00:00', 4, '2021-03-23 00:00:00'), (4, '2020-06-18 00:00:00', 2, '2021-01-02 00:00:00'), (1, '2020-06-21 00:00:00', 1, '2022-02-23 00:00:00'), (8, '2020-06-14 00:00:00', 1, '2021-06-22 00:00:00'), (6, '2020-06-03 00:00:00', 2, '2020-10-23 00:00:00'), (10, '2020-06-14 00:00:00', 2, '2021-09-19 00:00:00'), (4, '2020-06-10 00:00:00', 3, '2022-03-21 00:00:00'), (4, '2020-06-16 00:00:00', 1, '2022-03-19 00:00:00'), (4, '2020-06-24 00:00:00', 1, '2021-03-09 00:00:00'), (8, '2020-06-06 00:00:00', 4, '2021-06-15 00:00:00'), (6, '2020-06-17 00:00:00', 2, '2021-08-03 00:00:00'), (1, '2020-06-24 00:00:00', 1, '2022-05-12 00:00:00'), (1, '2020-06-14 00:00:00', 4, '2021-12-28 00:00:00'), (3, '2020-06-23 00:00:00', 4, '2021-08-01 00:00:00'), (7, '2020-06-08 00:00:00', 2, '2022-02-18 00:00:00'), (8, '2020-06-28 00:00:00', 3, '2020-07-11 00:00:00'), (10, '2020-06-10 00:00:00', 4, '2020-10-02 00:00:00'), (7, '2020-06-14 00:00:00', 2, '2022-02-21 00:00:00'), (8, '2020-06-17 00:00:00', 1, '2021-03-28 00:00:00'), (1, '2020-06-20 00:00:00', 1, '2022-05-16 00:00:00'), (8, '2020-06-30 00:00:00', 4, '2020-12-17 00:00:00'), (4, '2020-06-17 00:00:00', 2, '2020-10-31 00:00:00'), (1, '2020-06-18 00:00:00', 1, '2021-01-08 00:00:00'), (10, '2020-06-13 00:00:00', 3, '2021-10-11 00:00:00'), (5, '2020-06-27 00:00:00', 1, '2021-11-11 00:00:00'), (3, '2020-06-15 00:00:00', 1, '2021-04-16 00:00:00'), (8, '2020-06-26 00:00:00', 2, '2021-11-12 00:00:00');

CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES (1, 'vacances'), (2, 'maladie'), (3, 'motif familial'), (4, 'congé parental');

CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) DEFAULT NULL,
  `PRENOM` varchar(50) DEFAULT NULL,
  `TEL` varchar(15) DEFAULT NULL,
  `MAIL` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES (1, 3, 'Hopkins', 'Hanna', '02 37 79 59 24', 'Donec.elementum.lorem@mi.org'), (3, 1, 'Short', 'Gabriel', '09 70 59 55 82', 'consequat.nec@posuereatvelit.org'), (4, 2, 'Perkins', 'Rebekah', '09 11 71 25 01', 'Etiam.ligula.tortor@ornaresagittisfelis.edu'), (5, 3, 'Pittman', 'Abel', '05 73 76 65 07', 'tincidunt.dui@ultrices.edu'), (6, 1, 'Jenkins', 'Ahmed', '06 97 84 26 55', 'Duis.sit@acrisusMorbi.ca'), (7, 1, 'Hoffman', 'Quinn', '01 65 49 77 48', 'Fusce.diam.nunc@duinec.org'), (8, 2, 'Burke', 'Xerxes', '01 17 82 47 59', 'vel.vulputate.eu@laciniaat.co.uk'), (10, 2, 'Joseph', 'Hiroko', '01 89 40 37 76', 'sit.amet.diam@montes.com');


CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) DEFAULT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
INSERT INTO `responsable` (`login`, `pwd`) VALUES ('jean.jacques', SHA2('pn995T2S', 256));

CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES (1, 'administratif'), (2, 'médiation culturelle'), (3, 'prêt');

CREATE USER 'responsable'@'localhost' IDENTIFIED BY 'pn995T2S'; 
GRANT CREATE ON * . * TO 'responsable'@'localhost';
GRANT SELECT ON * . * TO 'responsable'@'localhost';
GRANT UPDATE ON * . * TO 'responsable'@'localhost';
GRANT INSERT ON * . * TO 'responsable'@'localhost';
GRANT DELETE ON * . * TO 'responsable'@'localhost';
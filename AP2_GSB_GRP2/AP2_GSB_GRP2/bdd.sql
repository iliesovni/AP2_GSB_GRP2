-- Script de création de la base de données GSB
-- Création de la base de données
CREATE DATABASE BDD_GSB; 
USE BDD_GSB;
CREATE TABLE DECISION (
    DCS_ID INT NOT NULL PRIMARY KEY,
    DCS_LIBELLE VARCHAR5(15) NOT NULL
);

CREATE TABLE ETAPE (
    ETP_NUM INT NOT NULL PRIMARY KEY,
    ETP_LIBELLE VARCHAR2(50) NOT NULL
);

CREATE TABLE SUBIR (
    DATE_DECISION DATE NOT NULL UNIQUE,
    ETP_NUM_SUBIR INT NOT NULL UNIQUE,
    MED_DEPOTLEGAL_SUBIR VARCHAR(10) NOT NULL UNIQUE,
    DCS_ID_SUBIR INT NOT NULL UNIQUE,
    CONSTRAINT PK1 PRIMARY KEY  (ETP_NUM, MED_DEPOTLEGAL),
    CONSTRAINT FK1 FOREIGN KEY  (ETP_NUM_SUBIR) REFERENCES ETAPE(ETP_NUM),
    CONSTRAINT FK2 FOREIGN KEY  (MED_DEPOTLEGAL_SUBIR) REFERENCES MEDICAMENT(MED_DEPOTLEGAL),
    CONSTRAINT FK3 FOREIGN KEY  (DCS_ID_SUBIR) REFERENCES DECISION(DCS_ID)
);

CREATE TABLE MEDICAMENT (
    MED_DEPOTLEGAL VARCHAR(10) NOT NULL PRIMARY KEY,
    MED_NOMCOMMERCIAL VARCHAR(25) NOT NULL,
    MED_COMPOSITION VARCHAR(255) NOT NULL,
    MED_EFFETS VARCHAR(255) NOT NULL,
    MED_CONTREINDIC VARCHAR(255) NOT NULL,
    MED_AMM VARCHAR(10) NULL,
    FAM_CODE_MEDICAMENT VARCHAR(3) NOT NULL,
    CONSTRAINT FK1 FOREIGN KEY (FAM_CODE_MEDICAMENT) REFERENCES FAMILLE(FAM_CODE)
);

CREATE TABLE FAMILLE(
    FAM_CODE VARCHAR(3) NOT NULL PRIMARY KEY,
    FAM_LIBELLE VARCHAR2(80) NOT NULL,
    FAM_NB_MED_AMM INT 
)


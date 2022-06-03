DROP DATABASE IF EXISTS Empresa;
CREATE DATABASE Empresa;
USE Empresa;

CREATE TABLE Empregado(
	idEmpregado INT NOT NULL PRIMARY KEY,
    nome VARCHAR(30) NOT NULL,
    endereco VARCHAR(45) NOT NULL
);

CREATE TABLE Dependentes(
	idDependente INT NOT NULL AUTO_INCREMENT,
    PRIMARY KEY(idDependente),
    nome VARCHAR(45) NOT NULL,
    endereco VARCHAR(45) NOT NULL,
    fkEmpregado INT,
    CONSTRAINT fk_Empregado
		FOREIGN KEY(fkEmpregado) REFERENCES Empregado(idEmpregado)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);
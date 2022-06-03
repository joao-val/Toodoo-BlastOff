DROP DATABASE IF EXISTS Empresa;
CREATE DATABASE Empresa;
USE Empresa;

CREATE TABLE Empregado(
	idEmpregado INT NOT NULL PRIMARY KEY,
    nome VARCHAR(30) NOT NULL,
    endereco VARCHAR(45) NOT NULL
);

CREATE TABLE Projeto(
	idProjeto INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    setor VARCHAR(45) NOT NULL
);

CREATE TABLE Empregado_has_Projeto(
	fkEmpregado INT,
    fkProjeto INT,
    data_conclusao DATE,
    PRIMARY KEY(fkEmpregado, fkProjeto),
    CONSTRAINT fk_Empregado FOREIGN KEY(fkEmpregado) REFERENCES Empregado(idEmpregado),
    CONSTRAINT fk_Projeto FOREIGN KEY(fkProjeto) REFERENCES Projeto(idProjeto)
);
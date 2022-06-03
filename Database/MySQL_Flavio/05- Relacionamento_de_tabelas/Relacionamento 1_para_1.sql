CREATE DATABASE Empresa;
USE Empresa;

CREATE TABLE Empregado(
	idEmpregado INT NOT NULL PRIMARY KEY,
    nome VARCHAR(30) NOT NULL,
    endereco VARCHAR(45) NOT NULL
);

CREATE TABLE Departamento(
	idDepartamaneto INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(45) NOT NULL,
    qtd_projeto INT,
    fkEmpregado INT
);

SHOW TABLES;
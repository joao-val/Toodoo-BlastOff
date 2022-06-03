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

INSERT INTO Empregado() VALUES (1, 'Felipe', 'Rua1'), (2, 'Flavio', 'Rua2'),
(3, 'Fernando', 'Rua3');

INSERT INTO Projeto(nome, setor) VALUES('Guitarra', 3), ('Bateria', 50),
('Amplificador Valvulado', 30);

INSERT INTO Empregado_has_Projeto() VALUES (3, 2, '2021-12-25'), (2, 1, '2022-04-10'),
(2, 3, '2022-04-10');

SELECT * FROM Empregado_has_Projeto;

SELECT E.nome, P.nome, EP.data_conclusao FROM Empregado AS E 
JOIN Empregado_has_Projeto AS EP ON E.idEmpregado = EP.fkEmpregado 
JOIN Projeto AS P ON P.idProjeto = EP.fkProjeto;

SELECT Empregado.nome, Projeto.nome, Empregado_has_projeto.data_conclusao 
FROM Empregado_has_Projeto 
JOIN Empregado ON Empregado_has_Projeto.fkEmpregado = Empregado.idEmpregado
JOIN Projeto ON Projeto.idProjeto = Empregado_has_Projeto.fkProjeto;

SELECT E.nome, P.nome, EP.data_conclusao FROM Empregado AS E 
RIGHT OUTER JOIN Empregado_has_Projeto AS EP ON E.idEmpregado = EP.fkEmpregado
RIGHT OUTER JOIN Projeto AS P ON P.idProjeto = EP.fkProjeto;
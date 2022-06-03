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

INSERT INTO Empregado(idEmpregado, nome, endereco) VALUES('1', 'Flavio', 'Rua1'),
('2', 'Flavio', 'Rua2'), ('3', 'Fernando', 'Rua3');

INSERT INTO Empregado() VALUES ('1', 'Felipe', 'Rua');

DELETE FROM Empregado WHERE idEmpregado = 1;

SELECT DISTINCT nome, idEmpregado, idEmpregado+4 FROM Empregado;
SELECT * FROM Empregado ORDER BY nome;

INSERT INTO Dependentes(nome, endereco, fkEmpregado) VALUES('Vanessa', 'Rua10', 2),
('Vania', 'Rua3', 3), ('João', 'Rua50', 2), ('Maria', 'Rua50', 2);

SELECT * FROM Dependentes GROUP BY idDependente HAVING (idDependente <=4);

SELECT * FROM Dependentes WHERE idDependente = 2 OR fkEmpregado = 3;

SELECT * FROM Dependentes WHERE nome LIKE 'Va_%'; # % = qualquer carácter

SELECT * FROM Dependentes WHERE idDependente BETWEEN 2 AND 3;

SELECT AVG(idDependente) FROM Dependentes;
SELECT COUNT(idDependente) FROM Dependentes;

SELECT nome FROM Dependentes WHERE idDependente IN (SELECT MAX(idDependente) FROM Dependentes);

SELECT MIN(idDependente), nome FROM Dependentes;

INSERT INTO Dependentes(nome, endereco) VALUES ('Pedro', 'Rua250');

# Mostra todos os registros relacionados
SELECT E.nome AS "Empregado", D.nome AS 'Dependente' FROM Empregado AS E 
JOIN Dependentes AS D ON D.fkEmpregado = E.idEmpregado ORDER BY D.nome;

# Mostra todos os registros a direita do JOIN
SELECT E.nome AS "Empregado", D.nome AS 'Dependente' FROM Empregado AS E 
RIGHT OUTER JOIN Dependentes AS D ON D.fkEmpregado = E.idEmpregado ORDER BY D.nome;

# Mostra todos os registros a esquerda do JOIN
SELECT E.nome AS "Empregado", D.nome AS 'Dependente' FROM Empregado AS E 
LEFT OUTER JOIN Dependentes AS D ON D.fkEmpregado = E.idEmpregado ORDER BY D.nome;
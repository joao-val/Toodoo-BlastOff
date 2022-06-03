DROP DATABASE IF EXISTS Aula_Flavio13;
CREATE DATABASE Aula_Flavio13;
USE Aula_Flavio13;

CREATE TABLE Estoque(
	cod_item INT NOT NULL PRIMARY KEY,
    quantidade_disponivel INT
);

CREATE TABLE Itens_solicitacao(
	id_solicitacao INT AUTO_INCREMENT PRIMARY KEY,
    cod_item INT NOT NULL,
    nome VARCHAR(20),
    quantidade INT
);

INSERT INTO Itens_solicitacao(cod_item, nome, quantidade) VALUES
(100, 'Resistor 100k', 5), (110, 'Resistor 1k', 2), (120, 'Capacitor 100n', 2),
(130, 'Transistor TBJ', 1);

INSERT INTO Estoque(cod_item, quantidade_disponivel) VALUES
(100, 1500), (110, 500), (120, 300), (130, 600);

SELECT * FROM Itens_solicitacao;

CREATE VIEW compra AS (
	SELECT I.nome AS 'Item', E.quantidade_disponivel AS 'Quantidade no estoque' 
    FROM Itens_solicitacao AS I 
    JOIN Estoque AS E ON E.cod_item = I.cod_item
);

DROP VIEW compra;

SELECT * FROM compra;
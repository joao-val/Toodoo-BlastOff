DROP DATABASE IF EXISTS AulaFlavio;
CREATE DATABASE AulaFlavio;
USE AulaFlavio;

CREATE TABLE Produto(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(45)
);

DELIMITER $$
DROP PROCEDURE IF EXISTS cadProd $$
CREATE PROCEDURE cadProd(nome_tabela VARCHAR(45))
	BEGIN
		INSERT INTO Produto(nome) VALUES (nome_tabela);
		SELECT * FROM Produto;
	END $$
DELIMITER ;

CALL cadProd('Piano');
CALL cadProd('Flauta');
CALL cadProd('Guitarra');

DELIMITER $$
DROP PROCEDURE IF EXISTS soma $$
CREATE PROCEDURE soma(num1 INT, num2 INT)
	BEGIN
		SELECT num1 + num2 AS SOMA;
	END $$
DELIMITER ;

CALL soma(-10, 7);

DROP PROCEDURE soma;

DELIMITER $$
DROP PROCEDURE IF EXISTS testeif $$
CREATE PROCEDURE testeif(num1 INT, num2 INT)
	BEGIN
		DECLARE soma INT;
        DECLARE resultado VARCHAR(15);
        SET soma = num1 + num2;
        
        IF soma > 0 THEN
			SET resultado = 'Positiva';
		ELSEIF soma < 0 THEN
			SET resultado = 'Negativa';
		ELSE
			SET resultado = 'Neutra';
		END IF;
        SELECT CONCAT('A soma entre ', num1, ' e ', num2, ' é: ', resultado) AS resultado;        
	END $$
DELIMITER ;

CALL testeif(2, 2);
CALL testeif(-10, 3);
CALL testeif(5, -5);

DELIMITER $$
DROP PROCEDURE IF EXISTS fatorial $$
CREATE PROCEDURE fatorial(num INT)
	BEGIN
		DECLARE resposta INT;
        DECLARE respostaNum INT;
        SET respostaNum = num;
        SET resposta = 1;
        
        WHILE num > 0 DO
			SET resposta = resposta * num;
            SET num  = num - 1;
		END WHILE;
        SELECT CONCAT('O fatorial de ', respostaNum, ' é: ', resposta) AS RESPOSTA;
	END $$
DELIMITER ;

CALL fatorial(7);
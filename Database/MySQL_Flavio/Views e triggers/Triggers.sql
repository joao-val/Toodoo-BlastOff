DROP DATABASE IF EXISTS Aula_Flavio13;
CREATE DATABASE Aula_Flavio13;
USE Aula_Flavio13;

SET SQL_SAFE_UPDATES = 0;

CREATE TABLE conta(
	numero INT, 
    total DECIMAL(10, 2)
);

CREATE TABLE Nomes(
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(30)
);

CREATE TRIGGER ins_soma BEFORE INSERT ON conta
FOR EACH ROW
	SET @soma = @soma + NEW.total;    


SET soma = 0;
INSERT INTO conta() VALUES (137, 14.98), (141, 1937.50), (97, 100.00);
SELECT @soma;

DELETE FROM conta WHERE numero > 0;

DELIMITER $$
CREATE TRIGGER update_check BEFORE UPDATE ON conta
FOR EACH ROW
	BEGIN
		IF NEW.total < 0 THEN
			SET NEW.total = 0;
		ELSEIF NEW.total > 100 THEN
			SET NEW.total = 100;
		END IF;
    END; $$
DELIMITER ;

SELECT * FROM conta;
UPDATE conta SET total = 35 WHERE numero = 137;

DELIMITER //
CREATE TRIGGER atualiza AFTER UPDATE ON Nomes
FOR EACH ROW
	BEGIN
		SET @var_old = OLD.nome;
        SET @var_new = NEW.nome;
    END; //
DELIMITER ;

SELECT * FROM Nomes;
SELECT @var_old;
SELECT @var_new;
UPDATE Nomes SET nome = 'Antônio' WHERE id = 1;
USE AulaFlavio;

SET GLOBAL log_bin_trust_function_creators = 1;

DELIMITER $$
DROP FUNCTION IF EXISTS mult $$
CREATE FUNCTION mult(num1 FLOAT, num2 FLOAT) RETURNS FLOAT
	BEGIN
		RETURN num1*num2;
	END $$
DELIMITER ;

SELECT mult(3.2, 2);

CREATE TABLE Aluno(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(60) NOT NULL,
    nota1 INT,
    nota2 INT,
    faltas INT
);

DELIMITER $$
DROP FUNCTION IF EXISTS situacao $$
CREATE FUNCTION situacao(nota_1 INT, nota_2 INT, faltas_aluno INT) RETURNS VARCHAR(15)
	BEGIN
		DECLARE media FLOAT;
        DECLARE resposta VARCHAR(15);
        
        SET media = (nota_1 + nota_2)/2;
        IF media >= 60 AND faltas_aluno <= 10 THEN
			SET resposta = 'Aprovado';
		ELSEIF media < 30 OR faltas_aluno > 10 THEN
			SET resposta = 'Reprovado';
		ELSEIF media > 30 AND media < 60 AND faltas_aluno <= 10 THEN
			SET resposta = 'NP3';
		END IF;
        RETURN resposta;
	END $$
DELIMITER ;

SELECT situacao(60, 60, 2);

INSERT INTO Aluno(nome, nota1, nota2, faltas) VALUES 
('Flávio', 35, 60, 2), ('Rita', 100, 100, 20), ('João', 96, 60, 2);

SELECT * FROM Aluno;
SELECT nome, situacao(nota1, nota2,faltas) FROM Aluno;

DELIMITER $$
DROP PROCEDURE IF EXISTS avalia $$
CREATE PROCEDURE avalia(nome_aluno VARCHAR(60), nota1_aluno INT, nota2_aluno INT, faltas_aluno INT)
	BEGIN
		DECLARE resultado VARCHAR(15);
        SET resultado = (SELECT situacao(nota1_aluno, nota2_aluno, faltas_aluno));
        
        IF resultado = 'Aprovado' THEN
			INSERT INTO Aluno (nome, nota1, nota2, faltas) VALUES (nome_aluno, nota1_aluno, nota2_aluno, faltas_aluno);
		END IF;
    END $$
DELIMITER ;

SELECT * FROM Aluno;

CALL avalia('Flávio', 35, 60, 2);
CALL avalia('Rita', 100, 100, 20);
CALL avalia('João', 96, 60, 2);

SELECT situacao(100, 100, 20);